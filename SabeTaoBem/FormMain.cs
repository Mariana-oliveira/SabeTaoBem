using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SabeTaoBem
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Fields
        static FormMain _obj;

        //Property to get FormMain
        public static FormMain Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new FormMain();
                }
                return _obj;
            }
        }

        //Properties Definitons
        public Panel pnlCenter
        {
            get { return panelCenter; }
            set { panelCenter = value; }
        }
        public Label LabelUser
        {
            get { return lblActiveUser; }
            set { lblActiveUser = value; }
        }
        public Button buttonUsers
        {
            get { return btnUsers; }
            set { btnUsers = value; }
        }
        public Button buttonRecipes
        {
            get { return btnRecipes; }
            set { btnRecipes = value; }
        }
        public Button buttonIngredients
        {
            get { return btnIngredients; }
            set { btnIngredients = value; }
        }
        public Button buttonUnits
        {
            get { return btnUnits; }
            set { btnUnits = value; }
        }
        public Button buttonComments
        {
            get { return btnComments; }
            set { btnComments = value; }
        }
        public Button buttonUserSettings
        {
            get { return btnUserSettings; }
            set { btnUserSettings = value; }
        }
        public PictureBox pictureBoxLogo
        {
            get { return pictureLogo; }
            set { pictureLogo = value; }
        }



        // -----------------------------------------------------------------------------------
        // Form Events
        private void FormMain_Load(object sender, EventArgs e)
        {

            //Set _obj to this form
            _obj = this;

            //Changing some formating properties
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            lblActiveUser.Left = lblActiveUser.Parent.Width - 175;
            btnUserSettings.Left = btnUserSettings.Parent.Width - 75;

            //Initialize userControlLogin
            UserControLogin userControlLogin = new UserControLogin();
            ChangeControlsInPanel(panelCenter, userControlLogin);

        }

        /// <summary>
        /// Method that changes the userControl in a panel
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="newControl"></param>
        public void ChangeControlsInPanel(Control panel, Control newControl)
        {
            
            panel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            newControl.BringToFront();
            panel.Controls.Add(newControl);
        }

        //Buttons Events
        private void BtnUserSettings_Click(object sender, EventArgs e)
        {
            //Show or hide userSettings Menu
            if (panelRight.Visible == false)
            {
                panelCenter.Controls.Add(panelRight);
                panelRight.Visible = true;
                panelRight.BringToFront();
            }
            else
            {
                panelRight.Visible = false;
            }
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            //Opens the userControl User
            UserControlUsers usercontrolUsers = new UserControlUsers();
            ChangeControlsInPanel(panelCenter, usercontrolUsers);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void BtnRecipes_Click(object sender, EventArgs e)
        {
            //Opens the userControl Recipes
            UserControlRecipes usercontrolRecipes = new UserControlRecipes();
            ChangeControlsInPanel(panelCenter, usercontrolRecipes);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void BtnIngredients_Click(object sender, EventArgs e)
        {
            //Opens the userControl Ingredients
            UserControlIngredients usercontrolIngredients = new UserControlIngredients();
            ChangeControlsInPanel(panelCenter, usercontrolIngredients);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void BtnUnits_Click(object sender, EventArgs e)
        {
            //Opens the userControl Units
            UserControlUnits usercontrolUnits = new UserControlUnits();
            ChangeControlsInPanel(panelCenter, usercontrolUnits);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void BtnComments_Click(object sender, EventArgs e)
        {
            //Opens the userControl Comments
            UserControlComments userControlComments = new UserControlComments();
            ChangeControlsInPanel(panelCenter, userControlComments);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            //Opens the userControl Login
            UserControLogin userControlLogin = new UserControLogin();
            ChangeControlsInPanel(panelCenter, userControlLogin);

            //Clear activeUser Label
            lblActiveUser.Text = "";

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //Hide userSettingsMenu
            panelRight.Visible = false;

            //Closes the application
            this.Close();
        }

        private void PictureLogo_Click(object sender, EventArgs e)
        {
            //Opens the userControl Home
            UserControlHome home = new UserControlHome();
            ChangeControlsInPanel(pnlCenter, home);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Confirm exit application
            DialogResult result = MessageBox.Show("Tem a certeza que deseja sair?", "Fechar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Cancel closing app
            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            //Opens the userControl myAccount
            UserControlMyAccount myAccount = new UserControlMyAccount();
            ChangeControlsInPanel(panelCenter, myAccount);

            //Hide userSettingsMenu
            panelRight.Visible = false;
        }
    }
}
