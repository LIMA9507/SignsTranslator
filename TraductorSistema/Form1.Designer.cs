namespace TraductorSistema
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Abecedario = new System.Windows.Forms.Button();
            this.Empezaratraducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Abecedario
            // 
            this.Abecedario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Abecedario.BackgroundImage")));
            this.Abecedario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Abecedario.Location = new System.Drawing.Point(378, 218);
            this.Abecedario.Name = "Abecedario";
            this.Abecedario.Size = new System.Drawing.Size(178, 52);
            this.Abecedario.TabIndex = 3;
            this.Abecedario.UseVisualStyleBackColor = true;
            this.Abecedario.Click += new System.EventHandler(this.Abecedario_Click);
            // 
            // Empezaratraducir
            // 
            this.Empezaratraducir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Empezaratraducir.BackgroundImage")));
            this.Empezaratraducir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Empezaratraducir.Location = new System.Drawing.Point(318, 139);
            this.Empezaratraducir.Name = "Empezaratraducir";
            this.Empezaratraducir.Size = new System.Drawing.Size(302, 55);
            this.Empezaratraducir.TabIndex = 2;
            this.Empezaratraducir.UseVisualStyleBackColor = true;
            this.Empezaratraducir.Click += new System.EventHandler(this.Empezaratraducir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(903, 341);
            this.Controls.Add(this.Abecedario);
            this.Controls.Add(this.Empezaratraducir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Abecedario;
        internal System.Windows.Forms.Button Empezaratraducir;

    }
}

