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
            users = user.GetAll().Where(user => user.Name != "admin");           
            UpdateList(users);            

        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex > -1)
            {
                List<User> listusers = users.ToList();
                if (listusers is IList<User>)
                {
                    //int value = lbUsers.SelectedIndex;
                    userDelete = listusers[lbUsers.SelectedIndex];
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
                    UpdateList(usercontroller.GetAll().Where(user => user.Name != "admin"));
                }
                else
                {
                    MessageBox.Show("Error al Modificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Enabled = true;
        }

        private void UpdateList(IEnumerable<User> users)
        {
            lbUsers.Items.Clear();
            


            foreach (var item in users)
            {
                var matchingRole = roles.FirstOrDefault(role => role.Id == item.Id_Role);
                if (matchingRole != null)
                {
                    item.Role = matchingRole;
                    var result = $"{item}, Rol: {matchingRole.Name}";
                    lbUsers.Items.Add(result);
                }
            }
        }
    }
}
