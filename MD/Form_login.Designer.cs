namespace MD
{
    partial class Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel));
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.PanelS = new System.Windows.Forms.Panel();
            this.Label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.PanelP = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ojoM = new System.Windows.Forms.PictureBox();
            this.ojoO = new System.Windows.Forms.PictureBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.PanelL = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.PanelS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            this.PanelP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ojoM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ojoO)).BeginInit();
            this.SuspendLayout();
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar.BackgroundImage = global::MD.Properties.Resources.Close;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrar.Image = global::MD.Properties.Resources.Close;
            this.Cerrar.Location = new System.Drawing.Point(700, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(38, 33);
            this.Cerrar.TabIndex = 0;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // PanelS
            // 
            this.PanelS.BackColor = System.Drawing.Color.Black;
            this.PanelS.Controls.Add(this.Label4);
            this.PanelS.Controls.Add(this.pictureBox3);
            this.PanelS.Controls.Add(this.Minimizar);
            this.PanelS.Controls.Add(this.Cerrar);
            this.PanelS.Location = new System.Drawing.Point(-1, 0);
            this.PanelS.Name = "PanelS";
            this.PanelS.Size = new System.Drawing.Size(741, 33);
            this.PanelS.TabIndex = 1;
            this.PanelS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelS_MouseMove);
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
            this.pictureBox3.Image = global::MD.Properties.Resources.Close;
            this.pictureBox3.Location = new System.Drawing.Point(3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 33);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.BackgroundImage = global::MD.Properties.Resources.Minimize;
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimizar.Image = global::MD.Properties.Resources.Minimize;
            this.Minimizar.Location = new System.Drawing.Point(656, 0);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(38, 33);
            this.Minimizar.TabIndex = 1;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PanelP
            // 
            this.PanelP.Controls.Add(this.Label5);
            this.PanelP.Controls.Add(this.pictureBox1);
            this.PanelP.Controls.Add(this.ojoM);
            this.PanelP.Controls.Add(this.ojoO);
            this.PanelP.Controls.Add(this.Label3);
            this.PanelP.Controls.Add(this.Label2);
            this.PanelP.Controls.Add(this.Label1);
            this.PanelP.Controls.Add(this.Usuario);
            this.PanelP.Controls.Add(this.Contraseña);
            this.PanelP.Controls.Add(this.Ingresar);
            this.PanelP.Controls.Add(this.PanelL);
            this.PanelP.Location = new System.Drawing.Point(0, 25);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(740, 378);
            this.PanelP.TabIndex = 2;
            this.PanelP.MouseLeave += new System.EventHandler(this.PanelP_MouseLeave);
            this.PanelP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelP_MouseMove);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label5.Location = new System.Drawing.Point(131, 321);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(319, 30);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Usuario o Contraseña incorrectas";
            this.Label5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MD.Properties.Resources.login;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(232, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 90);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ojoM
            // 
            this.ojoM.BackColor = System.Drawing.Color.Transparent;
            this.ojoM.BackgroundImage = global::MD.Properties.Resources.pngegg;
            this.ojoM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ojoM.Location = new System.Drawing.Point(413, 216);
            this.ojoM.Name = "ojoM";
            this.ojoM.Size = new System.Drawing.Size(27, 28);
            this.ojoM.TabIndex = 7;
            this.ojoM.TabStop = false;
            this.ojoM.Click += new System.EventHandler(this.ojoM_Click);
            // 
            // ojoO
            // 
            this.ojoO.BackgroundImage = global::MD.Properties.Resources.pngegg__1_;
            this.ojoO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ojoO.Location = new System.Drawing.Point(413, 215);
            this.ojoO.Name = "ojoO";
            this.ojoO.Size = new System.Drawing.Size(27, 28);
            this.ojoO.TabIndex = 8;
            this.ojoO.TabStop = false;
            this.ojoO.Visible = false;
            this.ojoO.Click += new System.EventHandler(this.ojoO_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label3.Location = new System.Drawing.Point(189, 287);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(190, 21);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "¿Olvidaste tu Contraseña?";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(48, 218);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(112, 25);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Contraseña:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label1.Location = new System.Drawing.Point(79, 165);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 25);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Usuario:";
            // 
            // Usuario
            // 
            this.Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Usuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Usuario.ForeColor = System.Drawing.Color.Black;
            this.Usuario.Location = new System.Drawing.Point(160, 163);
            this.Usuario.Multiline = true;
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(247, 30);
            this.Usuario.TabIndex = 3;
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // Contraseña
            // 
            this.Contraseña.BackColor = System.Drawing.SystemColors.Window;
            this.Contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Contraseña.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contraseña.ForeColor = System.Drawing.Color.Black;
            this.Contraseña.Location = new System.Drawing.Point(160, 216);
            this.Contraseña.Multiline = true;
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.PasswordChar = '*';
            this.Contraseña.Size = new System.Drawing.Size(247, 30);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.TextAlignChanged += new System.EventHandler(this.Contraseña_TextAlignChanged);
            this.Contraseña.TextChanged += new System.EventHandler(this.Contraseña_TextChanged);
            // 
            // Ingresar
            // 
            this.Ingresar.FlatAppearance.BorderSize = 0;
            this.Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ingresar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ingresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ingresar.Location = new System.Drawing.Point(232, 252);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(95, 31);
            this.Ingresar.TabIndex = 1;
            this.Ingresar.Text = "Entrar";
            this.Ingresar.UseVisualStyleBackColor = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // PanelL
            // 
            this.PanelL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelL.Location = new System.Drawing.Point(493, 3);
            this.PanelL.Name = "PanelL";
            this.PanelL.Size = new System.Drawing.Size(244, 375);
            this.PanelL.TabIndex = 0;
            this.PanelL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelL_MouseMove);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 401);
            this.Controls.Add(this.PanelS);
            this.Controls.Add(this.PanelP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppMD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Panel_FormClosing);
            this.Load += new System.EventHandler(this.PanelP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.PanelS.ResumeLayout(false);
            this.PanelS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            this.PanelP.ResumeLayout(false);
            this.PanelP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ojoM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ojoO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox Cerrar;
        private System.Windows.Forms.Panel PanelS;
        private PictureBox Minimizar;
        private System.Windows.Forms.Panel PanelP;
        private System.Windows.Forms.Panel PanelL;
        private Button Ingresar;
        private Label Label3;
        private Label Label2;
        private Label Label1;
        private TextBox Usuario;
        private TextBox Contraseña;
        private PictureBox ojoM;
        private PictureBox ojoO;
        private PictureBox pictureBox1;
        private Label Label4;
        private PictureBox pictureBox3;
        private Label Label5;
    }
}