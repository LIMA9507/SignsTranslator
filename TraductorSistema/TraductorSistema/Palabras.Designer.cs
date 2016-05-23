namespace SignsTranslator
{
    partial class Palabras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Palabras));
            this.buscar = new System.Windows.Forms.TextBox();
            this.lpalabras = new System.Windows.Forms.ListBox();
            this.palabrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traductorDataSet = new SignsTranslator.TraductorDataSet();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.palabrasTableAdapter = new SignsTranslator.TraductorDataSetTableAdapters.PalabrasTableAdapter();
            this.traductorDataSet1 = new SignsTranslator.TraductorDataSet1();
            this.palabrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.palabrasTableAdapter1 = new SignsTranslator.TraductorDataSet1TableAdapters.PalabrasTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abecedarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traductorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traductorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(130, 132);
            this.buscar.MaxLength = 50;
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(269, 30);
            this.buscar.TabIndex = 0;
            this.buscar.TextChanged += new System.EventHandler(this.palabra_TextChanged);
            // 
            // lpalabras
            // 
            this.lpalabras.DataSource = this.palabrasBindingSource;
            this.lpalabras.DisplayMember = "palabra";
            this.lpalabras.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lpalabras.FormattingEnabled = true;
            this.lpalabras.ItemHeight = 23;
            this.lpalabras.Location = new System.Drawing.Point(130, 185);
            this.lpalabras.Name = "lpalabras";
            this.lpalabras.Size = new System.Drawing.Size(269, 372);
            this.lpalabras.TabIndex = 1;
            this.lpalabras.ValueMember = "palabra";
            this.lpalabras.SelectedIndexChanged += new System.EventHandler(this.lpalabras_SelectedIndexChanged);
            // 
            // palabrasBindingSource
            // 
            this.palabrasBindingSource.DataMember = "Palabras";
            this.palabrasBindingSource.DataSource = this.traductorDataSet;
            // 
            // traductorDataSet
            // 
            this.traductorDataSet.DataSetName = "TraductorDataSet";
            this.traductorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.Color.White;
            this.imagen.Location = new System.Drawing.Point(486, 174);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(829, 403);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // palabrasTableAdapter
            // 
            this.palabrasTableAdapter.ClearBeforeFill = true;
            // 
            // traductorDataSet1
            // 
            this.traductorDataSet1.DataSetName = "TraductorDataSet1";
            this.traductorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // palabrasBindingSource1
            // 
            this.palabrasBindingSource1.DataMember = "Palabras";
            this.palabrasBindingSource1.DataSource = this.traductorDataSet1;
            // 
            // palabrasTableAdapter1
            // 
            this.palabrasTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(231)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.traductorToolStripMenuItem,
            this.abecedarioToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.lOGINToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 35);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(74, 31);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click_1);
            // 
            // traductorToolStripMenuItem
            // 
            this.traductorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.traductorToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traductorToolStripMenuItem.Name = "traductorToolStripMenuItem";
            this.traductorToolStripMenuItem.Size = new System.Drawing.Size(115, 31);
            this.traductorToolStripMenuItem.Text = "Traductor";
            this.traductorToolStripMenuItem.Click += new System.EventHandler(this.traductorToolStripMenuItem_Click);
            // 
            // abecedarioToolStripMenuItem
            // 
            this.abecedarioToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.abecedarioToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abecedarioToolStripMenuItem.Name = "abecedarioToolStripMenuItem";
            this.abecedarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.abecedarioToolStripMenuItem.Size = new System.Drawing.Size(124, 31);
            this.abecedarioToolStripMenuItem.Text = "Abecedario";
            this.abecedarioToolStripMenuItem.Click += new System.EventHandler(this.abecedarioToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(173, 31);
            this.salirToolStripMenuItem.Text = "Cerrar aplicación";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem1
            // 
            this.lOGINToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lOGINToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(228)))), ((int)(((byte)(204)))));
            this.lOGINToolStripMenuItem1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGINToolStripMenuItem1.Name = "lOGINToolStripMenuItem1";
            this.lOGINToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.lOGINToolStripMenuItem1.Size = new System.Drawing.Size(151, 31);
            this.lOGINToolStripMenuItem1.Text = "Administrador";
            this.lOGINToolStripMenuItem1.Click += new System.EventHandler(this.lOGINToolStripMenuItem1_Click_1);
            // 
            // Palabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.lpalabras);
            this.Controls.Add(this.buscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Palabras";
            this.Text = "Signs Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Palabras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traductorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traductorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palabrasBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox buscar;
        private System.Windows.Forms.ListBox lpalabras;
        private System.Windows.Forms.PictureBox imagen;
        private TraductorDataSet traductorDataSet;
        private System.Windows.Forms.BindingSource palabrasBindingSource;
        private TraductorDataSetTableAdapters.PalabrasTableAdapter palabrasTableAdapter;
        private TraductorDataSet1 traductorDataSet1;
        private System.Windows.Forms.BindingSource palabrasBindingSource1;
        private TraductorDataSet1TableAdapters.PalabrasTableAdapter palabrasTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abecedarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem1;
    }
}