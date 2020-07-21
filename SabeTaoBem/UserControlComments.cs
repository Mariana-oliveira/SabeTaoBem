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
using System.Net.Http;
using System.Net.Http.Headers;
using SabeTaoBemLibrary.Models.Comments;
using System.Configuration;
using Newtonsoft.Json.Linq;

namespace SabeTaoBem
{
    public partial class UserControlComments : UserControl
    {
        //DataTable and DataView to store data to then transfer to listview
        private DataTable dt;
        private DataView dv;
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();

        public UserControlComments()
        {
            InitializeComponent();

            //Datatable with the info to present to the user
            dt = new DataTable();
            dt.Columns.Add("Comment ID");
            dt.Columns.Add("Comment");
            dt.Columns.Add("Recipe Name");
            dt.Columns.Add("Username");
            dt.Columns.Add("Date");
            dt.Columns.Add("Status");
            dt.Columns.Add("RecipeId");
            dt.Columns.Add("Userid");
            dt.Columns.Add("statusid");

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
                    HttpResponseMessage response = await client.GetAsync("api/comments");
                    List<CommentsDetail> comments = await response.Content.ReadAsAsync<List<CommentsDetail>>();

                    fillDataTable(comments);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }




        //Transfer the data from list to datatable
        private void fillDataTable(List<CommentsDetail> comments)
        {
            dt.Rows.Clear();
            foreach (CommentsDetail comment in comments)
            {
                dt.Rows.Add(comment.idComment, comment.Comment, comment.RecipeName, comment.Username, comment.commentdate, comment.status, comment.RecipeId, comment.Userid, comment.statusid);
            }

            dv = new DataView(dt);
            populateLisView(dv);
        }

        //Fill listview from dataview
        private void populateLisView(DataView dv)
        {
            listViewComments.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listViewComments.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString() }));
            }
        }

        //Update list
        private async void updateList(Comments commentToUpdate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsJsonAsync("api/comments", commentToUpdate).Result;
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



        //Change the comment's status
        private void BtnApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int selIndex = listViewComments.SelectedIndices[0];
                Comments commentToUpdate = new Comments();
                commentToUpdate.IdComment = Convert.ToInt32(dt.Rows[selIndex][0]);
                commentToUpdate.Comment = dt.Rows[selIndex][1].ToString();
                commentToUpdate.RecipeId = Convert.ToInt32(dt.Rows[selIndex][6]);
                commentToUpdate.UserId = Convert.ToInt32(dt.Rows[selIndex][7]);
                commentToUpdate.StatusID = 2;

                //Update list, dataTable and Listview
                updateList(commentToUpdate);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione o comentário do qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNotApprove_Click(object sender, EventArgs e)
        {
            try
            {
                //Update list, dataTable and Listview
                int selIndex = listViewComments.SelectedIndices[0];
                Comments commentToUpdate = new Comments();
                commentToUpdate.IdComment = Convert.ToInt32(dt.Rows[selIndex][0]);
                commentToUpdate.Comment = dt.Rows[selIndex][1].ToString();
                commentToUpdate.RecipeId = Convert.ToInt32(dt.Rows[selIndex][6]);
                commentToUpdate.UserId = Convert.ToInt32(dt.Rows[selIndex][7]);
                commentToUpdate.StatusID = 3;

                //Update list, dataTable and Listview
                updateList(commentToUpdate);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione o comentário do qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //List view formatting
        SolidBrush myGreenBrush = new SolidBrush(Color.FromArgb(255, 116, 194, 75));

        private void ListViewComments_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void ListViewComments_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void ListViewComments_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if ((e.ItemState & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, listViewComments.Font, SystemBrushes.HighlightText, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawText();
            }
        }

    }

}