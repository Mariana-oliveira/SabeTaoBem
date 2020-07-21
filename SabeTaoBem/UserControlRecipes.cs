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
using SabeTaoBemLibrary.Models.Recipes;
using SabeTaoBemLibrary.Models.RecipeIngredients;

namespace SabeTaoBem
{
    public partial class UserControlRecipes : UserControl
    {
        //DataTable and DataView to store data to then transfer to listview
        private DataTable dt;
        private DataView dv;
        string apiURL = ConfigurationManager.AppSettings["ApiBaseAdress"].ToString();


        public UserControlRecipes()
        {
            InitializeComponent();

            //Initialize Datatable and add columns
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("RecipeName");
            dt.Columns.Add("Username");
            dt.Columns.Add("CreationData");
            dt.Columns.Add("Category");
            dt.Columns.Add("Style");
            dt.Columns.Add("Status");
            dt.Columns.Add("UserId");
            dt.Columns.Add("RecCategoryId");
            dt.Columns.Add("RecFoodStyleId");
            dt.Columns.Add("RecDifficultyLevelId");
            dt.Columns.Add("DifficultyLevel");
            dt.Columns.Add("RecMealCostId");
            dt.Columns.Add("MealCost");
            dt.Columns.Add("PreparationTime");
            dt.Columns.Add("CookTime");
            dt.Columns.Add("Doses");
            dt.Columns.Add("Evaluation");
            dt.Columns.Add("Description");
            dt.Columns.Add("Picture");
            dt.Columns.Add("idStatus");

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
                    HttpResponseMessage response = await client.GetAsync("api/recipes");
                    List<RecipeDetail> recipe = await response.Content.ReadAsAsync<List<RecipeDetail>>();

                    fillDataTable(recipe);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.");
            }
            
        }


        //Transfer the data from list to datatable
        private void fillDataTable(List<RecipeDetail> recipes)
        {
            dt.Rows.Clear();
            foreach (RecipeDetail recipe in recipes)
            {
                dt.Rows.Add(recipe.idrecipe,recipe.RecipeName, recipe.Username, recipe.CreationDate, recipe.Category, recipe.FoodStyle, recipe.Status, recipe.userid, recipe.RecCategoryId, recipe.RecFoodStyleId, 
                    recipe.RecDifficultyLevelId, recipe.DifficultyLevel, recipe.RecMealCostId, recipe.MealCost, recipe.PreparationTime, recipe.CookTime, recipe.Doses, recipe.Evaluation, recipe.Description, 
                    recipe.Picture, recipe.idStatus);
            }

            dv = new DataView(dt);
            populateLisView(dv);
        }

