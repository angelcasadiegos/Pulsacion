using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class PrincipalFrm : Form
    {
        public PrincipalFrm()
        {
            InitializeComponent();
        }

        private void PrincipalFrm_Load(object sender, EventArgs e)
        {

        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonaFrm registrarPersonaFrm = new RegistrarPersonaFrm();
            registrarPersonaFrm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarPersonaFrm consultarPersonaFrm = new ConsultarPersonaFrm();
            consultarPersonaFrm.Show();
        }
    }
}
