using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SabeTaoBemLibrary.Models.Users;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;


namespace SabeTaoBem
{
    public partial class UserControlUsers : UserControl
    {

        //DataTable and DataView to store data to then transfer to listview
        private DataTable dt;
        private DataView dv;
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();

        public UserControlUsers()
        {
            InitializeComponent();


            //Datatable with the info to present to the user
            dt = new DataTable();
            dt.Columns.Add("FirstName");
            dt.Columns.Add("LastName");
            dt.Columns.Add("Username");
            dt.Columns.Add("Email");
            dt.Columns.Add("RegistrationData");
            dt.Columns.Add("Status");
            dt.Columns.Add("IdUser");
            dt.Columns.Add("UserFunctionId");
            dt.Columns.Add("LoginId");
            dt.Columns.Add("StatusId");


            //Fill Datatable, dataview and listview
            getData();

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
                    HttpResponseMessage response = await client.GetAsync("api/users");
                    List<UsersDetail> user = await response.Content.ReadAsAsync<List<UsersDetail>>();

                    fillDataTable(user);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //Transfer the data from list to datatable
        private void fillDataTable(List<UsersDetail> users)
        {
            dt.Rows.Clear();
            foreach (UsersDetail user in users)
            {
                dt.Rows.Add(user.firstname, user.lastname, user.username, user.email, user.registrationDate, user.Status, user.iduser, user.userfunctionid, user.loginid, user.StatusId);
            }

            dv = new DataView(dt);
            populateLisView(dv);
        }

        //Fill listview from dataview
        private void populateLisView(DataView dv)
        {
            listViewUsers.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listViewUsers.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() }));
            }
        }

        //Update list
        private async void updateList(Users userToUpdate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsJsonAsync("api/users", userToUpdate).Result;
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



        //Changing the list view filters
        private void RadioBtnPending_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dv.RowFilter = string.Format("Status like 'PENDENTE'");
                populateLisView(dv);
            }
            catch
            {
                MessageBox.Show("Não existe dados para filtar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioBtnApproved_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dv.RowFilter = string.Format("Status like 'APROVADO'");
                populateLisView(dv);
            }
            catch
            {
                MessageBox.Show("Não existe dados para filtar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioBtnNotApproved_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                dv.RowFilter = string.Format("Status like 'NÃO APROVADO'");
                populateLisView(dv);
            }
            catch
            {
                MessageBox.Show("Não existe dados para filtar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioBtnBlocked_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dv.RowFilter = string.Format("Status like 'BLOQUEADO'");
                populateLisView(dv);
            }
            catch
            {
                MessageBox.Show("Não existe dados para filtar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RadioBtnAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                dv.RowFilter = string.Empty;
                populateLisView(dv);
            }
            catch
            {
                MessageBox.Show("Não existe dados para filtar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        //Change the user status
        private void BtnApprove_Click(object sender, EventArgs e)
        {

            try
            {
                int selIndex = listViewUsers.SelectedIndices[0];
                if (Convert.ToInt32(dt.Rows[selIndex][9]) == 1 || Convert.ToInt32(dt.Rows[selIndex][9]) == 3)
                {
                    Users userToUpdate = new Users();
                    userToUpdate.IdUser = Convert.ToInt32(dt.Rows[selIndex][6]);
                    userToUpdate.FirstName = dt.Rows[selIndex][0].ToString();
                    userToUpdate.LastName = dt.Rows[selIndex][1].ToString();
                    userToUpdate.Email = dt.Rows[selIndex][3].ToString();
                    userToUpdate.UserFunctionId = Convert.ToByte(dt.Rows[selIndex][7]);
                    userToUpdate.LoginId = Convert.ToInt32(dt.Rows[selIndex][8]);
                    userToUpdate.StatusId = 2;

                    //Update list, dataTable and Listview
                     updateList(userToUpdate);
                }
                else
                {
                    MessageBox.Show("O utilizador só pode ser 'aprovado se o seu estado atual for PENDENTE ou NÃO APROVADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione o utilizador do qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnNotApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int selIndex = listViewUsers.SelectedIndices[0];
                if (Convert.ToInt32(dt.Rows[selIndex][9]) == 1)
                {
                    Users userToUpdate = new Users();
                    userToUpdate.IdUser = Convert.ToInt32(dt.Rows[selIndex][6]);
                    userToUpdate.FirstName = dt.Rows[selIndex][0].ToString();
                    userToUpdate.LastName = dt.Rows[selIndex][1].ToString();
                    userToUpdate.Email = dt.Rows[selIndex][3].ToString();
                    userToUpdate.UserFunctionId = Convert.ToByte(dt.Rows[selIndex][7]);
                    userToUpdate.LoginId = Convert.ToInt32(dt.Rows[selIndex][8]);
                    userToUpdate.StatusId = 3;

                    //Update list, dataTable and Listview
                    updateList(userToUpdate);
                }
                else
                {
                    MessageBox.Show("O utilizador só pode ser 'não aprovado' se o seu estado atual for PENDENTE.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione o utilizador do qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBlock_Click(object sender, EventArgs e)
        {
            try
            {
                int selIndex = listViewUsers.SelectedIndices[0];
                if (Convert.ToInt32(dt.Rows[selIndex][9]) == 2)
                {
                    Users userToUpdate = new Users();
                    userToUpdate.IdUser = Convert.ToInt32(dt.Rows[selIndex][6]);
                    userToUpdate.FirstName = dt.Rows[selIndex][0].ToString();
                    userToUpdate.LastName = dt.Rows[selIndex][1].ToString();
                    userToUpdate.Email = dt.Rows[selIndex][3].ToString();
                    userToUpdate.UserFunctionId = Convert.ToByte(dt.Rows[selIndex][7]);
                    userToUpdate.LoginId = Convert.ToInt32(dt.Rows[selIndex][8]);
                    userToUpdate.StatusId = 4;

                    //Update list, dataTable and Listview
                    updateList(userToUpdate);
                }
                else
                {
                    MessageBox.Show("O utilizador só pode ser 'bloqueado' se o seu estado atual for APROVADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione o utilizador do qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnUnBlock_Click(object sender, EventArgs e)
        {
            try
            {
                int selIndex = listViewUsers.SelectedIndices[0];
                if (Convert.ToInt32(dt.Rows[selIndex][9]) == 4)
                {
                    Users userToUpdate = new Users();
                    userToUpdate.IdUser = Convert.ToInt32(dt.Rows[selIndex][6]);
                    userToUpdate.FirstName = dt.Rows[selIndex][0].ToString();
                    userToUpdate.LastName = dt.Rows[selIndex][1].ToString();
                    userToUpdate.Email = dt.Rows[selIndex][3].ToString();
                    userToUpdate.UserFunctionId = Convert.ToByte(dt.Rows[selIndex][7]);
                    userToUpdate.LoginId = Convert.ToInt32(dt.Rows[selIndex][8]);
                    userToUpdate.StatusId = 2;

                    //Update list, dataTable and Listview
                   updateList(userToUpdate);
                }
                else
                {
                    MessageBox.Show("O utilizador só pode ser 'desbloqueado' se o seu estado atual for BLOQUEADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione o utilizador do qual deseja alterar estado.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //List view formatting
        SolidBrush myGreenBrush = new SolidBrush(Color.FromArgb(255, 116, 194, 75));


        private void ListViewUsers_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void ListViewUsers_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void ListViewUsers_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if ((e.ItemState & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, listViewUsers.Font, SystemBrushes.HighlightText, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawText();
            }
        }

    
    }
}
