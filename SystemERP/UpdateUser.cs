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
    public partial class UpdateUser : Form
    {
        public UserController usercontroller;
        public RoleController roleController;
        IEnumerable<Role> roles;
        public UpdateUser(UserController user, RoleController role, IEnumerable<Role> _roles)
        {
            InitializeComponent();
            usercontroller = user;
            roleController = role;
            roles = _roles;
            var users = usercontroller.GetAll();
            foreach (var item in roles)
            {
                foreach (var item2 in users)
                {
                    if (item2.Id_Role == item.Id)
                    {
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
    }
}
