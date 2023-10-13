namespace SystemERP.View.Employee
{
    partial class EmployeeUpdate
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
            lDni = new Label();
            pbDni = new PictureBox();
            lResult = new Label();
            pbVerifyCod = new PictureBox();
            mtbDni = new MaskedTextBox();
            numCodEmplo = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtLastName = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            cbFilter = new ComboBox();
            lbEmployee = new ListBox();
            txtEmployee = new TextBox();
            label6 = new Label();
            btnCreate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVerifyCod).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCodEmplo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(btnCreate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbFilter);
            panel1.Controls.Add(lbEmployee);
            panel1.Controls.Add(txtEmployee);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lDni);
            panel1.Controls.Add(pbDni);
            panel1.Controls.Add(lResult);
            panel1.Controls.Add(pbVerifyCod);
            panel1.Controls.Add(mtbDni);
            panel1.Controls.Add(numCodEmplo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(txtName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 512);
            panel1.TabIndex = 0;
            // 
            // lDni
            // 
            lDni.AutoSize = true;
            lDni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lDni.Location = new Point(347, 325);
            lDni.Name = "lDni";
            lDni.Size = new Size(43, 17);
            lDni.TabIndex = 26;
            lDni.Text = "label5";
            lDni.Visible = false;
            // 
            // pbDni
            // 
            pbDni.BackgroundImage = Properties.Resources.ok;
            pbDni.BackgroundImageLayout = ImageLayout.Stretch;
            pbDni.Location = new Point(294, 321);
            pbDni.Name = "pbDni";
            pbDni.Size = new Size(32, 29);
            pbDni.TabIndex = 25;
            pbDni.TabStop = false;
            pbDni.Visible = false;
            // 
            // lResult
            // 
            lResult.AutoSize = true;
            lResult.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lResult.Location = new Point(396, 373);
            lResult.Name = "lResult";
            lResult.Size = new Size(43, 17);
            lResult.TabIndex = 24;
            lResult.Text = "label5";
            lResult.Visible = false;
            // 
            // pbVerifyCod
            // 
            pbVerifyCod.BackgroundImage = Properties.Resources.ok;
            pbVerifyCod.BackgroundImageLayout = ImageLayout.Stretch;
            pbVerifyCod.Location = new Point(343, 369);
            pbVerifyCod.Name = "pbVerifyCod";
            pbVerifyCod.Size = new Size(32, 29);
            pbVerifyCod.TabIndex = 23;
            pbVerifyCod.TabStop = false;
            pbVerifyCod.Visible = false;
            // 
            // mtbDni
            // 
            mtbDni.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mtbDni.Location = new Point(133, 321);
            mtbDni.Mask = "999999999";
            mtbDni.Name = "mtbDni";
            mtbDni.Size = new Size(144, 29);
            mtbDni.TabIndex = 22;
            mtbDni.TextAlign = HorizontalAlignment.Center;
            mtbDni.ValidatingType = typeof(int);
            // 
            // numCodEmplo
            // 
            numCodEmplo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            numCodEmplo.Location = new Point(204, 366);
            numCodEmplo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCodEmplo.Name = "numCodEmplo";
            numCodEmplo.Size = new Size(122, 29);
            numCodEmplo.TabIndex = 21;
            numCodEmplo.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(55, 369);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 20;
            label4.Text = "Cod. empleado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(56, 324);
            label3.Name = "label3";
            label3.Size = new Size(38, 21);
            label3.TabIndex = 19;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(55, 269);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 18;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 219);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(133, 266);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(385, 29);
            txtLastName.TabIndex = 16;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(133, 216);
            txtName.Name = "txtName";
            txtName.Size = new Size(385, 29);
            txtName.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(29, 26);
            label5.Name = "label5";
            label5.Size = new Size(155, 21);
            label5.TabIndex = 31;
            label5.Text = "Forma de busqueda";
            // 
            // cbFilter
            // 
            cbFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "DNI", "NOMBRE", "APELLIDO" });
            cbFilter.Location = new Point(201, 23);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(175, 29);
            cbFilter.TabIndex = 30;
            // 
            // lbEmployee
            // 
            lbEmployee.FormattingEnabled = true;
            lbEmployee.ItemHeight = 15;
            lbEmployee.Location = new Point(37, 127);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(481, 64);
            lbEmployee.TabIndex = 29;
            // 
            // txtEmployee
            // 
            txtEmployee.Enabled = false;
            txtEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmployee.Location = new Point(200, 78);
            txtEmployee.Name = "txtEmployee";
            txtEmployee.Size = new Size(318, 29);
            txtEmployee.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(29, 81);
            label6.Name = "label6";
            label6.Size = new Size(147, 21);
            label6.TabIndex = 27;
            label6.Text = "Empleado a Buscar";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = SystemColors.ButtonFace;
            btnCreate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.Location = new Point(343, 439);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(175, 61);
            btnCreate.TabIndex = 32;
            btnCreate.Text = "Actualizar empleado";
            btnCreate.UseVisualStyleBackColor = false;
            // 
            // EmployeeUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 512);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployeeUpdate";
            Text = "EmployeeUpdate";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbDni).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVerifyCod).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCodEmplo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lDni;
        private PictureBox pbDni;
        private Label lResult;
        private PictureBox pbVerifyCod;
        private MaskedTextBox mtbDni;
        private NumericUpDown numCodEmplo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtLastName;
        private TextBox txtName;
        private Label label5;
        private ComboBox cbFilter;
        private ListBox lbEmployee;
        private TextBox txtEmployee;
        private Label label6;
        private Button btnCreate;
    }
}