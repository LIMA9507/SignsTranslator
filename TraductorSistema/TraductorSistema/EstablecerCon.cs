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
    public partial class EstablecerCon : Form
    {
        SqlConnection con;
        public EstablecerCon()
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

        private void EstablecerCon_Load(object sender, EventArgs e)
        {
     
                   
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            string contra1 = contraseña1.Text;
            string contra2 = contraseña2.Text;
            
            if (contra1 == contra2 && contra1 != "" && contra2 !="" )
            {
                if (contra1.Length > 8)
                {
                    try
                    {
                        string qry = "update login set contraseña='" + contra2 + "' where idLog=1";
                        // Inicializa el objeto SqlCommand
                        SqlCommand SqlCom = new SqlCommand(qry, con);


                        // Abre la conexión y ejecutar el query
                        con.Open();
                        SqlDataReader rdr = SqlCom.ExecuteReader();



                        MessageBox.Show("Contraseña Restablecida con exito");
                        this.Close();
                        Login llamada = new Login();
                        llamada.Show();


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
                else
                {
                    MessageBox.Show("La contraseña debe contener minimo 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
                }
            }
            else
            {

                MessageBox.Show("las contraseñas no coinciden o campo en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contraseña1.Clear();
                contraseña2.Clear();



            }
           
        }
    }
}
