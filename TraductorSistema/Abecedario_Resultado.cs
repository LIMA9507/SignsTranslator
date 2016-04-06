using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraductorSistema
{
    public partial class Abecedario_Resultado : Form
    {
        public Abecedario_Resultado()
        {
            InitializeComponent();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Abecedario_Resultado_Load(object sender, EventArgs e)
        {

        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            Abecedario abfrm = new Abecedario();
            abfrm.ShowDialog();

        }
    }
}
