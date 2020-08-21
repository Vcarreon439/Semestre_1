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
    public partial class frmFormulario1 : Form
    {
        public frmFormulario1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            new frmFormulario2().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFormulario1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cuando sacas una buena calificacion en el examen teorico");
        }
    }
}
