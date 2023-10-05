namespace SystemERP.View.Employee
{
    partial class EmployeeDelete
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
            btnDelete = new Button();
            label2 = new Label();
            cbFilter = new ComboBox();
            lbEmployee = new ListBox();
            txtEmployee = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbFilter);
            panel1.Controls.Add(lbEmployee);
            panel1.Controls.Add(txtEmployee);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 512);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(365, 441);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 59);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Eliminar Empleado";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 17);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 9;
            label2.Text = "Forma de busqueda";
            // 
            // cbFilter
            // 
            cbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "DNI", "NOMBRE", "APELLIDO" });
            cbFilter.Location = new Point(202, 14);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(175, 29);
            cbFilter.TabIndex = 8;
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // lbEmployee
            // 
            lbEmployee.FormattingEnabled = true;
            lbEmployee.ItemHeight = 15;
            lbEmployee.Location = new Point(30, 131);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(489, 274);
            lbEmployee.TabIndex = 7;
            // 
            // txtEmployee
            // 
            txtEmployee.Enabled = false;
            txtEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmployee.Location = new Point(201, 69);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(318, 29);
            txtEmployee.TabIndex = 6;
            txtEmployee.TextChanged += txtEmployee_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 72);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 5;
            label1.Text = "Empleado a Buscar";
            // 
            // EmployeeDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeDelete";
            Text = "EmployeeDelete";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDelete;
        private Label label2;
        private ComboBox cbFilter;
        private ListBox lbEmployee;
        private TextBox txtEmployee;
        private Label label1;
    }
}