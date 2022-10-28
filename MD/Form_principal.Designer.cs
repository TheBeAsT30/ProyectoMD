namespace MD
{
    partial class Form_principal
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
            this.PanelS = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Cerrar = new System.Windows.Forms.PictureBox();
            this.PanelL = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ComboTema = new System.Windows.Forms.ComboBox();
            this.Tema = new System.Windows.Forms.Button();
            this.PanelP = new System.Windows.Forms.Panel();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.PanelS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.PanelL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.PanelP.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelS
            // 
            this.PanelS.BackColor = System.Drawing.Color.Black;
            this.PanelS.Controls.Add(this.Minimizar);
            this.PanelS.Controls.Add(this.Cerrar);
            this.PanelS.Location = new System.Drawing.Point(-4, 0);
            this.PanelS.Name = "PanelS";
            this.PanelS.Size = new System.Drawing.Size(887, 42);
            this.PanelS.TabIndex = 0;
            this.PanelS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelS_MouseMove);
            // 
            // Minimizar
            // 
            this.Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimizar.Image = global::MD.Properties.Resources.Minimize;
            this.Minimizar.Location = new System.Drawing.Point(802, 4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(38, 33);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrar.Image = global::MD.Properties.Resources.Close1;
            this.Cerrar.Location = new System.Drawing.Point(846, 4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(38, 33);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // PanelL
            // 
            this.PanelL.BackColor = System.Drawing.Color.LightGray;
            this.PanelL.Controls.Add(this.iconPictureBox1);
            this.PanelL.Controls.Add(this.ComboTema);
            this.PanelL.Controls.Add(this.Tema);
            this.PanelL.Location = new System.Drawing.Point(-1, 40);
            this.PanelL.Name = "PanelL";
            this.PanelL.Size = new System.Drawing.Size(224, 561);
            this.PanelL.TabIndex = 1;
            this.PanelL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelL_MouseMove);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 8);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(78, 81);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // ComboTema
            // 
            this.ComboTema.FormattingEnabled = true;
            this.ComboTema.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Morado",
            "Negro",
            "Rojo"});
            this.ComboTema.Location = new System.Drawing.Point(16, 427);
            this.ComboTema.Name = "ComboTema";
            this.ComboTema.Size = new System.Drawing.Size(194, 23);
            this.ComboTema.TabIndex = 1;
            this.ComboTema.Visible = false;
            this.ComboTema.SelectedIndexChanged += new System.EventHandler(this.ComboTema_SelectedIndexChanged);
            // 
            // Tema
            // 
            this.Tema.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tema.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tema.Location = new System.Drawing.Point(5, 384);
            this.Tema.Name = "Tema";
            this.Tema.Size = new System.Drawing.Size(214, 37);
            this.Tema.TabIndex = 0;
            this.Tema.Text = "Temas";
            this.Tema.UseVisualStyleBackColor = true;
            this.Tema.Click += new System.EventHandler(this.Tema_Click);
            // 
            // PanelP
            // 
            this.PanelP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelP.Controls.Add(this.buttonBlue);
            this.PanelP.Controls.Add(this.buttonYellow);
            this.PanelP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelP.Location = new System.Drawing.Point(0, 0);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(882, 591);
            this.PanelP.TabIndex = 1;
            this.PanelP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelP_MouseMove);
            // 
            // buttonBlue
            // 
            this.buttonBlue.Location = new System.Drawing.Point(417, 153);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(75, 23);
            this.buttonBlue.TabIndex = 1;
            this.buttonBlue.Text = "Azul";
            this.buttonBlue.UseVisualStyleBackColor = true;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.Location = new System.Drawing.Point(316, 153);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(75, 23);
            this.buttonYellow.TabIndex = 0;
            this.buttonYellow.Text = "Amarillo";
            this.buttonYellow.UseVisualStyleBackColor = true;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 591);
            this.Controls.Add(this.PanelS);
            this.Controls.Add(this.PanelL);
            this.Controls.Add(this.PanelP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.PanelL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.PanelP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel PanelS;
        private System.Windows.Forms.Panel PanelL;
        private System.Windows.Forms.Panel PanelP;
        private PictureBox Minimizar;
        private PictureBox Cerrar;
        private Button Tema;
        private ComboBox ComboTema;
        private Button buttonYellow;
        private Button buttonBlue;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}