        //Fill listview from dataview
        private void populateLisView(DataView dv)
        {
            listViewRecipes.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listViewRecipes.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString() }));
            }
        }

        //Update list
        private void updateList(Recipes recipeToUpdate)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = client.PutAsJsonAsync("api/recipes", recipeToUpdate).Result;
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



        //Change the recipe status
        private void BtnAproved_Click(object sender, EventArgs e)
        {
            try
            {
                int selIndex = listViewRecipes.SelectedIndices[0];
                Recipes recipeToUpdate = new Recipes();
                recipeToUpdate.IdRecipe = Convert.ToInt32(dt.Rows[selIndex][0]);
                recipeToUpdate.RecipeName = dt.Rows[selIndex][1].ToString();
                recipeToUpdate.UserId = Convert.ToInt32(dt.Rows[selIndex][7]);
                recipeToUpdate.RecCategoryId = Convert.ToByte(dt.Rows[selIndex][8]);
                recipeToUpdate.RecFoodStyleId = Convert.ToByte(dt.Rows[selIndex][9]);
                recipeToUpdate.RecDifficultyLevelId = Convert.ToByte(dt.Rows[selIndex][10]);
                recipeToUpdate.RecMealCostId = Convert.ToByte(dt.Rows[selIndex][12]);
                recipeToUpdate.PreparationTime = Convert.ToByte(dt.Rows[selIndex][14]);
                recipeToUpdate.CookTime = Convert.ToByte(dt.Rows[selIndex][15]);
                recipeToUpdate.Doses = Convert.ToByte(dt.Rows[selIndex][16]);
                recipeToUpdate.Evaluation = Convert.ToDecimal(dt.Rows[selIndex][17]);
                recipeToUpdate.Description = dt.Rows[selIndex][18].ToString();
                recipeToUpdate.idStatus = 2;

                //Update list, dataTable and Listview
                updateList(recipeToUpdate);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione a receita da qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNotApprove_Click(object sender, EventArgs e)
        {
            try
            {
                int selIndex = listViewRecipes.SelectedIndices[0];
                Recipes recipeToUpdate = new Recipes();
                recipeToUpdate.IdRecipe = Convert.ToInt32(dt.Rows[selIndex][0]);
                recipeToUpdate.RecipeName = dt.Rows[selIndex][1].ToString();
                recipeToUpdate.UserId = Convert.ToInt32(dt.Rows[selIndex][7]);
                recipeToUpdate.RecCategoryId = Convert.ToByte(dt.Rows[selIndex][8]);
                recipeToUpdate.RecFoodStyleId = Convert.ToByte(dt.Rows[selIndex][9]);
                recipeToUpdate.RecDifficultyLevelId = Convert.ToByte(dt.Rows[selIndex][10]);
                recipeToUpdate.RecMealCostId = Convert.ToByte(dt.Rows[selIndex][12]);
                recipeToUpdate.PreparationTime = Convert.ToByte(dt.Rows[selIndex][14]);
                recipeToUpdate.CookTime = Convert.ToByte(dt.Rows[selIndex][15]);
                recipeToUpdate.Doses = Convert.ToByte(dt.Rows[selIndex][16]);
                recipeToUpdate.Evaluation = Convert.ToDecimal(dt.Rows[selIndex][17]);
                recipeToUpdate.Description = dt.Rows[selIndex][18].ToString();
                recipeToUpdate.idStatus = 3;


                //Update list, dataTable and Listview
                updateList(recipeToUpdate);

            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Selecione a receita da qual deseja alterar estado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private async void BtnDetails_Click(object sender, EventArgs e)
        {
            //Checks if there is any row selected
            if (listViewRecipes.SelectedItems.Count > 0)
            {
                //Opens form Recipe Detail
                frmRecipeDetail formRecipeDetail = new frmRecipeDetail();
                formRecipeDetail.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formRecipeDetail.StartPosition = FormStartPosition.CenterScreen;
                formRecipeDetail.Show();


                //Transfer data to the new form
                try
                {
                    int selIndex = listViewRecipes.SelectedIndices[0];
                    formRecipeDetail.Controls["lblRecipeName"].Text = dt.Rows[selIndex][1].ToString();
                    formRecipeDetail.Controls["lblCategory"].Text = dt.Rows[selIndex][4].ToString();
                    formRecipeDetail.Controls["lblFoodStyle"].Text = dt.Rows[selIndex][5].ToString();
                    formRecipeDetail.Controls["lblDifficultyLevel"].Text = dt.Rows[selIndex][11].ToString();
                    formRecipeDetail.Controls["lblCostOfMeal"].Text = dt.Rows[selIndex][13].ToString();
                    formRecipeDetail.Controls["lblPreparationTime"].Text = convertTime(Convert.ToInt32(dt.Rows[selIndex][14].ToString()));
                    formRecipeDetail.Controls["lblCookTime"].Text = convertTime(Convert.ToInt32(dt.Rows[selIndex][15].ToString()));
                    formRecipeDetail.Controls["richTxtBoxDesciptrion"].Text = dt.Rows[selIndex][18].ToString();

                   
                    DataView dvIngList = await getRecipeIngredient(Convert.ToInt32(dt.Rows[selIndex][0]));

                    foreach (DataRow row in dvIngList.ToTable().Rows)
                    {
                        formRecipeDetail.listViewIng.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));
                    }


                }
                catch
                {
                    MessageBox.Show("Erro ao tentar ler os dados do servidor. Por favor tente novamente mais tarde.");
                }

            }
            else
            {
                MessageBox.Show("Por favor selecione a receita que pretende visualizar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public async Task<DataView> getRecipeIngredient(int idRec)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = await client.GetAsync("api/recipeingredient/?idrecipe=" + idRec.ToString());
                List<RecipeIngredientDetail> recipeIng = await response.Content.ReadAsAsync<List<RecipeIngredientDetail>>();

                DataTable dtIng = new DataTable();
                dtIng.Columns.Add("IngName");
                dtIng.Columns.Add("Quantity");
                dtIng.Columns.Add("Unit");
                DataView dvIng = new DataView();
                foreach (RecipeIngredientDetail ing in recipeIng)
                {
                    dtIng.Rows.Add(ing.IngredientName, ing.Quantity, ing.UnitName);
                }

                dvIng = new DataView(dtIng);
                               
                return dvIng;
            }
        }


        public string convertTime(int time)
        {
            if (time <= 60)
            {
                return time.ToString() + " min";
            }
            else
            {
                int hours = time / 60;
                int min = time % 60;
                if (min == 0)
                {
                    return hours.ToString() + " h";
                }
                else
                {
                    return hours.ToString() + " h " + min.ToString() + " min"; 
                }
                
            }
            
        }


        //List view formatting
        SolidBrush myGreenBrush = new SolidBrush(Color.FromArgb(255, 116, 194, 75));
        private void ListViewRecipes_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void ListViewRecipes_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if ((e.State & ListViewItemStates.Selected) != 0)
            {
                // Draw the background and focus rectangle for a selected item.
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.DrawFocusRectangle();
            }
        }

        private void ListViewRecipes_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if ((e.ItemState & ListViewItemStates.Focused) != 0)
            {
                e.Graphics.FillRectangle(myGreenBrush, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, listViewRecipes.Font, SystemBrushes.HighlightText, e.Bounds);
            }
            else
            {
                e.DrawBackground();
                e.DrawText();
            }
        }
    }
}
