using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SabeTaoBemLibrary;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using SabeTaoBemLibrary.Models.Units;

namespace SabeTaoBem
{
    public partial class UserControlUnits : UserControl
    {
        //DataTable and DataView to store data to then transfer to listview
        private DataTable dt;
        private DataView dv;
        private DataTable dt_cat;
        private DataTable dt_sys;
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();


        public UserControlUnits()
        {
            InitializeComponent();

            //Populate listviewIngredients
            //Initialize Datatable and add columns
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("System");
            dt.Columns.Add("IdUnit");
            dt.Columns.Add("UnitCategoryId");
            dt.Columns.Add("UnitSystemId");

            //Datatbale with category
            dt_cat = new DataTable();
            dt_cat.Columns.Add("idCategory");
            dt_cat.Columns.Add("Category");

            //Datatbale with system
            dt_sys = new DataTable();
            dt_sys.Columns.Add("idSystem");
            dt_sys.Columns.Add("System");


            //Fill Datatable, dataview and listview
            getData();
            populateComboboxCat();
            populateComboboxSys();

        }



        //Get the Data to fill a list
        private async void getData()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("api/units");
                    List<UnitDetail> unit = await response.Content.ReadAsAsync<List<UnitDetail>>();

                    fillDataTable(unit);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void populateComboboxCat()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("api/UnitCategory");
                    List<UnitCategory> category = await response.Content.ReadAsAsync<List<UnitCategory>>();

                    cmbCategory.Items.Clear();
                    cmbCategorySearch.Items.Clear();
                    foreach (UnitCategory cat in category)
                    {
                        cmbCategory.Items.Add(cat.Category);
                        cmbCategorySearch.Items.Add(cat.Category);
                        dt_cat.Rows.Add(cat.Id, cat.Category);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void populateComboboxSys()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("api/UnitSystem");
                    List<UnitSystem> system = await response.Content.ReadAsAsync<List<UnitSystem>>();

                    cmbSystem.Items.Clear();
                    cmbSystemSearch.Items.Clear();
                    foreach (UnitSystem sys in system)
                    {
                        cmbSystem.Items.Add(sys.System);
                        cmbSystemSearch.Items.Add(sys.System);
                        dt_sys.Rows.Add(sys.Id, sys.System);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Transfer the data from list to datatable
        private void fillDataTable(List<UnitDetail> units)
        {
            dt.Rows.Clear();
            foreach (UnitDetail unit in units)
            {
                dt.Rows.Add(unit.UnitName, unit.Category, unit.System, unit.IdUnit, unit.UnitCategoryId, unit.UnitSystemId);
            }

            dv = new DataView(dt);
            populateLisView(dv);
        }

        //Fill listview from dataview
        private void populateLisView(DataView dv)
        {
            listViewUnits.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listViewUnits.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));
            }
        }

