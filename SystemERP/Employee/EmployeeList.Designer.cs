namespace SystemERP.View.Employee
{
    partial class EmployeeList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pform = new Panel();
            label2 = new Label();
            cbFilter = new ComboBox();
            lbEmployee = new ListBox();
            txtEmployee = new TextBox();
            label1 = new Label();
            pform.SuspendLayout();
            SuspendLayout();
            // 
            // pform
            // 
            pform.BackColor = SystemColors.GradientActiveCaption;
            pform.Controls.Add(label2);
            pform.Controls.Add(cbFilter);
            pform.Controls.Add(lbEmployee);
            pform.Controls.Add(txtEmployee);
            pform.Controls.Add(label1);
            pform.Dock = DockStyle.Fill;
            pform.Location = new Point(0, 0);
            pform.Name = "pform";
            pform.Size = new Size(546, 512);
            pform.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 13);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 4;
            label2.Text = "Forma de busqueda";
            // 
            // cbFilter
            // 
            cbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "DNI", "NOMBRE", "APELLIDO" });
            cbFilter.Location = new Point(202, 10);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(175, 29);
            cbFilter.TabIndex = 3;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lbEmployee
            // 
            lbEmployee.FormattingEnabled = true;
            lbEmployee.ItemHeight = 15;
            lbEmployee.Location = new Point(38, 127);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(481, 349);
            lbEmployee.TabIndex = 2;
            // 
            // txtEmployee
            // 
            txtEmployee.Enabled = false;
            txtEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmployee.Location = new Point(201, 65);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(318, 29);
            txtEmployee.TabIndex = 1;
            txtEmployee.TextChanged += txtEmployee_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 68);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 0;
            label1.Text = "Empleado a Buscar";
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 512);
            Controls.Add(pform);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeList";
            Text = "EmployeeList";
            pform.ResumeLayout(false);
            pform.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pform;
        private Label label2;
        private ComboBox cbFilter;
        private ListBox lbEmployee;
        private TextBox txtEmployee;
        private Label label1;
    }
}