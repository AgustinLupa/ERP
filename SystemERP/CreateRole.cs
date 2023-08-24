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
using SystemERP.View.ModelView;

namespace SystemERP.View
{
    public partial class CreateRole : Form
    {
        PermissionsController permissionsController = new PermissionsController();
        UserController userControl;
        RoleController roleControl;
        BindingList<PermissionsView> permissionsView = new BindingList<PermissionsView>();
        IEnumerable<Permissions> permissions;

        public CreateRole(UserController userController, RoleController roleController)
        {
            InitializeComponent();
            this.userControl = userController;
            this.roleControl = roleController;
            permissions = permissionsController.GetAll();

            foreach (var item in permissions)
            {
                var auxelemnt = new PermissionsView() { Description = item.Description };

                cbPermission.Items.Add(auxelemnt);
            }
            //UpdateList();
        }

        private void dgvPermission_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DeleteColum.Index && e.RowIndex >= 0)
            {
                permissionsView.RemoveAt(e.RowIndex);
            }
        }

        private void UpdateList()
        {
            dgvPermission.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvPermission.DataSource = null;
            dgvPermission.DataSource = permissionsView;
            dgvPermission.Columns["Description"].Width = 440;
            dgvPermission.Columns["Description"].ReadOnly = true;
            dgvPermission.AllowUserToResizeRows = false;
            dgvPermission.AllowUserToResizeColumns = false;
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
                var viewpermi = new PermissionsView() { Description = auxpermissions[cbPermission.SelectedIndex].Description };
                permissionsView.Add(viewpermi);
                UpdateList();
            }
        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            PasswordCheck passwordCheck = new PasswordCheck(userControl);
            this.Enabled = false;
            if (passwordCheck.ShowDialog() == DialogResult.OK)
            {
                if (roleControl.CreateRole(txtRoleName.Text)>0 && permissionsView.Count() != 0 )
                {
                    MessageBox.Show("Rol Creado correctamente", "Roles", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    permissionsView.Clear();
                    UpdateList();
                }
                else
                {
                    MessageBox.Show("Error al Crear el Rol, verifique si existe el rol o no ingreso ningun nombre para el Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Enabled = true;
        }
    }
}
