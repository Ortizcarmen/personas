using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personas
{
    public partial class Form1 : Form
    {
        private Personas persona = new Personas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            persona.Dpi = textBoxdpi.Text;
            persona.Nombre = textBoxnombre.Text;
            persona.Apellido = textBoxape.Text;
            persona.FechaNacimiento = dateTimePicker1.Value;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            labeldpi.Text = persona.Dpi;
            labelnombre.Text = persona.Nombre;
            labelapellido.Text = persona.Apellido;
            labelfechan.Text = persona.FechaNacimiento.ToShortDateString();


            // Mostrar la edad y el nombre normalizado
            labelEdad.Text = $"Edad: {persona.Edad()} años";
            labelNombreNormalizado.Text = $"Nombre Normalizado: {persona.NormalizarNombre()}";

            labelEdad.Visible = true;
            labelNombreNormalizado.Visible = true;

            labeldpi.Visible = true;
            labelnombre.Visible = true;
            labelapellido.Visible = true;
            labelfechan.Visible = true; 
        }
    }
}
