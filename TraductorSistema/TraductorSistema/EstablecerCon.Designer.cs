namespace TraductorSistema
{
    partial class EstablecerCon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstablecerCon));
            this.contraseña1 = new System.Windows.Forms.TextBox();
            this.contraseña2 = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contraseña1
            // 
            this.contraseña1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña1.Location = new System.Drawing.Point(902, 333);
            this.contraseña1.Name = "contraseña1";
            this.contraseña1.PasswordChar = '*';
            this.contraseña1.Size = new System.Drawing.Size(245, 29);
            this.contraseña1.TabIndex = 0;
            // 
            // contraseña2
            // 
            this.contraseña2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña2.Location = new System.Drawing.Point(902, 429);
            this.contraseña2.Name = "contraseña2";
            this.contraseña2.PasswordChar = '*';
            this.contraseña2.Size = new System.Drawing.Size(245, 29);
            this.contraseña2.TabIndex = 1;
            // 
            // Aceptar
            // 
            this.Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aceptar.BackgroundImage")));
            this.Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Aceptar.Location = new System.Drawing.Point(883, 554);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(202, 61);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // EstablecerCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.contraseña2);
            this.Controls.Add(this.contraseña1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EstablecerCon";
            this.Text = "Signs Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EstablecerCon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contraseña1;
        private System.Windows.Forms.TextBox contraseña2;
        private System.Windows.Forms.Button Aceptar;
    }
}