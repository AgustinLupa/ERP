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
    public partial class EmployeeDelete : Form
    {
        EmployeeController employeeController;
        IEnumerable<Model.Employee> employees;
        public EmployeeDelete(EmployeeController employeeController)
        {
            InitializeComponent();
            this.employeeController = employeeController;
            lbEmployee.Items.Clear();
            this.employeeController.SetListEmployee(this.employeeController.GetAll());
            RestartList();
        }

        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtEmployee.Text;
            string filterType = cbFilter.Items[cbFilter.SelectedIndex].ToString();

            lbEmployee.Items.Clear();

            employees = employeeController.FilterList(filterType, filterText);
            lbEmployee.Items.AddRange(employees.ToArray());
        }


        private void RestartList()
        {
            lbEmployee.Items.Clear();
            lbEmployee.Items.AddRange(employeeController.GetActive().ToArray());
            employees = employeeController.GetActive();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var emplo = employees.ToArray()[lbEmployee.SelectedIndex];
            if (employeeController.DeleteEmployee(emplo))
            {
                MessageBox.Show("Se elimino correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                RestartList();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex >= 0)
            {
                txtEmployee.Enabled = true;
            }
            else
            {
                txtEmployee.Enabled = false;
            }
        }
    }
}
