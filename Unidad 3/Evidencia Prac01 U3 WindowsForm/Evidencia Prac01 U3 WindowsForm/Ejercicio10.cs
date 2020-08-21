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
    public partial class Ejercicio10 : Form
    {
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double cost;
            bool aprov = true;
            int[] ch = new int[2];
            double[] cats = new double[4];

            //Precios de tipos de enfermedad
            cats[0] = 30;
            cats[1] = 38;
            cats[2] = 50;
            cats[3] = 70;

            //Evalua que haya algo en Categoria y Edad
            if (txtType.Text == ""){
                MessageBox.Show("Ingrese una categoria");
                txtType.Focus();
                aprov = false;
            }
            else{
                //Categoria
                ch[0] = int.Parse(txtType.Text);
                aprov = true;
                if (txtAge.Text == ""){
                    MessageBox.Show("Ingrese edad");
                    txtAge.Focus();
                    aprov = false;
                }
                else{
                    //Edad
                    ch[1] = int.Parse(txtAge.Text);
                    aprov = true;
                }
            }

            if (aprov == true)
            {
                switch (ch[0])
                {

                    //Categoria 1
                    case 1:
                        if (ch[1] >= 14 & ch[1] <= 21){
                            cost = cats[0] * 1.1;
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        else{
                            cost = cats[0];
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        break;


                    //Categoria 2
                    case 2:
                        if (ch[1] >= 14 & ch[1] <= 21){
                            cost = cats[1] * 1.1;
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        else{
                            cost = cats[1];
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        break;
                        
                        
                    //Categoria 3
                    case 3:
                        if (ch[1] >= 14 & ch[1] <= 21){
                            cost = cats[2] * 1.1;
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        else{
                            cost = cats[2];
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        break;

                        
                    //Categoria 4
                    case 4:
                        if (ch[1] >= 14 & ch[1] <= 21){
                            cost = cats[3] * 1.1;
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        else{
                            cost = cats[3];
                            MessageBox.Show("El costo diario de este paciente era de: " + "$" + cost);
                        }
                        break;
                                                
                    default:
                        MessageBox.Show("Ingrese categoria 1, 2, 3 o 4");
                        break;
                }
            }
            btnSalir.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ejercicio10_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal frmp = new frmPrincipal();
            frmp.Show();
        }

        private void Ejercicio10_Load(object sender, EventArgs e)
        {

        }
    }
}
