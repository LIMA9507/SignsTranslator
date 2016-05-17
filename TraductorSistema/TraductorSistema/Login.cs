using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TraductorSistema
{
    public partial class Login : Form
    {
        
        SqlConnection con;
        public Login()
        {
            InitializeComponent();
            CrearConexion();
        }
        void CrearConexion()
        {
            SqlConnectionStringBuilder cs = new SqlConnectionStringBuilder();

            cs.DataSource = @"AlbertoMexia-PC";
            cs.InitialCatalog = "Traductor";
            cs.IntegratedSecurity = true;



            con = new SqlConnection(cs.ConnectionString);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lOGINToolStripMenuItem1.Enabled = false;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string usu = usuario.Text;
            string contra = contraseña.Text;
            string qry = "select usuario,contraseña from Login where idLog=1";
            try
            {
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);


                // Abre la conexión y ejecutar el query
                con.Open();
                SqlDataReader rdr = SqlCom.ExecuteReader();

                if (rdr.Read())
                {
                    if (usu != "" && contra != "")
                    {
                        // Obtiene los resultados de la búsqueda
                        if (usu == rdr.GetString(0) && contra == rdr.GetString(1))
                        {

                            SignsTranslator.Agregar llamada = new SignsTranslator.Agregar();
                            llamada.Show();
                            Limpiar();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("El nombre de usuario o contraseña son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            Limpiar();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se admiten campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                           
                    }
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la base de datos para abecedario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            finally
            {
                // Cerrar la conexión si esta se encuentra abierta
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        void Limpiar()
        {
            
            usuario.Clear();
            contraseña.Clear();

        }

        private void recuperar_Click(object sender, EventArgs e)
        {
            RecuperarCon llamada = new RecuperarCon();
            llamada.Show();
            this.Close();
        }

       /* private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }*/

       /* private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

       /* private void traductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();
            llamada.Show();
            this.Close();
        }*/

       /* private void abecedarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abecedario llamada = new Abecedario();
            llamada.Show();
            this.Close();
        }*/

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lOGINToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void abecedarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Abecedario llamada = new Abecedario();
            llamada.Show();
            this.Close();
        }

        private void traductorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();
            llamada.Show();
            this.Close();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
