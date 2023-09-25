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
            panel1 = new Panel();
            label2 = new Label();
            cbFilter = new ComboBox();
            lbEmployee = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbFilter);
            panel1.Controls.Add(lbEmployee);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 512);
            panel1.TabIndex = 0;
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(201, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 29);
            textBox1.TabIndex = 1;
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
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeList";
            Text = "EmployeeList";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private ComboBox cbFilter;
        private ListBox lbEmployee;
        private TextBox textBox1;
        private Label label1;
    }
}