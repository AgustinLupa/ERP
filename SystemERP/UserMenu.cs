using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemERP.Controller;

namespace SystemERP.View
{
    public partial class UserMenu : Form
    {
        public UserController controller;
        public UserMenu(UserController userController)
        {
            controller = userController;
            InitializeComponent();
        }

        private void txtNewNameUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            PasswordCheck passwordCheck = new PasswordCheck(controller);
            this.Enabled = false; // Deshabilita el formulario actual
            if (passwordCheck.ShowDialog() == DialogResult.OK)
            {
                if (controller.CreateUser(txtNewNameUser.Text, txtNewPassword.Text))
                {
                    MessageBox.Show("Usuario creado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Error al crear usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Enabled = true;
        }
    }
}