        //Update list
        private void updateList(Units unitToUpdate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsJsonAsync("api/units", unitToUpdate).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Erro a atualizar a informação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                dt.Clear();
                getData();

            }
            catch
            {
                MessageBox.Show("Erro ao tentar atualizar os dados no servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //Form Events
        private void ListViewUnits_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //Puts the data of the selected row in the textbox and combobox
                txtName.Text = listViewUnits.SelectedItems[0].SubItems[0].Text;
                cmbCategory.Text = listViewUnits.SelectedItems[0].SubItems[1].Text;
                cmbSystem.Text = listViewUnits.SelectedItems[0].SubItems[2].Text;
            }
            catch (Exception ex)
            {
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Checks if the Name and Category fields are not empty
            if (txtName.Text == string.Empty || cmbCategory.Text == String.Empty || cmbSystem.Text == String.Empty)
            {
                //Warns the user that he need to fill both fields
                MessageBox.Show("Por favor introduza o nome da unidade, a sua categoria e sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Units unitToInsert = new Units();
                unitToInsert.UnitName = txtName.Text;

                int selIndexCat = cmbCategory.SelectedIndex;
                int selIndexSys = cmbSystem.SelectedIndex;
                unitToInsert.UnitCategoryId = Convert.ToByte(dt_cat.Rows[selIndexCat][0]);
                unitToInsert.UnitSystemId = Convert.ToByte(dt_sys.Rows[selIndexSys][0]);

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(apiURL);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var response = client.PostAsJsonAsync("api/units", unitToInsert).Result;
                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Erro a atualizar a informação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    dt.Clear();
                    getData();

                    txtName.Clear();
                    cmbCategory.Text = String.Empty;
                    cmbSystem.Text = String.Empty;
                }
                catch
                {
                    MessageBox.Show("Erro ao tentar atualizar os dados no servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Checks if there is any row selectd
            if (listViewUnits.SelectedItems.Count > 0)
            {
                //Check if both fields are filled
                if (txtName.Text != string.Empty && cmbCategory.Text != String.Empty && cmbSystem.Text != String.Empty)
                {
                    Units unitToUpdate = new Units();

                    int idSelected = listViewUnits.SelectedIndices[0];
                    unitToUpdate.IdUnit = Convert.ToByte(dt.Rows[idSelected][3]);
                    unitToUpdate.UnitName = txtName.Text;

                    int selIndexCat = cmbCategory.SelectedIndex;
                    unitToUpdate.UnitCategoryId = Convert.ToByte(dt_cat.Rows[selIndexCat][0]);

                    int selIndexSys = cmbSystem.SelectedIndex;
                    unitToUpdate.UnitSystemId = Convert.ToByte(dt_sys.Rows[selIndexSys][0]);

                    updateList(unitToUpdate);
                    txtName.Clear();
                    cmbCategory.Text = String.Empty;
                    cmbSystem.Text = String.Empty;
                }
                else
                {
                    //Warns the user that he need to fill both fields
                    MessageBox.Show("Por favor introduza o nome da unidade, a sua categoria e sistema.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Warns user that need to select a row
                MessageBox.Show("Por favor selecione a linha que quer alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            //Checks if there is any row selectd
            if (listViewUnits.SelectedItems.Count > 0)
            {
                int selIndex = listViewUnits.SelectedIndices[0];
                int idUnit = Convert.ToInt32(dt.Rows[selIndex][3]);

                try
                {
                    using (HttpClient client = new HttpClient())
                    {

                        client.BaseAddress = new Uri(apiURL);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var response = client.DeleteAsync("api/units/" + idUnit.ToString()).Result;
                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Erro a atualizar a informação.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        dt.Clear();
                        getData();
                        txtName.Clear();
                        cmbCategory.Text = String.Empty;
                        cmbSystem.Text = String.Empty;

                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao tentar atualizar os dados no servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //Warns user that need to select a row
                MessageBox.Show("Por favor selecione a linha que quer alterar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            //Clear textbox and combobox
            txtName.Clear();
            cmbCategory.Text = String.Empty;
            cmbSystem.Text = String.Empty;
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInDataView();
        }

        private void CmbCategorySearch_TextChanged(object sender, EventArgs e)
        {
            SearchInDataView();
        }

        private void CmbSystemSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInDataView();
        }

        //Variable declaration - filter to apply in dv
        string filter = "";
        private void SearchInDataView()
        {
            //Variables declaration
            string filterName = String.Empty, filterCategory = String.Empty, filterSystem = String.Empty;
            int nameEmptyOrFull = 0, categoryEmptyOrFull = 0, systemEmptyOrFull = 0, allFilters = 0;

            //Check if textbox and combobox are empty
            if (txtNameSearch.Text != String.Empty)
            {
                filterName = string.Format("Name like '%{0}%'", txtNameSearch.Text);
                nameEmptyOrFull = 1;
            }


            if (cmbCategorySearch.Text != String.Empty)
            {
                filterCategory = string.Format("Category like '%{0}%'", cmbCategorySearch.Text);
                categoryEmptyOrFull = 2;
            }

            if (cmbSystemSearch.Text != String.Empty)
            {
                filterSystem = string.Format("System like '%{0}%'", cmbSystemSearch.Text);
                systemEmptyOrFull = 4;
            }


            //Combine all filters
            allFilters = nameEmptyOrFull + categoryEmptyOrFull + systemEmptyOrFull;


            switch (allFilters)
            {
                case 1:
                    filter = filterName;
                    break;
                case 2:
                    filter = filterCategory;
                    break;
                case 3:
                    filter = filterName + " and " + filterCategory;
                    break;
                case 4:
                    filter = filterSystem;
                    break;
                case 5:
                    filter = filterName + " and " + filterSystem;
                    break;
                case 6:
                    filter = filterCategory + " and " + filterSystem;
                    break;
                case 7:
                    filter = filterName + " and " + filterCategory + " and " + filterSystem;
                    break;
                default:
                    filter = String.Empty;
                    break;
            }


            //Apply filter do dv and listview
            dv.RowFilter = filter;
            populateLisView(dv);
        }


        //List view formatting
        SolidBrush myGreenBrush = new SolidBrush(Color.FromArgb(255, 116, 194, 75));
        private void ListViewUnits_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            using (var sf = new StringFormat())
            {
                sf.Alignment = StringAlignment.Center;

                using (var headerFont = new Font("Segoe Print", 11, FontStyle.Bold))
                {
                    e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.White, e.Bounds, sf);
                }
            }
        }

        private void ListViewUnits_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void ListViewUnits_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if ((e.ItemState & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, listViewUnits.Font, SystemBrushes.HighlightText, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawText();
            }
        }



    }
}
