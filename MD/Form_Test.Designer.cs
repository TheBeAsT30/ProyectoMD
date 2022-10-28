namespace MD
{
    partial class Form_Test
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
            this.buttonAmarillo = new System.Windows.Forms.Button();
            this.PanelT = new System.Windows.Forms.Panel();
            this.PanelT.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAmarillo
            // 
            this.buttonAmarillo.Location = new System.Drawing.Point(249, 199);
            this.buttonAmarillo.Name = "buttonAmarillo";
            this.buttonAmarillo.Size = new System.Drawing.Size(75, 23);
            this.buttonAmarillo.TabIndex = 0;
            this.buttonAmarillo.Text = "Amarillo";
            this.buttonAmarillo.UseVisualStyleBackColor = true;
            this.buttonAmarillo.Click += new System.EventHandler(this.button1_Click);
            // 
            // PanelT
            // 
            this.PanelT.Controls.Add(this.buttonAmarillo);
            this.PanelT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelT.Location = new System.Drawing.Point(0, 0);
            this.PanelT.Name = "PanelT";
            this.PanelT.Size = new System.Drawing.Size(800, 450);
            this.PanelT.TabIndex = 1;
            // 
            // Form_temas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_temas";
            this.Text = "Form_temas";
            this.Load += new System.EventHandler(this.Form_temas_Load);
            this.PanelT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAmarillo;
        private System.Windows.Forms.Panel PanelT;
    }
}