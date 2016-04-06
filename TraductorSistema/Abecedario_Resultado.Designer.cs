namespace TraductorSistema
{
    partial class Abecedario_Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abecedario_Resultado));
            this.Regresar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Regresar.BackgroundImage")));
            this.Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regresar.Location = new System.Drawing.Point(676, 398);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(109, 34);
            this.Regresar.TabIndex = 3;
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salir.BackgroundImage")));
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir.Location = new System.Drawing.Point(811, 398);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(74, 33);
            this.Salir.TabIndex = 2;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBox1.Location = new System.Drawing.Point(273, 140);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(419, 252);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 4;
            this.PictureBox1.TabStop = false;
            // 
            // Abecedario_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 540);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.Salir);
            this.Name = "Abecedario_Resultado";
            this.Text = "Abecedario_Resultado";
            this.Load += new System.EventHandler(this.Abecedario_Resultado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Regresar;
        internal System.Windows.Forms.Button Salir;
        public System.Windows.Forms.PictureBox PictureBox1;
    }
}