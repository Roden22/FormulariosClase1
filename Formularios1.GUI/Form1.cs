using Formularios1.Libreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios1.GUI
{
    public partial class Form1 : Form
    {
        private Form _principal;

        private List<Persona> _personas;


        public Form1(Form form)
        {
            _principal = form;
            _personas = new List<Persona>();
            InitializeComponent();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                

                Validar();

                Persona p = new Persona(txtNombre.Text, txtApellido.Text, cmbEstadoCivil.SelectedValue.ToString() ,chkActivo.Checked);

                _personas.Add(p);

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
            if ((int)cmbEstadoCivil.SelectedValue == 0)
                throw new Exception("Seleccione estado civil");

            if (txtApellido.Text == string.Empty)
                throw new Exception("Apellido no puede estar en blanco");

            if (txtNombre.Text == string.Empty)
                throw new Exception("Nombre no puede estar en blanco");

            

        }

        private void Limpiar()
        {
            txtApellido.Text = string.Empty;
            txtNombre.Text = string.Empty;
            chkActivo.Checked = false;
            cmbEstadoCivil.SelectedIndex = 0;
        }

        private void CargarListas()
        {
            this.cmbEstadoCivil.DataSource = EstadoCivilHelper.GetLista();
            this.cmbEstadoCivil.DisplayMember = "Descripcion";
            this.cmbEstadoCivil.ValueMember = "Codigo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarListas();
            Limpiar();
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if(txtNombre.Text.Length > 5)
            {
                MessageBox.Show("hago algo");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            _principal.Show();
            
            this.Close();
        }
    }
}
