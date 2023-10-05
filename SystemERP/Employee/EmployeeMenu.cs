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

namespace SystemERP.View.Employee
{
    public partial class EmployeeMenu : Form
    {
        EmployeeController controller = new EmployeeController();
        public EmployeeMenu()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeList employeeList = new EmployeeList(controller);
            pMenu.Controls.Clear();
            employeeList.TopLevel = false;
            employeeList.FormBorderStyle = FormBorderStyle.None;
            employeeList.Dock = DockStyle.Fill;
            pMenu.Controls.Add(employeeList);
            employeeList.Show();
        }

        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            pMenu.Controls.Clear();
            EmployeeCreate employeeCreate = new EmployeeCreate(controller);
            employeeCreate.TopLevel = false;
            employeeCreate.FormBorderStyle = FormBorderStyle.None;
            employeeCreate.Dock = DockStyle.Fill;
            pMenu.Controls.Add(employeeCreate);
            employeeCreate.Show();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            pMenu.Controls.Clear();
            EmployeeDelete employeeCreate = new EmployeeDelete(controller);
            employeeCreate.TopLevel = false;
            employeeCreate.FormBorderStyle = FormBorderStyle.None;
            employeeCreate.Dock = DockStyle.Fill;
            pMenu.Controls.Add(employeeCreate);
            employeeCreate.Show();
        }
    }
}
