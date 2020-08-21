using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejo_de_Formularios
{
    public partial class frmFormulario2 : Form
    {
        public frmFormulario2()
        {
            InitializeComponent();
        }

        private void btnPrevio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormulario2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Pero sacas un 7 en el Practico :(");
        }
    }
}
