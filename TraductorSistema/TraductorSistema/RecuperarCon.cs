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
    public partial class RecuperarCon : Form
    {
        SqlConnection con;
        public RecuperarCon()
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

        private void RecuperarCon_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palabraCla = palcla.Text;

           
            string qry = "select palabraSec from Login where idLog=1";
            try
            {
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);


                // Abre la conexión y ejecutar el query
                con.Open();
                SqlDataReader rdr = SqlCom.ExecuteReader();

                if (rdr.Read())
                {
                    if (palabraCla != "")
                    {
                        // Obtiene los resultados de la búsqueda
                        if (palabraCla == rdr.GetString(0))
                        {
                            EstablecerCon llamada = new EstablecerCon();
                            llamada.Show();
                            Limpiar();
                            this.Close();
                            
                        }
                        else
                        {
                            MessageBox.Show("La palabra clave para recuperar la contraseña no es correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            palcla.Clear();


        }
    }
}
