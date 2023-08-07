namespace SystemERP.View
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            btnTurnOver = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pMenu = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnTurnOver);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 561);
            panel1.TabIndex = 0;
            // 
            // btnTurnOver
            // 
            btnTurnOver.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTurnOver.BackColor = SystemColors.Menu;
            btnTurnOver.BackgroundImageLayout = ImageLayout.Stretch;
            btnTurnOver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTurnOver.Image = (Image)resources.GetObject("btnTurnOver.Image");
            btnTurnOver.ImageAlign = ContentAlignment.MiddleLeft;
            btnTurnOver.Location = new Point(3, 101);
            btnTurnOver.Name = "btnTurnOver";
            btnTurnOver.Size = new Size(218, 49);
            btnTurnOver.TabIndex = 1;
            btnTurnOver.Text = "Facturacion";
            btnTurnOver.UseVisualStyleBackColor = false;
            btnTurnOver.Visible = false;
            btnTurnOver.KeyPress += Menu_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.proyecto;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 29);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 20);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 0;
            label1.Text = "Isekai Technology ©";
            // 
            // pMenu
            // 
            pMenu.Dock = DockStyle.Fill;
            pMenu.Location = new Point(221, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(693, 561);
            pMenu.TabIndex = 1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 561);
            ControlBox = false;
            Controls.Add(pMenu);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            KeyPress += Menu_KeyPress;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnTurnOver;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pMenu;
    }
}