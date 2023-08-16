namespace SystemERP.View
{
    partial class DeleteUser
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
            lbUsers = new ListBox();
            label1 = new Label();
            btnDisableUser = new Button();
            SuspendLayout();
            // 
            // lbUsers
            // 
            lbUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsers.FormattingEnabled = true;
            lbUsers.HorizontalScrollbar = true;
            lbUsers.ItemHeight = 17;
            lbUsers.Location = new Point(11, 47);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(530, 242);
            lbUsers.TabIndex = 19;
            lbUsers.SelectedIndexChanged += lbUsers_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 21);
            label1.TabIndex = 18;
            label1.Text = "Seleccione el usuario a desabilitar ";
            // 
            // btnDisableUser
            // 
            btnDisableUser.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDisableUser.Location = new Point(384, 407);
            btnDisableUser.Name = "btnDisableUser";
            btnDisableUser.Size = new Size(157, 45);
            btnDisableUser.TabIndex = 20;
            btnDisableUser.Text = "Desabilitar Usuario";
            btnDisableUser.UseVisualStyleBackColor = true;
            btnDisableUser.Click += btnDisableUser_Click;
            // 
            // DeleteUser
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(565, 473);
            Controls.Add(btnDisableUser);
            Controls.Add(lbUsers);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "DeleteUser";
            Text = "DeleteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbUsers;
        private Label label1;
        private Button btnDisableUser;
    }
}