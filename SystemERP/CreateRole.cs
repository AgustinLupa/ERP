using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SystemERP.View
{
    public partial class CreateRole : Form
    {
        PermissionsController permissionsController = new PermissionsController();
        RoleXPermissionController roleXPermission = new RoleXPermissionController();
        UserController userControl;
        RoleController roleControl;
        IEnumerable<Permissions> permissions;

        public CreateRole(UserController userController, RoleController roleController)
        {
            InitializeComponent();
            this.userControl = userController;
            this.roleControl = roleController;
            permissions = permissionsController.GetAll();
            lbPermissions.DrawMode = DrawMode.OwnerDrawVariable;
            foreach (var item in permissions)
            {
                cbPermission.Items.Add(item.ToString());
            }
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            if (cbPermission.SelectedIndex <= -1)
            {
                MessageBox.Show("No selecciono ningun permiso para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Permissions> auxpermissions = permissions.ToList();
                if (roleXPermission.AddPermissionToList(auxpermissions[cbPermission.SelectedIndex].Id, cbAdd.Checked, cbDelete.Checked, cbUpdate.Checked))
                {
                    var viewpermi = auxpermissions[cbPermission.SelectedIndex].Description + " | Agregar: " +
                        (cbAdd.Checked ? "Habilitado" : "Deshabilitado") + "| Editar: " +
                        (cbUpdate.Checked ? "Habilitado" : "Deshabilitado") + "| Eliminar: " +
                        (cbDelete.Checked ? "Habilitado" : "Deshabilitado") + "|";
                    if (auxpermissions[cbPermission.SelectedIndex].Id == 1)
                    {
                        lbPermissions.Items.Clear();
                        lbPermissions.Items.Add(new ListViewItem(viewpermi, "defaultImage"));

                    }
                    else
                        lbPermissions.Items.Add(new ListViewItem(viewpermi, "defaultImage"));
                    cbAdd.Checked = false; cbDelete.Checked = false; cbUpdate.Checked = false;
                }
                else
                {
                    if (roleXPermission.ContainIdAdmin())
                        MessageBox.Show("No se puede agregar mas permisos si selecciona el admin", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Ya se encuentra agregado ese elemento a la lista", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            PasswordCheck passwordCheck = new PasswordCheck(userControl);
            this.Enabled = false;
            if (passwordCheck.ShowDialog() == DialogResult.OK)
            {
                if (lbPermissions.Items.Count > 0)
                {
                    int result = roleControl.CreateRole(txtRoleName.Text);
                    if (result > 0)
                    {
                        roleXPermission.SetRoleInList(result);
                        roleXPermission.CreateForList();
                        MessageBox.Show("Rol Creado correctamente", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        lbPermissions.Items.Clear();
                        roleXPermission.ClearList();
                        txtRoleName.Text = string.Empty;
                        cbPermission.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Error al Crear el Rol, verifique si existe el rol\nVerifique si ingreso un nombre para el Rol\nVerifique si le Asigno al menos un permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No selecciono almenos un permiso para el rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Enabled = true;
        }

        private void lbPermissions_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            e.DrawBackground();

            ListViewItem item = lbPermissions.Items[e.Index] as ListViewItem;

            if (item != null)
            {
                Image image = Image.FromFile("E:\\proyectos algortimos 3\\SystemERP\\SystemERP\\Resources\\Delete-x.png");
                e.Graphics.DrawImage(image, e.Bounds.Left, e.Bounds.Top);

                e.Graphics.DrawString(item.Text, e.Font, Brushes.Black, e.Bounds.Left + image.Width, e.Bounds.Top);

            }            

            e.DrawFocusRectangle();
        }

        private void lbPermissions_MouseClick(object sender, MouseEventArgs e)
        {
            int imageWidth = Image.FromFile("E:\\proyectos algortimos 3\\SystemERP\\SystemERP\\Resources\\Delete-x.png").Width;

            if (e.X <= imageWidth)
            {
                if (lbPermissions.SelectedIndex >= 0)
                {
                    roleXPermission.RemovePermissionToListById(lbPermissions.SelectedIndex);
                    lbPermissions.Items.RemoveAt(lbPermissions.SelectedIndex);
                }
            }
        }

        private void cbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Permissions> auxpermissions = permissions.ToList();
            if (cbPermission.SelectedIndex == -1)
            {
                cbAdd.Checked = false; cbAdd.Enabled = true;
                cbDelete.Checked = false; cbDelete.Enabled = true;
                cbUpdate.Checked = false; cbUpdate.Enabled = true;
            }
            else if (auxpermissions[cbPermission.SelectedIndex].Id == 1)
            {
                cbAdd.Checked = true; cbAdd.Enabled = false;
                cbDelete.Checked = true; cbDelete.Enabled = false;
                cbUpdate.Checked = true; cbUpdate.Enabled = false;
            }
            else
            {
                cbAdd.Checked = false; cbAdd.Enabled = true;
                cbDelete.Checked = false; cbDelete.Enabled = true;
                cbUpdate.Checked = false; cbUpdate.Enabled = true;
            }
        }


    }
}
