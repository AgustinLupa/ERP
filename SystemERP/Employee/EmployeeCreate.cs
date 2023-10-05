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
            controller.SetListEmployee(controller.GetAll());
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var result = controller.CreateEmployee(txtName.Text, txtLastName.Text, Convert.ToInt32(mtbDni.Text), Convert.ToInt32(numCodEmplo.Value));
            if (result > 0)
            {
                controller.SetListEmployee(controller.GetAll());
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

        private void mtbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (mtbDni.Text.Length > 0)
            {
                if (int.TryParse(mtbDni.Text, out int valor))
                {
                    if (valor > 1000000)
                    {
                        if (controller.FilterList("DNI", mtbDni.Text).Count() == 0)
                        {
                            pbDni.Visible = true;
                            lDni.Visible = true;
                            lDni.Text = "disponible";
                            pbDni.BackgroundImage = null;
                            pbDni.BackgroundImage = Properties.Resources.ok;
                        }
                        else
                        {
                            pbDni.Visible = true;
                            lDni.Visible = true;
                            lDni.Text = "No disponible";
                            pbDni.BackgroundImage = null;
                            pbDni.BackgroundImage = Properties.Resources.Danger;
                        }
                    }
                    else
                    {
                        pbDni.Visible = true;
                        lDni.Visible = true;
                        lDni.Text = "No disponible";
                        pbDni.BackgroundImage = null;
                        pbDni.BackgroundImage = Properties.Resources.Danger;
                    }
                }
                else
                {
                    pbDni.Visible = true;
                    lDni.Visible = true;
                    lDni.Text = "No disponible";
                    pbDni.BackgroundImage = null;
                    pbDni.BackgroundImage = Properties.Resources.Danger;
                }
            }
            else
            {
                pbDni.Visible = true;
                lDni.Visible = true;
                lDni.Text = "No disponible";
                pbDni.BackgroundImage = null;
                pbDni.BackgroundImage = Properties.Resources.Danger;
            }
        }
    }
}
