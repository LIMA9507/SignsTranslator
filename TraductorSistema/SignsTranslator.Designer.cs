namespace TraductorSistema
{
    partial class SignsTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignsTranslator));
            this.Abecedario = new System.Windows.Forms.Button();
            this.Empezaratraducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Abecedario
            // 
            this.Abecedario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Abecedario.BackgroundImage")));
            this.Abecedario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Abecedario.Location = new System.Drawing.Point(455, 266);
            this.Abecedario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Abecedario.Name = "Abecedario";
            this.Abecedario.Size = new System.Drawing.Size(238, 64);
            this.Abecedario.TabIndex = 3;
            this.Abecedario.UseVisualStyleBackColor = true;
            this.Abecedario.Click += new System.EventHandler(this.Abecedario_Click);
            // 
            // Empezaratraducir
            // 
            this.Empezaratraducir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Empezaratraducir.BackgroundImage")));
            this.Empezaratraducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Empezaratraducir.Location = new System.Drawing.Point(359, 178);
            this.Empezaratraducir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Empezaratraducir.Name = "Empezaratraducir";
            this.Empezaratraducir.Size = new System.Drawing.Size(402, 68);
            this.Empezaratraducir.TabIndex = 2;
            this.Empezaratraducir.UseVisualStyleBackColor = true;
            this.Empezaratraducir.Click += new System.EventHandler(this.Empezaratraducir_Click);
            // 
            // SignsTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1090, 420);
            this.Controls.Add(this.Abecedario);
            this.Controls.Add(this.Empezaratraducir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SignsTranslator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Signs Translator";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Abecedario;
        internal System.Windows.Forms.Button Empezaratraducir;

    }
}

