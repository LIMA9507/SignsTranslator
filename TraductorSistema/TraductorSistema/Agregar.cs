using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Drawing.Imaging;
//using Microsoft.VisualBasic;

namespace SignsTranslator
{
    public partial class Agregar : Form
    {
        SqlConnection con;
        SqlCommand cmd;
       // SqlDataAdapter adapter;
       // DataSet ds; int rno = 0;
        MemoryStream ms;
        //byte[] photo_aray;
 

        public Agregar()
        {
            
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=AlbertoMexia-PC;Initial Catalog=Traductor;Integrated Security=True");
           
        }

        private void palabra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            string nuevaPalabra = Nupalabra.Text;
            if (Nupalabra.Text != "" && visualizar.Image != null)
            {
                if (Nupalabra.Text.Length >= 2 && Nupalabra.Text.Length <= 40)
                {
                   /* string qry = "Select palabra from Palabras where palabra = '" + Nupalabra.Text + "'";
                    cmd = new SqlCommand(qry, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    string palabra = rdr.GetString(0);
                    con.Close();

                    if (nuevaPalabra != palabra)
                    {
                       */
                    
                        cmd = new SqlCommand("insert into Palabras(Palabra,Ruta) values('" + Nupalabra.Text + "' " + ",@photo)", con);
                        conv_photo();
                        con.Open();
                        int n = cmd.ExecuteNonQuery();
                        con.Close();
                        if (n > 0)
                        {
                            string nuevapa = Nupalabra.Text;
                            //Agregar palabra y limpiar campos
                            MessageBox.Show("La palabra " + nuevapa + " fue guardada con exito");

                            //SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();

                            //(ListBox)llamada.Controls.["lpalabras"]. = nuevapa;


                            Nupalabra.Clear();
                            visualizar.Image = null;
                            visualizar.Invalidate();
                            const string mensaje = "¿Desea agregar otra imagen?";
                            const string encabezado = "Advertencia";
                            var result = MessageBox.Show(mensaje, encabezado,
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                            // If the no button was pressed ...
                            if (result == DialogResult.No)
                            {
                                // cancel the closure of the form.
                                this.Close();
                            }

                        }
                        else
                            MessageBox.Show("Algo salio mal en la seleccion de la imagen verefique la imagen ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                   // }
                    //else
                    //{
                      //  MessageBox.Show("ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //}
                }
                else
                {
                    MessageBox.Show("El tamaño de la palabra debe ser de minimo 2 caracteres y maximo de 40 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("Algun campo esta vacio ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

            }
        void conv_photo()
        {
            //converting photo to binary data
            if (visualizar.Image != null)
            {



                ms = new MemoryStream();
                visualizar.Image.Save(ms, ImageFormat.Jpeg);
                byte[] photo_aray = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(photo_aray, 0, photo_aray.Length);
                cmd.Parameters.AddWithValue("@photo", photo_aray);
            }
        }

       

        private void palabra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Nupalabra.Text.Length == 0)
                e.KeyChar = e.KeyChar.ToString().ToUpper().ToCharArray()[0];
            else if (Nupalabra.Text.Length > 0)
                e.KeyChar = e.KeyChar.ToString().ToLower().ToCharArray()[0];
        }

        private void examinar_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpeg|*.jpg|bmp|*.bmp|all files|*.*";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                visualizar.Image = Image.FromFile(openFileDialog1.FileName);
            } 
        }

        private void palabra_TextChanged_1(object sender, EventArgs e)
        {

           
        }
        
      
    }
}
