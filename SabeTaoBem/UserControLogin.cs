using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SabeTaoBem
{
    public partial class UserControLogin : UserControl
    {
        public UserControLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = ConfigurationManager.AppSettings["Username"].ToString();
            string password = ConfigurationManager.AppSettings["Password"].ToString();
            
            if(username == txtUsername.Text && password == txtPassword.Text)
            {
                //Saves the user in the label ActiveUser
                FormMain.Instance.LabelUser.Text = txtUsername.Text;

                //Clear textboxes
                txtUsername.Clear();
                txtPassword.Clear();

                //Enable menu buttons
                FormMain.Instance.buttonUsers.Enabled = true;
                FormMain.Instance.buttonRecipes.Enabled = true;
                FormMain.Instance.buttonIngredients.Enabled = true;
                FormMain.Instance.buttonUnits.Enabled = true;
                FormMain.Instance.buttonComments.Enabled = true;
                FormMain.Instance.buttonUserSettings.Enabled = true;
                FormMain.Instance.pictureBoxLogo.Enabled = true;

                //Clear textboxes and creates and instance of userControlHome                
                UserControlHome home = new UserControlHome();
                FormMain.Instance.ChangeControlsInPanel(FormMain.Instance.pnlCenter, home);

            }
            else
            {
                //Alert the user: wrong password and clean the textboxes
                MessageBox.Show("Username ou password incorretos! Por favor tente de novo.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();

            }

        }

        private void UserControLogin_Load(object sender, EventArgs e)
        {
            //Set focus on txtboxUsername
            txtUsername.Focus();

            //Block menu buttons
            FormMain.Instance.buttonUsers.Enabled = false;
            FormMain.Instance.buttonRecipes.Enabled = false;
            FormMain.Instance.buttonIngredients.Enabled = false;
            FormMain.Instance.buttonUnits.Enabled = false;
            FormMain.Instance.buttonComments.Enabled = false;
            FormMain.Instance.buttonUserSettings.Enabled = false;
            FormMain.Instance.pictureBoxLogo.Enabled = false;
        }
    }
}
