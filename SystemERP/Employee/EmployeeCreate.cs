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
    public partial class EmployeeCreate : Form
    {
        EmployeeController controller;
        public EmployeeCreate(EmployeeController employeeController)
        {
            InitializeComponent();
            controller = employeeController;
            controller.SetListEmployee();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var result = controller.CreateEmployee(txtName.Text, txtLastName.Text, Convert.ToInt32(mtbDni.Text), Convert.ToInt32(numCodEmplo.Value));
            if (result > 0)
            {
                controller.SetListEmployee();
                MessageBox.Show("Empleado Creado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("No se pudo crear el empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numCodEmplo_ValueChanged(object sender, EventArgs e)
        {
            if (controller.EmployeeActiveByCode(Convert.ToInt32(numCodEmplo.Value)))
            {
                pbVerifyCod.Visible = true;
                lResult.Visible = true;
                lResult.Text = "No disponible";
                pbVerifyCod.BackgroundImage = null;
                pbVerifyCod.BackgroundImage = Properties.Resources.Danger;
            }
            else
            {
                pbVerifyCod.Visible = true;
                lResult.Visible = true;
                lResult.Text = "Disponible";
                pbVerifyCod.BackgroundImage = null;
                pbVerifyCod.BackgroundImage = Properties.Resources.ok;
            }
        }
    }
}
