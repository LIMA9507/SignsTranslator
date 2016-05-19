namespace SignsTranslator
{
    partial class AgregarUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuarios));
            this.nusuario = new System.Windows.Forms.TextBox();
            this.contraseña1 = new System.Windows.Forms.TextBox();
            this.contraseña2 = new System.Windows.Forms.TextBox();
            this.palabrasec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nusuario
            // 
            this.nusuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nusuario.Location = new System.Drawing.Point(894, 226);
            this.nusuario.MaxLength = 20;
            this.nusuario.Name = "nusuario";
            this.nusuario.Size = new System.Drawing.Size(250, 30);
            this.nusuario.TabIndex = 0;
            // 
            // contraseña1
            // 
            this.contraseña1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.contraseña1.Location = new System.Drawing.Point(894, 321);
            this.contraseña1.MaxLength = 8;
            this.contraseña1.Name = "contraseña1";
            this.contraseña1.PasswordChar = '*';
            this.contraseña1.Size = new System.Drawing.Size(250, 30);
            this.contraseña1.TabIndex = 1;
            // 
            // contraseña2
            // 
            this.contraseña2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.contraseña2.Location = new System.Drawing.Point(894, 407);
            this.contraseña2.MaxLength = 8;
            this.contraseña2.Name = "contraseña2";
            this.contraseña2.PasswordChar = '*';
            this.contraseña2.Size = new System.Drawing.Size(250, 30);
            this.contraseña2.TabIndex = 2;
            // 
            // palabrasec
            // 
            this.palabrasec.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.palabrasec.Location = new System.Drawing.Point(894, 498);
            this.palabrasec.MaxLength = 8;
            this.palabrasec.Name = "palabrasec";
            this.palabrasec.Size = new System.Drawing.Size(250, 30);
            this.palabrasec.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(288, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 45);
            this.label2.TabIndex = 6;
            this.label2.Text = "Palabra Clave";
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.White;
            this.agregar.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(820, 572);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(172, 48);
            this.agregar.TabIndex = 7;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(890, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "* Ej. Ejemp01*";
            // 
            // AgregarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.palabrasec);
            this.Controls.Add(this.contraseña2);
            this.Controls.Add(this.contraseña1);
            this.Controls.Add(this.nusuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarUsuarios";
            this.Text = "Signs Translator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AgregarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nusuario;
        private System.Windows.Forms.TextBox contraseña1;
        private System.Windows.Forms.TextBox contraseña2;
        private System.Windows.Forms.TextBox palabrasec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label3;
    }
}