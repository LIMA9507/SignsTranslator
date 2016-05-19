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
            try
            {
                //con.Open();
                string qry = "select contraseña from Loginu where usuario ='" + usu + "'";

                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);


                // Abre la conexión y ejecutar el query
                con.Open();
                SqlDataReader rdr = SqlCom.ExecuteReader();


               
                    if (usu != "" && contra != "")
                    {
                        if(rdr.HasRows){

                        if (rdr.Read())
                        {

                         
                            if (contra == rdr.GetString(0))
                            {

                                SignsTranslator.Agregar llamada = new SignsTranslator.Agregar();
                                llamada.Show();
                                Limpiar();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("La contraseña es incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Limpiar();
                            }
                         

                        }
                    }else{
                        MessageBox.Show("El usuario " + usu + " no se encuentra en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Limpiar();
    
                    }
                    }
                    else
                    {
                        MessageBox.Show("No se admiten campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }


                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

       /* private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }*/

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
