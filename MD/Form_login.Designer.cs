namespace MD
{
    partial class Form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_login));
            this.PanelP = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Acceder = new FontAwesome.Sharp.IconButton();
            this.PanelS = new System.Windows.Forms.Panel();
            this.PanelB = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox7 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.PanelP.SuspendLayout();
            this.PanelS.SuspendLayout();
            this.PanelB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelP
            // 
            this.PanelP.Controls.Add(this.linkLabel1);
            this.PanelP.Controls.Add(this.Acceder);
            this.PanelP.Controls.Add(this.PanelS);
            this.PanelP.Controls.Add(this.panelLogin);
            this.PanelP.Controls.Add(this.Label5);
            this.PanelP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelP.Location = new System.Drawing.Point(0, 0);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(416, 393);
            this.PanelP.TabIndex = 2;
            this.PanelP.DoubleClick += new System.EventHandler(this.PanelP_DoubleClick);
            this.PanelP.MouseLeave += new System.EventHandler(this.PanelP_MouseLeave);
            this.PanelP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelP_MouseMove);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(231, 213);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 15);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "¿Olvidaste tu Contraseña?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Acceder
            // 
            this.Acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Acceder.FlatAppearance.BorderSize = 0;
            this.Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acceder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Acceder.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.Acceder.IconColor = System.Drawing.Color.Black;
            this.Acceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Acceder.IconSize = 25;
            this.Acceder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Acceder.Location = new System.Drawing.Point(150, 272);
            this.Acceder.Name = "Acceder";
            this.Acceder.Size = new System.Drawing.Size(99, 35);
            this.Acceder.TabIndex = 4;
            this.Acceder.Text = "Accerder";
            this.Acceder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acceder.UseVisualStyleBackColor = true;
            this.Acceder.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // PanelS
            // 
            this.PanelS.BackColor = System.Drawing.Color.Black;
            this.PanelS.Controls.Add(this.PanelB);
            this.PanelS.Controls.Add(this.iconPictureBox7);
            this.PanelS.Controls.Add(this.iconPictureBox5);
            this.PanelS.Controls.Add(this.Label4);
            this.PanelS.Controls.Add(this.pictureBox3);
            this.PanelS.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelS.Location = new System.Drawing.Point(0, 0);
            this.PanelS.Name = "PanelS";
            this.PanelS.Size = new System.Drawing.Size(416, 79);
            this.PanelS.TabIndex = 14;
            // 
            // PanelB
            // 
            this.PanelB.Controls.Add(this.iconButton1);
            this.PanelB.Controls.Add(this.iconButton2);
            this.PanelB.Location = new System.Drawing.Point(0, 32);
            this.PanelB.Name = "PanelB";
            this.PanelB.Size = new System.Drawing.Size(416, 54);
            this.PanelB.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 20;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(74, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(119, 38);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Iniciar Sesion";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(212, 3);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(119, 38);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Registrarse";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconPictureBox7
            // 
            this.iconPictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox7.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox7.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox7.IconSize = 23;
            this.iconPictureBox7.Location = new System.Drawing.Point(378, 4);
            this.iconPictureBox7.Name = "iconPictureBox7";
            this.iconPictureBox7.Rotation = 45D;
            this.iconPictureBox7.Size = new System.Drawing.Size(26, 23);
            this.iconPictureBox7.TabIndex = 15;
            this.iconPictureBox7.TabStop = false;
            this.iconPictureBox7.Click += new System.EventHandler(this.iconPictureBox7_Click);
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox5.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 23;
            this.iconPictureBox5.Location = new System.Drawing.Point(348, 4);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(26, 23);
            this.iconPictureBox5.TabIndex = 14;
            this.iconPictureBox5.TabStop = false;
            this.iconPictureBox5.Click += new System.EventHandler(this.iconPictureBox5_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(48, 4);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(75, 25);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "LeyesM";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::MD.Properties.Resources.kisspng_computer_icons_product_manuals_document_accellion_professional_development_5b1d57ad517cf4_7595652215286496453338;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 29);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.iconPictureBox4);
            this.panelLogin.Controls.Add(this.iconPictureBox3);
            this.panelLogin.Controls.Add(this.Usuario);
            this.panelLogin.Controls.Add(this.iconPictureBox1);
            this.panelLogin.Controls.Add(this.iconPictureBox2);
            this.panelLogin.Controls.Add(this.Contraseña);
            this.panelLogin.Location = new System.Drawing.Point(43, 136);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(327, 77);
            this.panelLogin.TabIndex = 1;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.iconPictureBox4.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 19;
            this.iconPictureBox4.Location = new System.Drawing.Point(296, 44);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox4.TabIndex = 14;
            this.iconPictureBox4.TabStop = false;
            this.iconPictureBox4.Click += new System.EventHandler(this.iconPictureBox4_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 19;
            this.iconPictureBox3.Location = new System.Drawing.Point(296, 44);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(19, 20);
            this.iconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox3.TabIndex = 13;
            this.iconPictureBox3.TabStop = false;
            this.iconPictureBox3.Click += new System.EventHandler(this.iconPictureBox3_Click);
            // 
            // Usuario
            // 
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usuario.ForeColor = System.Drawing.Color.DimGray;
            this.Usuario.Location = new System.Drawing.Point(32, 3);
            this.Usuario.Multiline = true;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(292, 30);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "USUARIO O CORREO";
            this.Usuario.Enter += new System.EventHandler(this.Usuario_Enter);
            this.Usuario.Leave += new System.EventHandler(this.Usuario_Leave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 11;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(3, 39);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox2.TabIndex = 12;
            this.iconPictureBox2.TabStop = false;
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contraseña.ForeColor = System.Drawing.Color.DimGray;
            this.Contraseña.Location = new System.Drawing.Point(32, 39);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(292, 30);
            this.Contraseña.TabIndex = 3;
            this.Contraseña.Text = "CONTRASEÑA";
            this.Contraseña.Enter += new System.EventHandler(this.Contraseña_Enter);
            this.Contraseña.Leave += new System.EventHandler(this.Contraseña_Leave);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.Location = new System.Drawing.Point(33, 213);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(0, 15);
            this.Label5.TabIndex = 10;
            this.Label5.Visible = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 393);
            this.Controls.Add(this.PanelP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppMD";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.PanelP.ResumeLayout(false);
            this.PanelP.PerformLayout();
            this.PanelS.ResumeLayout(false);
            this.PanelS.PerformLayout();
            this.PanelB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelP;
        private TextBox Usuario;
        private TextBox Contraseña;
        private Label Label5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Panel panelLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Panel PanelS;
        private Panel PanelB;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox7;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private Label Label4;
        private PictureBox pictureBox3;
        private FontAwesome.Sharp.IconButton Acceder;
        private LinkLabel linkLabel1;
    }
}