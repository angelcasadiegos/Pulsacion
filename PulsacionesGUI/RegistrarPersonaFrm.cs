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
    public partial class RegistrarPersonaFrm : Form
    {
        PersonaService personaService = new PersonaService();
        public RegistrarPersonaFrm()
        {
            InitializeComponent();
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Identificacion = IdentificacionTxt.Text;
            persona.Nombre = NombreTxt.Text;
            persona.Edad = int.Parse(EdadTxt.Text);
            persona.Sexo = SexoCmb.Text;
            persona.CalcularPulsacion();
            PulsacionesTxt.Text = persona.Pulsacion.ToString();
            string mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "Guardar persona", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            string identificacion = IdentificacionTxt.Text;


            if (identificacion != "")
            {
                RespuestaBusqueda respuestaBusqueda = personaService.Buscar(identificacion);

                if (respuestaBusqueda.Persona != null)
                {
                    Persona persona = respuestaBusqueda.Persona;
                    NombreTxt.Text = persona.Nombre;
                    EdadTxt.Text = persona.Edad.ToString();
                    PulsacionesTxt.Text = persona.Pulsacion.ToString();
                    SexoCmb.Text = persona.Sexo;
                    
                }
                else
                {
                    string mensaje = $"La persona Identificada con numero {identificacion} no a sido registrada";
                    MessageBox.Show(mensaje, "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                string mensaje = "digite una identificacion a buscar";
                MessageBox.Show(mensaje, "ERROR de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string identificacion = IdentificacionTxt.Text;
            if (identificacion != "")
            {
                RespuestaBusqueda respuestaBusqueda = personaService.Buscar(identificacion);
                if (respuestaBusqueda.Persona != null)
                {
                    identificacion = IdentificacionTxt.Text;
                    string mensaje = personaService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Persona Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string mensaje = $"La persona Identificada con el numero {identificacion} no a sido registrada";
                    MessageBox.Show(mensaje, "ERROR Eliminar", MessageBoxButtons.OK , MessageBoxIcon.Error);
                }


            }
        }        

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            if (IdentificacionTxt.Text != "" && NombreTxt.Text != "" && EdadTxt.Text != "" && SexoCmb.Text != "")
            {
                Persona persona = new Persona();
                persona.Identificacion = IdentificacionTxt.Text;
                persona.Nombre = NombreTxt.Text;
                persona.Edad = int.Parse(EdadTxt.Text);
                persona.Sexo = SexoCmb.Text;
                persona.CalcularPulsacion();
                string mensaje = personaService.Modificar(persona);
                MessageBox.Show(mensaje, "Persona Editada",MessageBoxButtons.OK);
            }
            else
                
            {
                string mensaje = "Campo vacio, porfavor verifique los espacios vacios";
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK);
            }
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            if (IdentificacionTxt.Text != "" && NombreTxt.Text != "" && EdadTxt.Text != "" && SexoCmb.Text != "" && PulsacionesTxt.Text !="")
            {
                string mensaje = "Los campos estan vacios!!!";
                MessageBox.Show(mensaje, "Limpiar", MessageBoxButtons.OK,MessageBoxIcon.Question);
            }

            else
            {
                IdentificacionTxt.Text = "";
                NombreTxt.Text = "";
                EdadTxt.Text = "";
                SexoCmb.Text = "";
                PulsacionesTxt.Text = "";
            }
        }

        private void RegistrarPersonaFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
