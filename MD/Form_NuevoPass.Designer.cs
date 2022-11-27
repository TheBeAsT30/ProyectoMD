namespace MD
{
    partial class Form_NuevoPass
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
            this.ConfirmarPass = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Modificar1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonRegresar = new FontAwesome.Sharp.IconButton();
            this.iconPictureBoxNVer2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxNVer1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxVer2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBoxVer1 = new FontAwesome.Sharp.IconPictureBox();
            this.PanelS = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNVer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNVer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxVer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxVer1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmarPass
            // 
            this.ConfirmarPass.BackColor = System.Drawing.SystemColors.Window;
            this.ConfirmarPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConfirmarPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmarPass.ForeColor = System.Drawing.Color.DimGray;
            this.ConfirmarPass.Location = new System.Drawing.Point(67, 150);
            this.ConfirmarPass.Multiline = true;
            this.ConfirmarPass.Name = "ConfirmarPass";
            this.ConfirmarPass.PasswordChar = '*';
            this.ConfirmarPass.Size = new System.Drawing.Size(292, 30);
            this.ConfirmarPass.TabIndex = 28;
            this.ConfirmarPass.Text = "CONFIRMAR CONTRASEÑA";
            this.ConfirmarPass.Enter += new System.EventHandler(this.ConfirmarPass_Enter);
            this.ConfirmarPass.Leave += new System.EventHandler(this.ConfirmarPass_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(41, 112);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 30;
            this.iconPictureBox2.TabStop = false;
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.Contraseña.Location = new System.Drawing.Point(67, 112);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(292, 30);
            this.Contraseña.TabIndex = 27;
            this.Contraseña.Text = "CONTRASEÑA";
            this.Contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // Modificar1
            // 
            this.Modificar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Modificar1.FlatAppearance.BorderSize = 0;
            this.Modificar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modificar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Modificar1.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            this.Modificar1.IconColor = System.Drawing.Color.Black;
            this.Modificar1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Modificar1.IconSize = 25;
            this.Modificar1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modificar1.Location = new System.Drawing.Point(156, 186);
            this.Modificar1.Name = "Modificar1";
            this.Modificar1.Size = new System.Drawing.Size(106, 35);
            this.Modificar1.TabIndex = 29;
            this.Modificar1.Text = "Modificar";
            this.Modificar1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificar1.UseVisualStyleBackColor = true;
            this.Modificar1.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelS);
            this.panel1.Controls.Add(this.iconButtonRegresar);
            this.panel1.Controls.Add(this.Modificar1);
            this.panel1.Controls.Add(this.iconPictureBoxNVer2);
            this.panel1.Controls.Add(this.iconPictureBoxNVer1);
            this.panel1.Controls.Add(this.iconPictureBoxVer2);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.ConfirmarPass);
            this.panel1.Controls.Add(this.iconPictureBoxVer1);
            this.panel1.Controls.Add(this.Contraseña);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 393);
            this.panel1.TabIndex = 35;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // iconButtonRegresar
            // 
            this.iconButtonRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonRegresar.FlatAppearance.BorderSize = 0;
            this.iconButtonRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRegresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButtonRegresar.IconChar = FontAwesome.Sharp.IconChar.Share;
            this.iconButtonRegresar.IconColor = System.Drawing.Color.Black;
            this.iconButtonRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRegresar.IconSize = 25;
            this.iconButtonRegresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonRegresar.Location = new System.Drawing.Point(156, 227);
            this.iconButtonRegresar.Name = "iconButtonRegresar";
            this.iconButtonRegresar.Size = new System.Drawing.Size(106, 35);
            this.iconButtonRegresar.TabIndex = 34;
            this.iconButtonRegresar.Text = "Regresar";
            this.iconButtonRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRegresar.UseVisualStyleBackColor = true;
            this.iconButtonRegresar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconPictureBoxNVer2
            // 
            this.iconPictureBoxNVer2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxNVer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxNVer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxNVer2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconPictureBoxNVer2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxNVer2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxNVer2.IconSize = 19;
            this.iconPictureBoxNVer2.Location = new System.Drawing.Point(316, 156);
            this.iconPictureBoxNVer2.Name = "iconPictureBoxNVer2";
            this.iconPictureBoxNVer2.Size = new System.Drawing.Size(23, 19);
            this.iconPictureBoxNVer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxNVer2.TabIndex = 33;
            this.iconPictureBoxNVer2.TabStop = false;
            this.iconPictureBoxNVer2.Click += new System.EventHandler(this.iconPictureBoxNVer2_Click);
            // 
            // iconPictureBoxNVer1
            // 
            this.iconPictureBoxNVer1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxNVer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxNVer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxNVer1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconPictureBoxNVer1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxNVer1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxNVer1.IconSize = 19;
            this.iconPictureBoxNVer1.Location = new System.Drawing.Point(316, 118);
            this.iconPictureBoxNVer1.Name = "iconPictureBoxNVer1";
            this.iconPictureBoxNVer1.Size = new System.Drawing.Size(23, 19);
            this.iconPictureBoxNVer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxNVer1.TabIndex = 32;
            this.iconPictureBoxNVer1.TabStop = false;
            this.iconPictureBoxNVer1.Click += new System.EventHandler(this.iconPictureBoxNVer1_Click);
            // 
            // iconPictureBoxVer2
            // 
            this.iconPictureBoxVer2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxVer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxVer2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxVer2.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBoxVer2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxVer2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxVer2.IconSize = 19;
            this.iconPictureBoxVer2.Location = new System.Drawing.Point(316, 156);
            this.iconPictureBoxVer2.Name = "iconPictureBoxVer2";
            this.iconPictureBoxVer2.Size = new System.Drawing.Size(23, 19);
            this.iconPictureBoxVer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxVer2.TabIndex = 31;
            this.iconPictureBoxVer2.TabStop = false;
            this.iconPictureBoxVer2.Click += new System.EventHandler(this.iconPictureBoxVer2_Click);
            // 
            // iconPictureBoxVer1
            // 
            this.iconPictureBoxVer1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxVer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxVer1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxVer1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBoxVer1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBoxVer1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxVer1.IconSize = 19;
            this.iconPictureBoxVer1.Location = new System.Drawing.Point(316, 118);
            this.iconPictureBoxVer1.Name = "iconPictureBoxVer1";
            this.iconPictureBoxVer1.Size = new System.Drawing.Size(23, 19);
            this.iconPictureBoxVer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBoxVer1.TabIndex = 0;
            this.iconPictureBoxVer1.TabStop = false;
            this.iconPictureBoxVer1.Click += new System.EventHandler(this.iconPictureBoxVer1_Click);
            // 
            // PanelS
            // 
            this.PanelS.BackColor = System.Drawing.Color.Black;
            this.PanelS.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelS.Location = new System.Drawing.Point(0, 0);
            this.PanelS.Name = "PanelS";
            this.PanelS.Size = new System.Drawing.Size(416, 35);
            this.PanelS.TabIndex = 35;
            // 
            // Form_NuevoPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NuevoPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_NuevoPass";
            this.Load += new System.EventHandler(this.Form_NuevoPass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNVer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxNVer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxVer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxVer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox ConfirmarPass;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private TextBox Contraseña;
        private FontAwesome.Sharp.IconButton Modificar1;
        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxVer2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxVer1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxNVer2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxNVer1;
        private FontAwesome.Sharp.IconButton iconButtonRegresar;
        private Panel PanelS;
    }
}