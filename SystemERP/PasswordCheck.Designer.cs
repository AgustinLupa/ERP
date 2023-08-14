namespace SystemERP.View
{
    partial class PasswordCheck
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
            btnConfirm = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(83, 62);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(86, 39);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Aceptar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(190, 62);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 39);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "Clave";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(83, 19);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(224, 23);
            txtPass.TabIndex = 1;
            // 
            // PasswordCheck
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 112);
            ControlBox = false;
            Controls.Add(txtPass);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "PasswordCheck";
            Text = "Ingresar clave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Button btnCancel;
        private Label label1;
        private TextBox txtPass;
    }
}