namespace TraductorSistema
{
    partial class Traductor_señas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Traductor_señas));
            this.Salir = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Salir.BackgroundImage")));
            this.Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Salir.Location = new System.Drawing.Point(755, 223);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(94, 37);
            this.Salir.TabIndex = 5;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Limpiar.BackgroundImage")));
            this.Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Limpiar.Location = new System.Drawing.Point(511, 223);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(123, 37);
            this.Limpiar.TabIndex = 4;
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Regresar
            // 
            this.Regresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Regresar.BackgroundImage")));
            this.Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Regresar.Location = new System.Drawing.Point(644, 223);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(105, 37);
            this.Regresar.TabIndex = 3;
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d"});
            this.listBox1.Location = new System.Drawing.Point(140, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 134);
            this.listBox1.TabIndex = 6;
            // 
            // Traductor_señas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 318);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Regresar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Traductor_señas";
            this.Text = "Traductor_señas";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Salir;
        internal System.Windows.Forms.Button Limpiar;
        internal System.Windows.Forms.Button Regresar;
        private System.Windows.Forms.ListBox listBox1;
    }
}