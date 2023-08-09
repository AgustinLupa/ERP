using Microsoft.Extensions.Configuration;
using SystemERP.Controller;
using SystemERP.View;

namespace SystemERP
{
    public partial class FLogin : Form
    {
        UserController userController = new UserController();
        public FLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool result = userController.Login(txtUser.Text, txtPass.Text);
            if (result)
            {
                txtUser.Text = "";
                txtPass.Text = "";
                Menu menu = new Menu(userController);
                menu.Owner = this;
                this.Hide();
                menu.ShowDialog();
            }
        }
       
        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                txtPass.Focus();

            }
        }
        
    }
}