using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Http;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using SabeTaoBemLibrary.Models.Ingredients;

namespace SabeTaoBem
{
    public partial class UserControlIngredients : UserControl
    {

        //DataTable and DataView to store data to then transfer to listview
        private DataTable dt;
        private DataTable dt_cat;
        private DataView dv;
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();


        public UserControlIngredients()
        {
            InitializeComponent();

            //Populate listviewIngredients
            //Initialize Datatable and add columns
            dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Category");
            dt.Columns.Add("IdIngredient");
            dt.Columns.Add("IngCategoryId");

                      

            //Datatbale with category
            dt_cat = new DataTable();
            dt_cat.Columns.Add("idCategory");
            dt_cat.Columns.Add("Category");


            //Fill Datatable, dataview and listview
            getData();
            populateCombobox();

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
                    HttpResponseMessage response = await client.GetAsync("api/ingredients");
                    List<IngredientDetail> ingredient = await response.Content.ReadAsAsync<List<IngredientDetail>>();

                    fillDataTable(ingredient);

                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void populateCombobox()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = await client.GetAsync("api/IngCategory");
                    List<IngCategory> category = await response.Content.ReadAsAsync<List<IngCategory>>();

                    cmbCategory.Items.Clear();
                    cmbCategorySearch.Items.Clear();
                    foreach (IngCategory cat in category)
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


        // Transfer the data from list to datatable
        private void fillDataTable(List<IngredientDetail> ingredients)
        {
            dt.Rows.Clear();
            foreach (IngredientDetail ingredient in ingredients)
            {
                dt.Rows.Add(ingredient.IngredientName, ingredient.category, ingredient.idIngredient, ingredient.ingCategoryId);
            }

            dv = new DataView(dt);
            populateLisView(dv);

        }

        //Fill listview from dataview
        private void populateLisView(DataView dv)
        {
            listViewIngredients.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listViewIngredients.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString() }));
            }
        }

        //Update list
        private async void updateList(Ingredient ingredientToUpdate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsJsonAsync("api/ingredients", ingredientToUpdate).Result;
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
        private void ListViewIngredients_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                //Puts the data of the selected row in the textbox and combobox
                txtName.Text = listViewIngredients.SelectedItems[0].SubItems[0].Text;
                cmbCategory.Text = listViewIngredients.SelectedItems[0].SubItems[1].Text;
            }
            catch 
            {
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //Checks if the Name and Category fields are not empty
            if (txtName.Text == string.Empty && cmbCategory.Text == String.Empty)
            {
                //Warns the user that he need to fill both fields
                MessageBox.Show("Por favor introduza o nome do ingrediente e a sua categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Ingredient ingredientToInsert = new Ingredient();
                ingredientToInsert.IngredientName = txtName.Text;

                int selIndex = cmbCategory.SelectedIndex;
                ingredientToInsert.IngCategoryId = Convert.ToByte(dt_cat.Rows[selIndex][0]);

                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(apiURL);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var response = client.PostAsJsonAsync("api/ingredients", ingredientToInsert).Result;
                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Erro a atualizar a informação.");
                        }
                    }

                    dt.Clear();
                    getData();
                    txtName.Clear();
                    cmbCategory.Text = String.Empty;
                }
                catch
                {
                    MessageBox.Show("Erro ao tentar atualizar os dados no servidor. Por favor tente novamente mais tarde.");
                }

            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //Checks if there is any row selectd
            if (listViewIngredients.SelectedItems.Count > 0)
            {
                Ingredient ingredientToUpdate = new Ingredient();

                int idSelected = listViewIngredients.SelectedIndices[0];
                ingredientToUpdate.IdIngredient = Convert.ToInt32(dt.Rows[idSelected][2]);
                ingredientToUpdate.IngredientName = txtName.Text;

                int selIndex = cmbCategory.SelectedIndex;
                ingredientToUpdate.IngCategoryId = Convert.ToByte(dt_cat.Rows[selIndex][0]);

                updateList(ingredientToUpdate);
                txtName.Clear();
                cmbCategory.Text = String.Empty;

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
            if (listViewIngredients.SelectedItems.Count > 0)
            {

                int selIndex = listViewIngredients.SelectedIndices[0];
                int idIngredient = Convert.ToInt32(dt.Rows[selIndex][2]);

                try
                {
                    using (HttpClient client = new HttpClient())
                    {

                        client.BaseAddress = new Uri(apiURL);
                        client.DefaultRequestHeaders.Accept.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        var response = client.DeleteAsync("api/ingredients/" + idIngredient.ToString()).Result;
                        if (!response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Erro a atualizar a informação.");
                        }

                        
                        dt.Clear();
                        getData();
                        txtName.Clear();
                        cmbCategory.Text = String.Empty;

                    }
                }
                catch
                {
                    MessageBox.Show("Erro ao tentar atualizar os dados no servidor. Por favor tente novamente mais tarde.");
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
        }




        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchInDataView();
        }

        private void CmbCategorySearch_TextChanged(object sender, EventArgs e)
        {
            SearchInDataView();
        }


        //Variable declaration - filter to apply in dv
        string filter = "";
        private void SearchInDataView()
        {
            //Variables declaration
            string filterName = String.Empty, filterCategory = String.Empty;
            int nameEmptyOrFull = 0, categoryEmptyOrFull = 0, allFilters = 0;

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


            //Combine all filters
            allFilters = nameEmptyOrFull + categoryEmptyOrFull;


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

        private void ListViewIngredients_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void ListViewIngredients_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void ListViewIngredients_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if ((e.ItemState & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, listViewIngredients.Font, SystemBrushes.HighlightText, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawText();
            }
        }


    }
}
