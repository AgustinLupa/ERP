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
    public partial class DeleteUser : Form
    {
        public UserController usercontroller;
        public RoleController roleController;
        IEnumerable<Role> roles;
        IEnumerable<User> users;
        User userDelete;
        public DeleteUser(UserController user, RoleController role, IEnumerable<Role> _roles)
        {
            InitializeComponent();
            usercontroller = user;
            roleController = role;
            roles = _roles;
            users = user.GetAll();
            foreach (var item in roles)
            {
                foreach (var item2 in users)
                {
                    if (item2.Id_Role == item.Id && item2.Name != "admin")
                    {
                        item2.Role = item;
                        var result = item2.ToString() + $", Rol: {item.Name}";
                        lbUsers.Items.Add(result);
                    }
                }
            }

        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex > -1)
            {
                List<User> listusers = users.ToList();
                if (users is IList<User>)
                {
                    int value = lbUsers.SelectedIndex;
                    userDelete = listusers[value++];
                }
            }
        }

        private void btnDisableUser_Click(object sender, EventArgs e)
        {
            PasswordCheck passwordCheck = new PasswordCheck(usercontroller);
            this.Enabled = false;
            if (passwordCheck.ShowDialog() == DialogResult.OK)
            {
                if (usercontroller.DeleteUser(userDelete.Id))
                {
                    MessageBox.Show("Usuario Modificado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);                    
                }
                else
                {
                    MessageBox.Show("Error al Modificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Enabled = true;
        }
    }
}
