using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemERP.Controller;
using SystemERP.Model;

namespace SystemERP.View
{
    public partial class UpdateUser : Form
    {
        public UserController usercontroller;
        public RoleController roleController;
        IEnumerable<Role> roles;
        IEnumerable<User> users;
        User userUpdate;
        public UpdateUser(UserController user, RoleController role, IEnumerable<Role> _roles)
        {
            InitializeComponent();
            usercontroller = user;
            roleController = role;
            roles = _roles;
            users = usercontroller.GetAll();
            foreach (var item in roles)
            {
                foreach (var item2 in users)
                {
                    if (item2.Id_Role == item.Id)
                    {
                        item2.Role = item;
                        var result = item2.ToString() + $", Rol: {item.Name}";
                        lbUsers.Items.Add(result);                        
                    }
                }
                cbRole.Items.Add(item.Name);
            }
        }        

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRole.SelectedIndex > -1)
            {
                lvDescrip.Visible = true;
                lvDescrip.Items.Clear();
                string Description = $"";
                foreach (var item in roles)
                {
                    if (cbRole.Text == item.Name)
                    {
                        foreach (var item2 in item.RolePermissions)
                        {
                            Description += $" Descripcion: {item2.Permission.Description} \n ";
                            if (item2.Add == 1)
                            {
                                Description += $"Agregar: Habilitado, ";
                            }
                            else
                            {
                                Description += $"Agregar: Desabilitado, ";
                            }
                            if (item2.Remove == 1)
                            {
                                Description += $"Eliminar: Habilitado, ";
                            }
                            else
                            {
                                Description += $"Eliminar: Desabilitado, ";
                            }
                            if (item2.Edit == 1)
                            {
                                Description += $"Modificar: Habilitado ";
                            }
                            else
                            {
                                Description += $"Modificar: Desabilitado ";
                            }
                            lvDescrip.Items.Add(Description);
                        }
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
                    userUpdate = listusers[lbUsers.SelectedIndex];
                    txtNewNameUser.Text = userUpdate.Name;
                    if(userUpdate.State == 1)
                    {
                        rbEnable.Checked = true;
                        rbDisable.Checked = false;
                    }
                    else
                    {
                        rbEnable.Checked = false;
                        rbDisable.Checked = true;
                    }
                    int roleIndex = cbRole.FindStringExact(userUpdate.Role.Name);
                    if (userUpdate.Name == "admin")
                    {
                        txtNewNameUser.Enabled = false;
                        cbRole.Enabled = false;
                        rbDisable.Enabled = false;
                        rbEnable.Enabled = false;
                    }
                    else
                    {
                        txtNewNameUser.Enabled = true;
                        cbRole.Enabled = true;
                        rbDisable.Enabled = true;
                        rbEnable.Enabled = true;
                    }
                    if (roleIndex != -1)
                    {
                        cbRole.SelectedIndex = roleIndex;
                    }
                    cbRole.Focus();
                    txtNewNameUser.Focus();
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            PasswordCheck passwordCheck = new PasswordCheck(usercontroller);
            this.Enabled = false;
            if (passwordCheck.ShowDialog() == DialogResult.OK)
            {
                if (usercontroller.UpdateUser(userUpdate.Id,txtNewNameUser.Text, txtNewPassword.Text, userUpdate.Role.Id, rbEnable.Checked))
                {
                    MessageBox.Show("Usuario Modificado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNewNameUser.Text = "";
                    txtNewPassword.Text = "";
                    cbRole.SelectedIndex = 0;
                    lvDescrip.Items.Clear();
                    rbDisable.Checked = false;
                    rbEnable.Checked = false;
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
