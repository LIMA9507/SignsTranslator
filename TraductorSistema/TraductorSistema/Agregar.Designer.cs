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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abecedarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.traductorToolStripMenuItem,
            this.abecedarioToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.lOGINToolStripMenuItem1,
            this.agregarUsuariosToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.inicioToolStripMenuItem, "inicioToolStripMenuItem");
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // traductorToolStripMenuItem
            // 
            this.traductorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.traductorToolStripMenuItem, "traductorToolStripMenuItem");
            this.traductorToolStripMenuItem.Name = "traductorToolStripMenuItem";
            this.traductorToolStripMenuItem.Click += new System.EventHandler(this.traductorToolStripMenuItem_Click);
            // 
            // abecedarioToolStripMenuItem
            // 
            this.abecedarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.abecedarioToolStripMenuItem, "abecedarioToolStripMenuItem");
            this.abecedarioToolStripMenuItem.Name = "abecedarioToolStripMenuItem";
            this.abecedarioToolStripMenuItem.Click += new System.EventHandler(this.abecedarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.salirToolStripMenuItem, "salirToolStripMenuItem");
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem1
            // 
            this.lOGINToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lOGINToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.lOGINToolStripMenuItem1, "lOGINToolStripMenuItem1");
            this.lOGINToolStripMenuItem1.Name = "lOGINToolStripMenuItem1";
            this.lOGINToolStripMenuItem1.Click += new System.EventHandler(this.lOGINToolStripMenuItem1_Click);
            // 
            // agregarUsuariosToolStripMenuItem
            // 
            this.agregarUsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.agregarUsuariosToolStripMenuItem, "agregarUsuariosToolStripMenuItem");
            this.agregarUsuariosToolStripMenuItem.Name = "agregarUsuariosToolStripMenuItem";
            this.agregarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.agregarUsuariosToolStripMenuItem_Click);
            // 
            // Agregar
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.visualizar);
            this.Controls.Add(this.Nupalabra);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.examinar);
            this.MaximizeBox = false;
            this.Name = "Agregar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visualizar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.TextBox Nupalabra;
        private System.Windows.Forms.Button examinar;
        private System.Windows.Forms.PictureBox visualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abecedarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarUsuariosToolStripMenuItem;
    }
}