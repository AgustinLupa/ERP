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
    public partial class UserMenu : Form
    {
        public UserController usercontroller;
        public RoleController roleController;
        IEnumerable<Role> roles;
        public UserMenu(UserController user, RoleController role)
        {
            usercontroller = user;
            roleController = role;
            roles = role.GetActiveRole();
            InitializeComponent();
        }


        private void rbEdit_CheckedChanged(object sender, EventArgs e)
        {
            pformCreate.Controls.Clear();
            if (rbEdit.Checked)
            {
                pformCreate.Visible = true;
                UpdateUser updateUser = new UpdateUser(usercontroller, roleController, roles);
                updateUser.TopLevel = false;
                updateUser.FormBorderStyle = FormBorderStyle.None;
                updateUser.Dock = DockStyle.Fill;

                pformCreate.Controls.Add(updateUser);
                updateUser.Show();
            }
            else if (rbCreate.Checked)
            {
                pformCreate.Visible = true;
                CreatUser creatUser = new CreatUser(usercontroller, roleController, roles);
                creatUser.TopLevel = false;
                creatUser.FormBorderStyle = FormBorderStyle.None;
                creatUser.Dock = DockStyle.Fill;

                pformCreate.Controls.Add(creatUser);
                creatUser.Show();
            }
            else if (rbDelete.Checked)
            {
                pformCreate.Visible = true;
                DeleteUser deleteUser = new DeleteUser(usercontroller, roleController, roles);
                deleteUser.TopLevel = false;
                deleteUser.FormBorderStyle = FormBorderStyle.None;
                deleteUser.Dock = DockStyle.Fill;

                pformCreate.Controls.Add(deleteUser);
                deleteUser.Show();
            }
            else if (rbCreateRole.Checked)
            {
                pformCreate.Visible = true;
                CreateRole createRole = new CreateRole(usercontroller, roleController);
                createRole.TopLevel = false;
                createRole.FormBorderStyle = FormBorderStyle.None;
                createRole.Dock = DockStyle.Fill;

                pformCreate.Controls.Add(createRole);
                createRole.Show();
            }
            else
            {
                pformCreate.Controls.Clear();
                pformCreate.Visible = false;
            }
        }

    }
}
