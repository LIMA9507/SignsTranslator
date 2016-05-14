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

namespace SignsTranslator
{
    public partial class Palabras : Form
    {
        SqlConnection con;
        public Palabras()
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

        private void palabra_TextChanged(object sender, EventArgs e)
        {
            string myString = buscar.Text;
            // Search starting from index -1:
            int index = lpalabras.FindString(myString, -1);
            if (index != -1)
            {
                // Select the found item:
                lpalabras.SetSelected(index, true);

            }
        }

       /* private void limpiar_Click(object sender, EventArgs e)
        {
            imagen.Image = null;
            imagen.Invalidate();
        }*/

        private void regresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      /*  private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }*/

        private void Palabras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'traductorDataSet1.Palabras' table. You can move, or remove it, as needed.
            this.palabrasTableAdapter1.Fill(this.traductorDataSet1.Palabras);
            // TODO: This line of code loads data into the 'traductorDataSet.Palabras' table. You can move, or remove it, as needed.
            this.palabrasTableAdapter.Fill(this.traductorDataSet.Palabras);
            traductorToolStripMenuItem.Enabled = false;
          //  lpalabras.Sorted = true;

           
            
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void abecedarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraductorSistema.Abecedario llamada = new TraductorSistema.Abecedario();
            llamada.Show();
            this.Close();
        }*/

      /*  private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraductorSistema.Login llamada = new TraductorSistema.Login();
            llamada.Show();
            this.Close();
        }*/

        private void lpalabras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string var = lpalabras.Text;
            //FileInfo dir = (FileInfo)palabras.SelectedItems[var];
            try
            {
                string qry = "select ruta from Palabras where palabra='" + var + "'";
                // Inicializa el objeto SqlCommand
                SqlCommand SqlCom = new SqlCommand(qry, con);


                // Abre la conexión y ejecutar el query
                con.Open();
                SqlDataReader rdr = SqlCom.ExecuteReader();

                if (rdr.Read())
                {
                    // byte[] datos = (byte[])rdr["ruta"];
                    //imagen.Image =ImageHelper.ByteArrayToImage(datos);
                    // Obtiene los resultados de la búsqueda
                    //byte[] text;
                    //FileInfo dir = (FileInfo)palabras.SelectedItems[i];
                    // text = rdr.GetString(0);
                    //string currentDir = Environment.CurrentDirectory;
                    //DirectoryInfo directorio = new DirectoryInfo(
                    //  Path.GetFullPath(Path.Combine(currentDir, @"..\..\" + text )));
                    // imagen.Image = Image.FromFile(text);
                    // imagen.Image = byteArrayToImage((byte[])rdr["ruta"]);
                    //  imagen.Image = Image.FromFile(bytruta);
                    byte[] img = (byte[])rdr[0];

                    this.imagen.Image = Bytes2Image(img);

                    //text = string.Empty;


                }
                else
                {
                    //MessageBox.Show("No existe registro con la palabra " + var, "Búsqueda palabras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private byte[] Image2Bytes(Image img)
        {
            string sTemp = Path.GetTempFileName();
            FileStream fs = new FileStream(sTemp, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            img.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Position = 0;

            int imgLength = Convert.ToInt32(fs.Length);
            byte[] bytes = new byte[imgLength];
            fs.Read(bytes, 0, imgLength);
            fs.Close();
            return bytes;
        }
        private Image Bytes2Image(byte[] bytes)
        {
            if (bytes == null) return null;

            MemoryStream ms = new MemoryStream(bytes);
            Bitmap bm = null;

            try
            {
                bm = new Bitmap(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return bm;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.palabrasTableAdapter.FillBy(this.traductorDataSet.Palabras);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.palabrasTableAdapter.FillBy1(this.traductorDataSet.Palabras);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void inicioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void traductorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abecedarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            TraductorSistema.Abecedario llamada = new TraductorSistema.Abecedario();
            llamada.Show();
            this.Close();
        }

        private void lOGINToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            TraductorSistema.Login llamada = new TraductorSistema.Login();
            llamada.Show();
            this.Close();
        }
    
    }
}
