using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generar_Numeros_Aleatorios
{
    public partial class frmAleatorios : Form
    {
        public frmAleatorios()
        {
            InitializeComponent();
        }
        private Random obj = new Random();

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            lblContenedor.Text = " ";
            for (int i = 0; i < 4; i++)
            {
                //for (int j = 0; j < 4; j++){
                
                    lblContenedor.Text += obj.Next(1, 10) + "   |   ";
                    //lblContenedor.Text += "\n\n";
                //}

            }
        }
    }
}
