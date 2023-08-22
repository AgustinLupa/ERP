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
using SystemERP.Model;

namespace SystemERP.View
{
    public partial class Menu : Form
    {
        public UserController userControl;
        public RoleController roleController;
        PermissionsController permissionsController;

        public Menu(UserController user)
        {
            userControl = user;
            InitializeComponent();
            roleController = new RoleController();
            userControl.SetRoleActive(roleController.GetByID(userControl.GetUserActive().Id_Role));
            User userActive = userControl.GetUserActive();


            if (userActive.Role.Name == "admin")
            {
                btnTurnOver.Visible = true;
            }

        }

        private void Menu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                DialogResult result = MessageBox.Show("¿Desea volver al Login?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Owner.Show();
                    this.Close();
                }
            }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario hijo
            UserMenu userMenu = new UserMenu(userControl, roleController);

            // Asignar el formulario hijo como hijo del panel
            userMenu.TopLevel = false;
            pMenu.Controls.Clear(); // Limpiar el panel antes de agregar el nuevo formulario
            pMenu.Controls.Add(userMenu);
            userMenu.Dock = DockStyle.Fill;
            userMenu.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea volver al Login?", "Cerrar sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Owner.Show();
                this.Close();
            }
        }
    }
}
