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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Empezaratraducir_Click(object sender, EventArgs e)
        {
            Traductor_señas frmts = new Traductor_señas();
            frmts.ShowDialog();
          
            
        }

        private void Abecedario_Click(object sender, EventArgs e)
        {
            Abecedario frmabr = new Abecedario();
            frmabr.ShowDialog();

        }
    }
}
