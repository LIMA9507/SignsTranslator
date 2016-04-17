namespace TraductorSistema
{
    partial class SingsTranslator
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingsTranslator));
            this.Abecedario = new System.Windows.Forms.Button();
            this.Empezaratraducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Abecedario
            // 
            this.Abecedario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Abecedario.BackgroundImage")));
            this.Abecedario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Abecedario.Location = new System.Drawing.Point(573, 498);
            this.Abecedario.Name = "Abecedario";
            this.Abecedario.Size = new System.Drawing.Size(288, 69);
            this.Abecedario.TabIndex = 3;
            this.Abecedario.UseVisualStyleBackColor = true;
            this.Abecedario.Click += new System.EventHandler(this.Abecedario_Click);
            // 
            // Empezaratraducir
            // 
            this.Empezaratraducir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Empezaratraducir.BackgroundImage")));
            this.Empezaratraducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Empezaratraducir.Location = new System.Drawing.Point(486, 350);
            this.Empezaratraducir.Name = "Empezaratraducir";
            this.Empezaratraducir.Size = new System.Drawing.Size(451, 75);
            this.Empezaratraducir.TabIndex = 2;
            this.Empezaratraducir.UseVisualStyleBackColor = true;
            this.Empezaratraducir.Click += new System.EventHandler(this.Empezaratraducir_Click);
            // 
            // SingsTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.Abecedario);
            this.Controls.Add(this.Empezaratraducir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SingsTranslator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Signs Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SingsTranslator_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Abecedario;
        internal System.Windows.Forms.Button Empezaratraducir;

    }
}

