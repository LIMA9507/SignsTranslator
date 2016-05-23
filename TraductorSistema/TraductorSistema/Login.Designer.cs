namespace TraductorSistema
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.Aceptar = new System.Windows.Forms.Button();
            this.recuperar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abecedarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuario
            // 
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(777, 338);
            this.usuario.MaxLength = 20;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(227, 26);
            this.usuario.TabIndex = 0;
            this.usuario.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(777, 447);
            this.contraseña.MaxLength = 15;
            this.contraseña.Name = "contraseña";
            this.contraseña.PasswordChar = '*';
            this.contraseña.Size = new System.Drawing.Size(227, 26);
            this.contraseña.TabIndex = 1;
            // 
            // Aceptar
            // 
            this.Aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Aceptar.BackgroundImage")));
            this.Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Aceptar.Location = new System.Drawing.Point(1011, 477);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(195, 67);
            this.Aceptar.TabIndex = 2;
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // recuperar
            // 
            this.recuperar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recuperar.BackgroundImage")));
            this.recuperar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.recuperar.ForeColor = System.Drawing.Color.LightCyan;
            this.recuperar.Location = new System.Drawing.Point(1047, 642);
            this.recuperar.Name = "recuperar";
            this.recuperar.Size = new System.Drawing.Size(315, 79);
            this.recuperar.TabIndex = 3;
            this.recuperar.UseVisualStyleBackColor = true;
            this.recuperar.Click += new System.EventHandler(this.recuperar_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1362, 35);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.traductorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.traductorToolStripMenuItem.Size = new System.Drawing.Size(115, 31);
            this.traductorToolStripMenuItem.Text = "Traductor";
            this.traductorToolStripMenuItem.Click += new System.EventHandler(this.traductorToolStripMenuItem_Click_1);
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
            this.lOGINToolStripMenuItem1.Size = new System.Drawing.Size(151, 31);
            this.lOGINToolStripMenuItem1.Text = "Administrador";
            this.lOGINToolStripMenuItem1.Click += new System.EventHandler(this.lOGINToolStripMenuItem1_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.recuperar);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Signs Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Button recuperar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abecedarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem1;
    }
}