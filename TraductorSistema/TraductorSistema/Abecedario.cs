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
using System.IO;


namespace TraductorSistema
{
    public partial class Abecedario : Form
    {
        SqlConnection con;

        public Abecedario()
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

        public void asignarLetra(char var)
        {
            /*var filePath= @"C:\SignsTranslator\TraductorSistema\TraductorSistema\Resources\abecedario\" + var + ".jpg";
            
                    Abecedario_Resultado FrmObjR = new Abecedario_Resultado();
                    FrmObjR.PictureBox1.Image = Image.FromFile(filePath);
                    FrmObjR.Show();*/

           
            try
            {
                string qry = "select ruta from Abecedario where nombre='" + var + "'";
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);


                // Abre la conexión y ejecutar el query
                con.Open();
                SqlDataReader rdr = SqlCom.ExecuteReader();

                if (rdr.Read())
                {
                    // Obtiene los resultados de la búsqueda
                    string text;

                    text = rdr.GetString(0);
                    string currentDir = Environment.CurrentDirectory;
                    DirectoryInfo directorio = new DirectoryInfo(
                        Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + text)));
                    Abecedario_Resultado FrmObjR = new Abecedario_Resultado();
                    FrmObjR.PictureBox1.Image = Image.FromFile(directorio.ToString());
                    FrmObjR.Show();

                    text = string.Empty;


                }
                else
                {
                    MessageBox.Show("No existe la letra " + var, "Búsqueda palabras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro la base de datos para abecedario","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            finally
            {
                // Cerrar la conexión si esta se encuentra abierta
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
                  
        }
        private void A_Click(object sender, EventArgs e)
        {
            char var = 'a';
            asignarLetra(var);
        }

        private void B_Click(object sender, EventArgs e)
        {
            char var = 'B';
            asignarLetra(var);
        }

        private void P_Click(object sender, EventArgs e)
        {
            char var = 'P';
            asignarLetra(var);
        }

        private void C_Click(object sender, EventArgs e)
        {
            char var = 'C';
            asignarLetra(var);
        }

        private void D_Click(object sender, EventArgs e)
        {
            char var = 'D';
            asignarLetra(var);
        }

        private void E_Click(object sender, EventArgs e)
        {
            char var = 'E';
            asignarLetra(var);
        }

        private void F_Click(object sender, EventArgs e)
        {
            char var = 'F';
            asignarLetra(var);
        }

        private void G_Click(object sender, EventArgs e)
        {
            char var = 'G';
            asignarLetra(var);
        }

        private void H_Click(object sender, EventArgs e)
        {
            char var = 'H';
            asignarLetra(var);
        }

        private void I_Click(object sender, EventArgs e)
        {
            char var = 'I';
            asignarLetra(var);
        }

        private void J_Click(object sender, EventArgs e)
        {
            char var = 'J';
            asignarLetra(var);
        }

        private void K_Click(object sender, EventArgs e)
        {
            char var = 'K';
            asignarLetra(var);
        }

        private void L_Click(object sender, EventArgs e)
        {
            char var = 'L';
            asignarLetra(var);
        }

        private void U_Click(object sender, EventArgs e)
        {
            char var = 'M';
            asignarLetra(var);
        }

        private void N_Click(object sender, EventArgs e)
        {
            char var = 'N';
            asignarLetra(var);
        }

        private void Ñ_Click(object sender, EventArgs e)
        {
            char var = 'Ñ';
            asignarLetra(var);
        }

        private void O_Click(object sender, EventArgs e)
        {
            char var = 'O';
            asignarLetra(var);
        }

        private void Q_Click(object sender, EventArgs e)
        {
            char var = 'Q';
            asignarLetra(var);
        }

        private void R_Click(object sender, EventArgs e)
        {
            char var = 'R';
            asignarLetra(var);
        }

        private void S_Click(object sender, EventArgs e)
        {
            char var = 'S';
            asignarLetra(var);
        }

        private void T_Click(object sender, EventArgs e)
        {
            char var = 'T';
            asignarLetra(var);
        }

        private void M_Click(object sender, EventArgs e)
        {
            char var = 'U';
            asignarLetra(var);
        }

        private void V_Click(object sender, EventArgs e)
        {
            char var = 'V';
            asignarLetra(var);
        }

        private void W_Click(object sender, EventArgs e)
        {
            char var = 'W';
            asignarLetra(var);
        }

        private void X_Click(object sender, EventArgs e)
        {
            char var = 'X';
            asignarLetra(var);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            char var = 'Y';
            asignarLetra(var);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            char var = 'Z';
            asignarLetra(var);
        }

       /* private void Regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

        /*private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void Abecedario_Load(object sender, EventArgs e)
        {
            abecedarioToolStripMenuItem.Enabled = false;

           

        }

       /* private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

      /*  private void traductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();
            llamada.Show();
            this.Close();
        }*/

       /* private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login llamada = new Login();
            llamada.Show();
            this.Close();
        }
        */
       /* private void traductorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();
            llamada.Show();
            this.Close();
        }*/

       /* private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }*/

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void traductorToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();
            llamada.Show();
            this.Close();
        }

        private void lOGINToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Login llamada = new Login();
            llamada.Show();
            this.Close();
        }  
    }

}

