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
using System.Text.RegularExpressions;

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
            string usu = usuario.Text;

            string formato = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$&*]).{8,15}$";
            Regex r = new Regex(formato);

            if (contra1 == contra2 && contra1 != "" && contra2 !="" )
            {
                if (contra1.Length == 8)
                {
                     if (r.IsMatch(contra1)) {
                    
                  
                        try
                        {
                            string qry = "update loginu set contraseña='" + contra2 + "' where usuario='" + usu + "'";
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
                            MessageBox.Show("No se encontro la base de datos para abecedario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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

                         MessageBox.Show("Debe respetar la nomenclatura para las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        
                     }
                }
                else
                {
                    MessageBox.Show("La contraseña debe ser de 8 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {

                MessageBox.Show("las contraseñas no coinciden o campo en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contraseña1.Clear();
                contraseña2.Clear();



            }
            
                
        }

        private void contraseña1_Validating(object sender, CancelEventArgs e)
        {

           // if (contraseña1.Text != String.Empty)
            //{
            /*
                bool contNum = false;
                bool contString = false;
                foreach (char item in contraseña1.Text)
                {
                    if (Char.IsNumber(item))
                    {
                        contNum = true;
                    }
                    else if (Char.IsLetter(item))
                    {
                        contString = true;
                    }
                }
                if (!contString || !contNum)
                {
                    MessageBox.Show("La contraseña debe contener minimo 1 numero y 1 letra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }*/
          //  }
           // else
           // {
                //msj no puede dejar en blanco etc etc
           // }
        
        }
       
       
    }
}
