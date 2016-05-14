namespace SignsTranslator
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.aceptar = new System.Windows.Forms.Button();
            this.Nupalabra = new System.Windows.Forms.TextBox();
            this.examinar = new System.Windows.Forms.Button();
            this.visualizar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            resources.ApplyResources(this.aceptar, "aceptar");
            this.aceptar.Name = "aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // Nupalabra
            // 
            resources.ApplyResources(this.Nupalabra, "Nupalabra");
            this.Nupalabra.Name = "Nupalabra";
            this.Nupalabra.TextChanged += new System.EventHandler(this.palabra_TextChanged_1);
            this.Nupalabra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.palabra_KeyPress);
            // 
            // examinar
            // 
            resources.ApplyResources(this.examinar, "examinar");
            this.examinar.Name = "examinar";
            this.examinar.UseVisualStyleBackColor = true;
            this.examinar.Click += new System.EventHandler(this.examinar_Click);
            // 
            // visualizar
            // 
            resources.ApplyResources(this.visualizar, "visualizar");
            this.visualizar.Name = "visualizar";
            this.visualizar.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Agregar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.Nupalabra);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.examinar);
            this.MaximizeBox = false;
            this.Name = "Agregar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox Nupalabra;
        private System.Windows.Forms.Button examinar;
        private System.Windows.Forms.PictureBox visualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}