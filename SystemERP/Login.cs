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


        //private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        txtPass.Focus();
        //        e.Handled = true;
        //    }
        //    if (e.KeyChar == 27)
        //    {
        //        DialogResult result = MessageBox.Show("¿Desea Salir?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //}

        //private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        btnLogin_Click(sender, e);
        //        e.Handled = true;
        //    }
        //    if (e.KeyChar == 27)
        //    {
        //        DialogResult result = MessageBox.Show("¿Desea Salir?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //        if (result == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //}

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult result = MessageBox.Show("¿Desea Salir?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtPass.Focus();
                e.Handled = true;
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}