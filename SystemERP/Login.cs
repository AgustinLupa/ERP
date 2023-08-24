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
            else
            {
                MessageBox.Show("Error de inicio de sesion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {               
                e.SuppressKeyPress = true;
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }
    }
}