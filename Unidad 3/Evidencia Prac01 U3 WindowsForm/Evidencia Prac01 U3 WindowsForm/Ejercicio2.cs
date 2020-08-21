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
    public partial class Ejercicio2 : Form
    {

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sendet, EventArgs e){
           this.Close();
        }
        private void btnEvaluar_Click(object sender, EventArgs e)
        {

            int d, m, a;
            bool apro = true;
            string nom;

            if (txtName.Text == "" | txtDay.Text == "" | txtMonth.Text == "" | txtYear.Text == "")
            {
                MessageBox.Show("Le faltan datos por ingresar");
                apro = false;
            }
            else
            {
                d = int.Parse(txtDay.Text);
                m = int.Parse(txtMonth.Text);
                a = int.Parse(txtYear.Text);
                nom = txtName.Text;

                //Evalua dia
                if (d == 0 | d > 31)
                {
                    MessageBox.Show("Ingrese un dia valido");
                    apro = false;
                }
                //Evalua mes
                if (m == 0 | m > 12)
                {
                    MessageBox.Show("Ingrese un mes valido");
                    apro = false;
                }
                //Evalua año
                if (a == 0|a<1819){
                    MessageBox.Show("Ingrese un año valido");
                    apro = false;
                }
                

                if (apro == true){
                    //Evalua edad
                    if (a <= 2001){
                        if (m <= 10){
                            if (d >= 21){
                                MessageBox.Show("Señor " + nom + " ya puede hacer su servicio militar");
                            }
                        }
                    }
                    else{
                        MessageBox.Show(nom + " aun no puede hacer su servicio militar");
                    }
                }
                else{
                    MessageBox.Show("Corrija los datos ingresados");
                }
            }

        }

        private void Ejercicio2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal frmp = new frmPrincipal();
            frmp.Show();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }
    }
}