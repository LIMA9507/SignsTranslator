using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignsTranslator
{
    public partial class AgregarUsuarios : Form
    {
        SqlConnection con;
        SqlConnection con1;
        public AgregarUsuarios()
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
            con1 = new SqlConnection(cs.ConnectionString);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            
        }
        void limpiar()
        {
            nusuario.Clear();
            contraseña1.Clear();
            contraseña2.Clear();
            palabrasec.Clear();
        }

      /*  private void AgregarUsuarios_Load(object sender, EventArgs e)
        {

        }*/

        private void agregar_Click_1(object sender, EventArgs e)
        {
            string usuario = nusuario.Text;
            string contra1 = contraseña1.Text;
            string contra2 = contraseña2.Text;
            string palabras = palabrasec.Text;
            string formato = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$&*]).{8,15}$";
            //string formato = "^[a-zA-Z][!@#$&*]{3,14}$";
          //  string formato1 = "^(?=.*[a-zA-Z0-9!@#$&*]{8,15})$";
            Regex r = new Regex(formato);



            string qry1 = "select * from Loginu where usuario = '" + usuario + "'";

            // Inicializa el objeto SqlCommand
            SqlCommand SqlCom1 = new SqlCommand(qry1, con1);


            // Abre la conexión y ejecutar el query
            con1.Open();
            SqlDataReader rdr1 = SqlCom1.ExecuteReader();

            if (rdr1.HasRows)
            {
                MessageBox.Show("Este usuario ya existe en la  base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                con1.Close();
            }
            else
            {
                if (usuario != "" && contra1 != "" && contra2 != "" && palabras != "")
                {

                    if (contra1 == contra2)
                    {
                        if (r.IsMatch(contra1) )
                        {
                            try
                            {
                                string qry = "insert into loginu (usuario,contraseña,palabraSec) values ('" + usuario + "', '" + contra2 + "','" + palabras + "')";

                                // Inicializa el objeto SqlCommand
                                SqlCommand SqlCom = new SqlCommand(qry, con);


                                // Abre la conexión y ejecutar el query
                                con.Open();
                                SqlDataReader rdr = SqlCom.ExecuteReader();



                                MessageBox.Show("Usuario dado de alta con exito");
                                limpiar();
                                const string mensaje = "¿Desea dar de alta un nuevo usuario?";
                                const string encabezado = "Advertencia";
                                var result = MessageBox.Show(mensaje, encabezado,
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Question);

                                // If the no button was pressed ...
                                if (result == DialogResult.No)
                                {
                                    // cancel the closure of the form.
                                    this.Close();
                                    TraductorSistema.Login llamada = new TraductorSistema.Login();
                                    llamada.Show();
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
                        else
                        {

                            MessageBox.Show("Debe respetar la nomenclatura para las contraseñas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        }
                    }

                    else
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    MessageBox.Show("No se admiten campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                /*}
                else
                {
                    MessageBox.Show("El usuario que desea agregar ya existe en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }*/
                con1.Close();
            }
        }

        private void AgregarUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
