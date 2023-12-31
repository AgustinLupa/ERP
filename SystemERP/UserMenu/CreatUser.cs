﻿using System;
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
    public partial class CreatUser : Form
    {
        public UserController usercontroller;
        public RoleController roleController;
        IEnumerable<Role> roles;

        public CreatUser(UserController user, RoleController role, IEnumerable<Role> _roles)
        {
            InitializeComponent();
            usercontroller = user;
            roleController = role;
            roles = _roles;
            foreach (var item in roles)
            {
                cbRole.Items.Add(item.Name);
            }

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            PasswordCheck passwordCheck = new PasswordCheck(usercontroller);
            this.Enabled = false;
            if (passwordCheck.ShowDialog() == DialogResult.OK)
            {
                Role role = new Role();
                foreach (var item in roles)
                {
                    if (item.Name == cbRole.SelectedText)
                    {
                        role = item;
                    }
                }
                if (usercontroller.CreateUser(txtNewNameUser.Text, txtNewPassword.Text, role.Id))
                {
                    MessageBox.Show("Usuario creado correctamente", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNewNameUser.Text = "";
                    txtNewPassword.Text = "";
                    cbRole.SelectedIndex = 0;
                    lvDescrip.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Error al crear usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Enabled = true;
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
    }
}
