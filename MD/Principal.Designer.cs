namespace MD
{
    partial class Principal
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
            this.ComboTema = new System.Windows.Forms.ComboBox();
            this.Tema = new System.Windows.Forms.Button();
            this.PanelP = new System.Windows.Forms.Panel();
            this.Prueba = new System.Windows.Forms.Button();
            this.PanelS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            this.PanelL.SuspendLayout();
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
            this.Minimizar.BackgroundImage = global::MD.Properties.Resources.pngwing_com__1_;
            this.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimizar.Image = global::MD.Properties.Resources.pngwing_com;
            this.Minimizar.Location = new System.Drawing.Point(802, 4);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(38, 33);
            this.Minimizar.TabIndex = 3;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar.BackgroundImage = global::MD.Properties.Resources.pngwing_com;
            this.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cerrar.Image = global::MD.Properties.Resources.pngwing_com;
            this.Cerrar.Location = new System.Drawing.Point(846, 4);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(38, 33);
            this.Cerrar.TabIndex = 2;
            this.Cerrar.TabStop = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // PanelL
            // 
            this.PanelL.BackColor = System.Drawing.Color.LightGray;
            this.PanelL.Controls.Add(this.ComboTema);
            this.PanelL.Controls.Add(this.Tema);
            this.PanelL.Location = new System.Drawing.Point(-1, 40);
            this.PanelL.Name = "PanelL";
            this.PanelL.Size = new System.Drawing.Size(224, 561);
            this.PanelL.TabIndex = 1;
            this.PanelL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelL_MouseMove);
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
            this.Tema.FlatAppearance.BorderSize = 0;
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
            this.PanelP.Controls.Add(this.Prueba);
            this.PanelP.Location = new System.Drawing.Point(222, 41);
            this.PanelP.Name = "PanelP";
            this.PanelP.Size = new System.Drawing.Size(682, 561);
            this.PanelP.TabIndex = 1;
            this.PanelP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelP_MouseMove);
            // 
            // Prueba
            // 
            this.Prueba.FlatAppearance.BorderSize = 0;
            this.Prueba.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Prueba.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Prueba.Location = new System.Drawing.Point(172, 313);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(214, 37);
            this.Prueba.TabIndex = 2;
            this.Prueba.Text = "Prueba";
            this.Prueba.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 591);
            this.Controls.Add(this.PanelS);
            this.Controls.Add(this.PanelL);
            this.Controls.Add(this.PanelP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.PanelS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            this.PanelL.ResumeLayout(false);
            this.PanelP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelS;
        private System.Windows.Forms.Panel PanelL;
        private System.Windows.Forms.Panel PanelP;
        private PictureBox Minimizar;
        private PictureBox Cerrar;
        private Button Tema;
        private ComboBox ComboTema;
        private Button Prueba;
    }
}