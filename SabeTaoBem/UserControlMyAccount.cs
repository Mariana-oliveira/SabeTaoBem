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

namespace SabeTaoBem
{
    public partial class UserControlMyAccount : UserControl
    {
        ////New instance of users
        //Users currentAccount;

        //public UserControlMyAccount()
        //{
        //    InitializeComponent();

        //    //Create the current user data
        //    currentAccount = new Users("Mariana", "Oliveira", "admin", "mariana_oliveira@gmail.com", DateTime.Now, "Aprovada");
        //    currentAccount.Password = "admin1234";

        //    //Disable some fields
        //    txtUsername.Enabled = false;
        //    txtPassword.Enabled = false;

        //}

        //private void UserControlMyAccount_Load(object sender, EventArgs e)
        //{
        //    txtName.Text = currentAccount.Name;
        //    txtSurname.Text = currentAccount.Surname;
        //    txtUsername.Text = currentAccount.Username;
        //    txtEmail.Text = currentAccount.Email;
        //    txtPassword.Text = currentAccount.Password;

        //}

        //private void BtnSave_Click(object sender, EventArgs e)
        //{
        //    if (txtName.Text != String.Empty && txtSurname.Text != String.Empty && txtEmail.Text != String.Empty)
        //    {
        //        currentAccount.Name = txtName.Text;
        //        currentAccount.Surname = txtSurname.Text;
        //        currentAccount.Email = txtEmail.Text;

        //        MessageBox.Show("Dados guardados com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Por favor preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
