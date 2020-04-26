using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PulsacionesGUI
{
    public partial class ConsultarPersonaFrm : Form
        
    {
        PersonaService personaService = new PersonaService();
        RespuestaConsulta respuestaConsulta = new RespuestaConsulta();
        
        public ConsultarPersonaFrm()
        {
            InitializeComponent();
        }

        private void ConsultarPersonaFrm_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarBtn_Click(object sender, EventArgs e)
        {
            PersonasDgw.DataSource = null;
            respuestaConsulta = personaService.Consultar();            
            string TotalPersonas = personaService.TotalPersonas().ToString();
            string TotalHombres = personaService.TotalHombres().ToString();
            string TotalMujeres = personaService.TotalMujeres().ToString();

            if (SexosCmb.SelectedIndex  == 0)
            {
                PersonasDgw.DataSource = respuestaConsulta;
                TotalTxt.Text = TotalPersonas;
                TotalHombresTxt.Text = TotalHombres;
                TotalMujeresTxt.Text = TotalMujeres;
            }
            else if (SexosCmb.SelectedIndex == 1)
            {
                PersonasDgw.DataSource = personaService.ListaHombres();
                TotalMujeresTxt.Text = "0";
                TotalHombresTxt.Text = TotalHombres;
                TotalTxt.Text = TotalHombres;
            }

            else
            {
                PersonasDgw.DataSource = personaService.ListaMujeres();
                TotalHombresTxt.Text = "0";
                TotalMujeresTxt.Text = TotalMujeres;
                TotalTxt.Text = TotalMujeres;
            }                       
        }

        
        
    }
}
