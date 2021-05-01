using Formularios1.Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios1.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                Validar();

                Persona p = new Persona(txtNombre.Text, txtApellido.Text);

                MessageBox.Show(p.ToString());

                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Validar()
        {
            
            if (txtApellido.Text == string.Empty)
                throw new Exception("Apellido no puede estar en blanco");

            if (txtNombre.Text == string.Empty)
                throw new Exception("Nombre no puede estar en blanco");
        }

        private void Limpiar()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }


    }
}
