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

            cs.DataSource = @"CRISTIANPC";
            cs.InitialCatalog = "Abecedario";
            cs.IntegratedSecurity = true;



            con = new SqlConnection(cs.ConnectionString);
        }

        private void A_Click(object sender, EventArgs e)
        {
            string qry = "select RUTA from Señas where descripcion='a' and Tipo=1";
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
                   

                    Abecedario_Resultado FrmObjR= new Abecedario_Resultado();
                    FrmObjR.PictureBox1.Image=Image.FromFile(rdr.GetString(0));
                    FrmObjR.ShowDialog();

                    text = string.Empty;
                   
                }
                else
                {
                    MessageBox.Show("No existe registro con la A", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
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

        private void B_Click(object sender, EventArgs e)
        {
            string qry = "select RUTA from Señas where descripcion='b' and Tipo=1";
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
                   

                    Abecedario_Resultado FrmObjR= new Abecedario_Resultado();
                    FrmObjR.PictureBox1.Image=Image.FromFile(rdr.GetString(0));
                    FrmObjR.ShowDialog();

                    text = string.Empty;
                   
                }
                else
                {
                    MessageBox.Show("No existe registro con la B", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
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

        private void P_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='p' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la P", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void C_Click(object sender, EventArgs e)
        {
            string qry = "select RUTA from Señas where descripcion='c' and Tipo=1";
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
                   

                    Abecedario_Resultado FrmObjR= new Abecedario_Resultado();
                    FrmObjR.PictureBox1.Image=Image.FromFile(rdr.GetString(0));
                    FrmObjR.ShowDialog();

                    text = string.Empty;
                   
                }
                else
                {
                    MessageBox.Show("No existe registro con la C", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception ex)
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

        private void D_Click(object sender, EventArgs e)
        {
            string qry = "select RUTA from Señas where descripcion='d' and Tipo=1";
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
                    MessageBox.Show("No existe registro con la D", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void E_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='e' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la E", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void F_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='f' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la F", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void G_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='G' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la G", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void H_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='h' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la H", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void I_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='i' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la I", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void J_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='j' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la J", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void K_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='k' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la K", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void L_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='l' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la L", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void U_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='m' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la M", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void N_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='n' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la N", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Ñ_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='ñ' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la Ñ", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void O_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='o' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la O", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Q_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='q' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la Q", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void R_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='r' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la R", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void S_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='s' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la s", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void T_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='t' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la T", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void M_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='u' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la U", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void V_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='v' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la V", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void W_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='w' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la W", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void X_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='x' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la X", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Y_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='y' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la Y", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void Z_Click(object sender, EventArgs e)
        {
            {
                string qry = "select RUTA from Señas where descripcion='z' and Tipo=1";
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
                        MessageBox.Show("No existe registro con la Z", "Búsqueda Abecedario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

