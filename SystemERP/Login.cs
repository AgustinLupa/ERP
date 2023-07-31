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
                Menu menu = new Menu();
                menu.Owner = this;
                this.Hide();
                menu.ShowDialog();
            }
        }
       

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtPass.Focus();
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}