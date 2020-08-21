using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalc : Form
    {
        int num1, num2, num3;
        string opc;
        double resp, res;

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            /*num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);*/
            resp = num1 + num2;
            //txtResultado.Text = Convert.ToString(resp); 
            MessageBox.Show("El resultado es: " + resp);
            txtSuma.Text = Convert.ToString(resp);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmCalc()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try {
                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum2.Text);
                opc = cboOperador.SelectedItem.ToString();
                if (opc == "+") {
                    res = num1 + num2;
                    MessageBox.Show("La suma de la cantidad es: " + res.ToString());
                }
                if (opc == "-") {
                    res = num1 - num2;
                    MessageBox.Show("La resta de la cantidad es: " + res.ToString());
                }
                if (opc == "*") {
                    res = num1 * num2;
                    MessageBox.Show("La multiplicacion de la cantidad es: " + res.ToString());
                }
                if (opc == "/") {
                    res = num1 / num2;
                    MessageBox.Show("La division de la cantidad es: " + res.ToString());
                }
                /*txtNum1.Text = "";
                txtNum2.Text = "";
                txtNum1.Focus();
                cmbOperacion.Text = "";*/
            }
            catch (DivideByZeroException) {
                MessageBox.Show("Error la division no es divisible entre o", "Mensaje de Error");
                txtNum1.Text = "";
                txtNum2.Text = "";
                txtNum1.Focus();
                cboOperador.Text = "";
            }
            catch (FormatException) {
                MessageBox.Show("Error Escriba los datos correctamente", "Mensaje de Error");

            }
        }
    }
}
