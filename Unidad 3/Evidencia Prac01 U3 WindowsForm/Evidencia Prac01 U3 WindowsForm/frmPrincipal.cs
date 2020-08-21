using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evidencia_Prac01_U3_WindowsForm
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPr2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2 frm2 = new Ejercicio2();
            frm2.Show();
        }

        private void btnPr6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio6 frm6 = new Ejercicio6();
            frm6.Show();
        }

        private void btnPr8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio8 frm8 = new Ejercicio8();
            frm8.Show();
        }

        private void btnPr9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio9 frm9 = new Ejercicio9();
            frm9.Show();
        }

        private void btnPr10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio10 frm10 = new Ejercicio10();
            frm10.Show();
        }

        private void btnPr11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio11 frm11 = new Ejercicio11();
            frm11.Show();
        }
    }
}
