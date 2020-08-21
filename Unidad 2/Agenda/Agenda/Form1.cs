using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        string nombre, apellido, edad;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNom.Text = " ";
            txtApe.Text = " ";
            txtEdad.Text = " ";
            txtNom.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control c  in this.Controls){
                if (c is TextBox) {
                    c.Text = " ";
                    //Colocar el cursor en el primer TextxBox
                    this.txtNom.Focus();
                }
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = txtNom.Text;
            apellido = txtApe.Text;
            edad = txtEdad.Text;
            MessageBox.Show("Bienvenido " + nombre + " " + apellido + "\n\nTu edad es: " + txtEdad.Text);
        }
    }
}
