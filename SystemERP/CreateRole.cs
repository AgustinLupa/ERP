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
    public partial class CreateRole : Form
    {
        PermissionsController permissionsController = new PermissionsController();
        UserController userControl;
        RoleController roleControl;

        public CreateRole(UserController userController, RoleController roleController)
        {
            InitializeComponent();
            this.userControl = userController;
            this.roleControl = roleController;
            var element = permissionsController.GetAll();
            List<Permissions> permissions = new List<Permissions>();
            foreach (var item in element)
            {
                var auxelemnt = new Permissions(){ Description = item.Description};
                permissions.Add(auxelemnt);
            }
            dgvPermission.DataSource = null;
            dgvPermission.DataSource = permissions;
        }


    }
}
