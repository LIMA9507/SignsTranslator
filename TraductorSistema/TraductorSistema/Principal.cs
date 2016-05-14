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
    public partial class SingsTranslator : Form
    {
        public SingsTranslator()
        {
            InitializeComponent();
        }

       /* private void Empezaratraducir_Click(object sender, EventArgs e)
        {
          
            
        }

        private void Abecedario_Click(object sender, EventArgs e)
        {
            

        }*/

        private void SingsTranslator_Load(object sender, EventArgs e)
        {
            inicioToolStripMenuItem.Enabled = false;
   
           
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void traductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignsTranslator.Palabras llamada = new SignsTranslator.Palabras();
                  llamada.Show();
         

        }

        private void abecedarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abecedario llamada = new Abecedario();
            llamada.Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

      

        private void lOGINToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login llamada = new Login();
            llamada.Show();
      
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

     
    }
}
