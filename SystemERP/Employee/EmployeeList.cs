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

namespace SystemERP.View.Employee
{
    public partial class EmployeeList : Form
    {
        EmployeeController employeeController;
        public EmployeeList(EmployeeController employee)
        {
            InitializeComponent();
            employeeController = employee;
            lbEmployee.Items.Clear();
            employeeController.SetListEmployee();
            lbEmployee.Items.AddRange(employeeController.GetListActive().ToArray());
            //foreach (var item in employeeController.GetListActive())
            //{
            //    lbEmployee.Items.Add(item);
            //}
        }

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtEmployee.Text;
            string filterType = cbFilter.Items[cbFilter.SelectedIndex].ToString();

            lbEmployee.Items.Clear();

            lbEmployee.Items.AddRange(employeeController.FilterList(filterType, filterText).ToArray());
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilter.SelectedIndex >= 0) {
                txtEmployee.Enabled = true;
            }
            else
            {
                txtEmployee.Enabled = false;
            }

        }
    }
}
