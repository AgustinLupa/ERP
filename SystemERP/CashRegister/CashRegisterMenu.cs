using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemERP.View.CashRegister;

namespace SystemERP.View
{
    public partial class CashRegisterMenu : Form
    {
        public CashRegisterMenu()
        {
            InitializeComponent();
        }

        public void FirstElementFocus()
        {
            btnOpenRegister.Focus();
        }

        private void btnOpenRegister_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            CashRegisterConfirm cashRegisterConfirm = new CashRegisterConfirm();
            if(DialogResult.OK == cashRegisterConfirm.ShowDialog())
            {

            }

        }
    }
}
