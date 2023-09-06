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
        List<User> users;
        User userUpdate;
        List<User> userView;
        public UpdateUser(UserController user, RoleController role, IEnumerable<Role> _roles)
        {
            InitializeComponent();
            usercontroller = user;
            roleController = role;
            roles = _roles;
            users = usercontroller.GetAll().ToList();
            userView = new List<User>();
            BuildList(users);
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
                        userUpdate.Role = item;
                    }
                }
            }
        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex > -1)
            {
                if (users is IList<User>)
                {
                    userUpdate = userView[lbUsers.SelectedIndex];

                    txtNewNameUser.Text = userUpdate.Name;


                    if (userUpdate.State == 1)
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
                if (cbChangePass.Checked)
                {

                    if (usercontroller.UpdateUser(userUpdate.Id, txtNewNameUser.Text, txtNewPassword.Text, userUpdate.Role.Id, rbEnable.Checked, cbChangePass.Checked))
                    {
                        MessageBox.Show("Usuario Modificado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (usercontroller.UpdateUser(userUpdate.Id, txtNewNameUser.Text, userUpdate.Password, userUpdate.Role.Id, rbEnable.Checked, cbChangePass.Checked))
                    {
                        MessageBox.Show("Usuario Modificado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                txtNewNameUser.Text = "";
                txtNewPassword.Text = "";
                cbRole.SelectedIndex = 0;
                lvDescrip.Items.Clear();
                rbDisable.Checked = false;
                rbEnable.Checked = false;
                lvDescrip.Visible = false;
                BuildList(usercontroller.GetAll().ToList());

            }
            this.Enabled = true;
        }

        private void BuildList(List<User> users)
        {
            lbUsers.Items.Clear();
            if (cbRole.Items.Count == 0)
            {
                foreach (var item in roles)
                {
                    foreach (var item2 in users)
                    {
                        if (item2.Id_Role == item.Id)
                        {
                            item2.Role = item;
                            var result = item2.ToString() + $", Rol: {item.Name}";
                            lbUsers.Items.Add(result);
                            userView.Add(item2);
                        }
                    }
                    cbRole.Items.Add(item.Name);
                }

            }
            else
            {
                lbUsers.Items.Clear();
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
                }
            }

        }

        private void cbChangePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChangePass.Checked)
            {
                txtNewPassword.Enabled = true;
            }
            else
            {
                txtNewPassword.Enabled = false;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text;
            FilterListBox(filterText);
        }

        private void FilterListBox(string filterText)
        {
            lbUsers.Items.Clear();

            var filteredUsers = users
                .Where(user => user.Name.IndexOf(filterText, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(user => $"{user}, Rol: {user.Role.Name}");

            lbUsers.Items.AddRange(filteredUsers.ToArray());
        }
    }
}
