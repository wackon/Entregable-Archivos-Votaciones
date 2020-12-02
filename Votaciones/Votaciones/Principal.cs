using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Votaciones
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void eleccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void votarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void realizarVotacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Candidatos objC = new Candidatos();
            objC.Show();
            objC.MdiParent = this;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas objE = new Estadisticas();
            objE.Show();
            objE.MdiParent=this;
        }
    }
}
