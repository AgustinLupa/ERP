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
using SystemERP.Interface;

namespace SystemERP.View
{
    public partial class Menu : Form
    {
        public UserController userControl;
        public Menu(UserController user)
        {
            userControl = user;
            InitializeComponent();
            IUser userActive = userControl.GetUserActive();
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
    }
}
