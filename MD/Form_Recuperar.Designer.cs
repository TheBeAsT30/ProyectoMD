namespace MD
{
    partial class Form_Recuperar
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
            this.textmessage = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.Enviar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.respuesta = new System.Windows.Forms.Label();
            this.Validar = new FontAwesome.Sharp.IconButton();
            this.textCode = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textmessage
            // 
            this.textmessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textmessage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textmessage.ForeColor = System.Drawing.Color.DimGray;
            this.textmessage.Location = new System.Drawing.Point(71, 127);
            this.textmessage.Multiline = true;
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(292, 30);
            this.textmessage.TabIndex = 18;
            this.textmessage.Text = "CORREO";
            this.textmessage.Enter += new System.EventHandler(this.textmessage_Enter);
            this.textmessage.Leave += new System.EventHandler(this.textmessage_Leave);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(45, 127);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 19;
            this.iconPictureBox1.TabStop = false;
            // 
            // Enviar
            // 
            this.Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enviar.FlatAppearance.BorderSize = 0;
            this.Enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enviar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Enviar.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleUp;
            this.Enviar.IconColor = System.Drawing.Color.Black;
            this.Enviar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Enviar.IconSize = 25;
            this.Enviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Enviar.Location = new System.Drawing.Point(155, 163);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(86, 35);
            this.Enviar.TabIndex = 21;
            this.Enviar.Text = "Enviar";
            this.Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.respuesta);
            this.panel1.Controls.Add(this.Validar);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Controls.Add(this.textmessage);
            this.panel1.Controls.Add(this.Enviar);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 393);
            this.panel1.TabIndex = 22;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // respuesta
            // 
            this.respuesta.AutoSize = true;
            this.respuesta.Location = new System.Drawing.Point(45, 247);
            this.respuesta.Name = "respuesta";
            this.respuesta.Size = new System.Drawing.Size(0, 15);
            this.respuesta.TabIndex = 30;
            // 
            // Validar
            // 
            this.Validar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Validar.FlatAppearance.BorderSize = 0;
            this.Validar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Validar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Validar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Validar.IconColor = System.Drawing.Color.Black;
            this.Validar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Validar.IconSize = 25;
            this.Validar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Validar.Location = new System.Drawing.Point(155, 261);
            this.Validar.Name = "Validar";
            this.Validar.Size = new System.Drawing.Size(86, 35);
            this.Validar.TabIndex = 29;
            this.Validar.Text = "Validar";
            this.Validar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Validar.UseVisualStyleBackColor = true;
            this.Validar.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textCode
            // 
            this.textCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textCode.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCode.ForeColor = System.Drawing.Color.DimGray;
            this.textCode.Location = new System.Drawing.Point(71, 214);
            this.textCode.Multiline = true;
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(292, 30);
            this.textCode.TabIndex = 27;
            this.textCode.Text = "CODIGO";
            this.textCode.Enter += new System.EventHandler(this.textCode_Enter);
            this.textCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCode_KeyPress);
            this.textCode.Leave += new System.EventHandler(this.textCode_Leave);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(45, 214);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 30);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 28;
            this.iconPictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(358, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "El código caduce a los próximos 4 minutos del envío";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(97, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "en el campo que dice CODIGO.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Le enviaremos un código de 4 dígitos el cual debe introducir";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMensaje.Location = new System.Drawing.Point(71, 20);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(263, 20);
            this.labelMensaje.TabIndex = 22;
            this.labelMensaje.Text = "Por favor ingrese su correo electrónico";
            this.labelMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Recuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 393);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Recuperar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Recuperar";
            this.Load += new System.EventHandler(this.Form_Recuperar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox textmessage;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton Enviar;
        private Panel panel1;
        private Label labelMensaje;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox textCode;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton Validar;
        private Label respuesta;
    }
}