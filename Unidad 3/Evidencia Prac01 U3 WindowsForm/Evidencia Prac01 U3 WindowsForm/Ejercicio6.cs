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
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            bool apro = true;
            double sal, sal1, sal2, sal3;
            int hrs;
            string nom;

            if (txtName.Text == "" | txtHoras.Text == ""|txtSal.Text==""){
                MessageBox.Show("Le faltan datos por ingresar");
                txtName.Focus();
                apro = false;
            }

            if (apro==true){

                //Convierte los datos necesarios
                nom = txtName.Text;
                hrs = int.Parse(txtHoras.Text);
                sal = Convert.ToDouble(txtSal.Text);
                                
                //En caso de ser 40 o menos horas
                if (hrs == 40 | hrs < 40){
                    sal = hrs * sal;
                }

                //En caso de ser mas de 40 y menos de 48
                if (hrs > 40 & hrs < 48){
                    sal = hrs * sal;
                    hrs = hrs - 40;
                    sal1 = hrs * (2 * sal);
                    sal = sal1;
                }
                                                
                //En caso de ser mas de 48 hrs
                if (hrs>=48){
                    hrs = hrs - 48;
                    sal1 = 40 * sal;
                    sal2 = 8 * (2 * sal);
                    sal3 = hrs * (3 * sal);
                    sal = sal1 + sal2 + sal3;
                }
                MessageBox.Show("Señor " + nom + " su salario es: " + "$" + sal);
                btnSalir.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e){
            this.Close();
        }

        private void Ejercicio6_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal frmp = new frmPrincipal();
            frmp.Show();
        }

        private void Ejercicio6_Load(object sender, EventArgs e)
        {

        }
    }               
}    