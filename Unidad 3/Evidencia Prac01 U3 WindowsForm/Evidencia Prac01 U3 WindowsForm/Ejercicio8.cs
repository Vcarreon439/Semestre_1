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
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Ejercicio8_Load(object sender, EventArgs e)
        {

        }

        private void Ejercicio8_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal frmp = new frmPrincipal();
            frmp.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            bool aprov;
            int age, antiq;
            aprov = true;

            //Evalua que edad y antiguedad tengan algo escrito
            if (txtEdad.Text == ""){
                MessageBox.Show("Ingrese edad");
                txtEdad.Focus();
                aprov = false;
            }
            else{
                aprov = true;
                if(txtAntig.Text==""){
                    MessageBox.Show("Ingrese antiguedad");
                    txtAntig.Focus();
                    aprov = false;
                }
                else{
                    aprov = true;
                }
            }

            //Evaluar que aprov sea verdadero
            if (aprov==true){
                antiq = int.Parse(txtAntig.Text);
                age = int.Parse(txtEdad.Text);
                
                //Evalua las en referencia de los problemas del libre
                if (age >= 60){
                    if (antiq >= 25){
                        MessageBox.Show("Jubilacion por antiguedad adulta");
                    }
                    else {
                        MessageBox.Show("Jubilacion por edad");
                    }
                }
                else{
                    MessageBox.Show("Jubilacion por antiguedad joven");
                }
            }

            btnSalir.Focus();


        }
    }
}
