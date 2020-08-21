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
    public partial class Ejercicio11 : Form
    {
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int clave;
            int min;
            double costo;


            if (txtClave.Text == ""){
                MessageBox.Show("Por favor ingrese la clave de su llamada");
                txtClave.Focus();
            }
            else{
                clave = int.Parse(txtClave.Text);
                if (txtDuracion.Text == ""){
                    MessageBox.Show("Por favor ingrese la duracion de su llamada");
                    txtDuracion.Focus();
                }
                else{
                    min = int.Parse(txtDuracion.Text);

                    switch (clave) {
                        case 12:
                            costo = min * 2;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        case 15:
                            costo = min * 2.2;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        case 18:
                            costo = min * 4.5;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        case 19:
                            costo = min * 3.5;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        case 23:
                            costo = min * 6;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        case 25:
                            costo = min * 6;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        case 29:
                            costo = min * 5;
                            txtCosto.Text = "El costo de su llamada es: " + "$" + costo;
                            btnSalir.Focus();
                            break;
                        default:
                            MessageBox.Show("Ingrese una lada valida");
                            break;
                    }
                }

            }
        }

        private void Ejercicio11_Load(object sender, EventArgs e)
        {
            txtLads.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmp = new frmPrincipal();
            frmp.Show();
            this.Close();
        }
    }
}
