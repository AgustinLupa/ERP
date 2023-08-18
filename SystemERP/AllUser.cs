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
    public partial class AllUser : Form
    {
        UserController userController;
        RoleController roleController;
        public AllUser(UserController user, RoleController role, IEnumerable<Role> roles)
        {
            InitializeComponent();
            userController = user;
            roleController = role;
            foreach (var item in userController.GetAll())
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
