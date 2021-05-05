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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(this);
            frm.Show();
            //frm.TxtNombre = "VALOR DEFAULT";
            this.Hide();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
