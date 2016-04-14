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
        public void asignacionLetra(char var)
        {
            {
                
                string qry = "select RUTA from Señas where descripcion='"+ var + "' and Tipo=1";
                try
                {
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


                        Abecedario_Resultado FrmObjR = new Abecedario_Resultado();
                        FrmObjR.PictureBox1.Image = Image.FromFile(rdr.GetString(0));
                        FrmObjR.ShowDialog();

                        text = string.Empty;

                    }
                    else
                    {
                        MessageBox.Show("No existe registro con la " + var, "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Cerrar la conexión si esta se encuentra abierta
                    if (con.State == ConnectionState.Open)
                        con.Close();
                }
            }
        }

        private void A_Click(object sender, EventArgs e)
        {
            char var = 'A';
            asignacionLetra(var);
        }

        private void B_Click(object sender, EventArgs e)
        {
            char var = 'B';
            asignacionLetra(var);
        }

        private void C_Click(object sender, EventArgs e)
        {
            char var = 'C';
            asignacionLetra(var);
        }

        private void D_Click(object sender, EventArgs e)
        {
                char var = 'D';
                asignacionLetra(var);   
        }

        private void E_Click(object sender, EventArgs e)
        {
            char var = 'E';
            asignacionLetra(var);
        }

        private void F_Click(object sender, EventArgs e)
            {
                char var = 'F';
                asignacionLetra(var);
            }
        
        private void G_Click(object sender, EventArgs e)
        {
            char var = 'G';
            asignacionLetra(var);
        }

        private void H_Click(object sender, EventArgs e)
        {
            char var = 'H';
            asignacionLetra(var);
        }

        private void I_Click(object sender, EventArgs e)
        {
            char var = 'I';
            asignacionLetra(var);
        }

        private void J_Click(object sender, EventArgs e)
        {
            char var = 'J';
            asignacionLetra(var);
        }

        private void K_Click(object sender, EventArgs e)
        {
            char var = 'K';
            asignacionLetra(var);
        }
       

        private void L_Click(object sender, EventArgs e)
        {
            char var = 'L';
            asignacionLetra(var);
        }

        private void U_Click(object sender, EventArgs e)
        {
            char var = 'M';
            asignacionLetra(var);
        }

        private void N_Click(object sender, EventArgs e)
        {
            char var = 'N';
            asignacionLetra(var);
        }

        private void Ñ_Click(object sender, EventArgs e)
        {
            char var = 'Ñ';
            asignacionLetra(var);
        }

        private void O_Click(object sender, EventArgs e)
        {
            char var = 'O';
            asignacionLetra(var);
        }

        private void P_Click(object sender, EventArgs e)
        {
            char var = 'P';
            asignacionLetra(var);
        }

        private void Q_Click(object sender, EventArgs e)
        {
            char var = 'Q';
            asignacionLetra(var);
        }

        private void R_Click(object sender, EventArgs e)
        {
            char var = 'R';
            asignacionLetra(var);
        }

        private void S_Click(object sender, EventArgs e)
        {
            char var = 'S';
            asignacionLetra(var);
        }

        private void T_Click(object sender, EventArgs e)
        {
            char var = 'T';
            asignacionLetra(var);
        }

        private void M_Click(object sender, EventArgs e)
        {
            char var = 'U';
            asignacionLetra(var);
        }

        private void V_Click(object sender, EventArgs e)
        {
            char var = 'V';
            asignacionLetra(var);
        }

        private void W_Click(object sender, EventArgs e)
        {
            char var = 'W';
            asignacionLetra(var);
        }

        private void X_Click(object sender, EventArgs e)
        {
            char var = 'X';
            asignacionLetra(var);
        }

        private void Y_Click(object sender, EventArgs e)
        {
            char var = 'Y';
            asignacionLetra(var);
        }

        private void Z_Click(object sender, EventArgs e)
        {
            char var = 'Z';
            asignacionLetra(var);
        }

        private void Abecedario_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }  
    }

}

