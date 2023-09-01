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
    public partial class UpdateRole : Form
    {
        PermissionsController permissionsController;
        RoleXPermissionController roleXPermission;
        UserController userControl;
        RoleController roleControl;
        public UpdateRole(UserController userController, RoleController roleController, PermissionsController permissionsController, RoleXPermissionController roleXPermissionController)
        {
            InitializeComponent();
            this.permissionsController = permissionsController;
            this.roleXPermission = roleXPermissionController;
            this.userControl = userController;
            this.roleControl = roleController;
            roleControl.SetRoles();
            this.permissionsController.SetList();
            this.permissionsController.ClearListAux();
            var roles = this.roleControl.GetRoles();
            foreach (var item in roles)
            {
                lbRole.Items.Add(item.Name);
            }
            foreach (var item in this.permissionsController.GetList())
            {
                cbPermission.Items.Add(item.ToString());
            }
        }

        private void lbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPermissions.Items.Clear();
            if (lbRole.SelectedIndex != -1)
            {
                var role = roleControl.SelectRole(lbRole.SelectedIndex);

                txtRoleName.Text = role.Name;
                permissionsController.ClearListAux();
                foreach (var item in role.RolePermissions)
                {                    
                    permissionsController.AddPermissionToList(item.Permission);
                    var viewpermi = item.Permission.Description + " | Agregar: " +
                        (item.Add == 1 ? "Habilitado" : "Deshabilitado") + "| Editar: " +
                        (item.Edit == 1 ? "Habilitado" : "Deshabilitado") + "| Eliminar: " +
                        (item.Remove == 1 ? "Habilitado" : "Deshabilitado") + "|";
                    lbPermissions.Items.Add(new ListViewItem(viewpermi, "defaultImage"));
                    cbAdd.Checked = false; cbDelete.Checked = false; cbUpdate.Checked = false;
                }
            }
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
                    DialogResult result = MessageBox.Show("¿Desea Eliminar el permiso seleccionado?", "Eliminar permiso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        permissionsController.RemoveToListById(lbPermissions.SelectedIndex);
                        lbPermissions.Items.RemoveAt(lbPermissions.SelectedIndex);
                    }
                }
            }
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            if (cbPermission.SelectedIndex <= -1)
            {
                MessageBox.Show("No selecciono algun permiso para agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Permissions> auxpermissions = permissionsController.GetList();
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
    }
}
