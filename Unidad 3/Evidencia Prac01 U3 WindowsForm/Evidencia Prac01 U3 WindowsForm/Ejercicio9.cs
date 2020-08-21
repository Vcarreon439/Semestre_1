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
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double sal;
            bool aprov = true;
            int[] ch= new int[2];
            double[] sal2 = new double[4];
            
            //Precios hora extra de categorias
            sal2[0] = 30;
            sal2[1] = 38;
            sal2[2] = 50;
            sal2[3] = 70;

            //Evalua que haya algo en Categoria y horas extra
            if (txtCate.Text == ""){
                MessageBox.Show("Ingrese una categoria");
                txtCate.Focus();
                aprov = false;
            }
            else{
                //Categoria
                ch[0] = int.Parse(txtCate.Text);
                aprov = true;
                if (txtHrs.Text == ""){
                    MessageBox.Show("Ingrese horas extras trabajadas");
                    txtHrs.Focus();
                    aprov = false;
                }
                else{
                    //Horas
                    ch[1] = int.Parse(txtHrs.Text);
                    aprov = true;
                }
            }

            if (aprov == true){
                switch (ch[0]){

                    //Categoria 1
                    case 1:
                        if (ch[1] <= 30)
                        {
                            sal = ch[1] * sal2[0];
                            MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                        }
                        else{
                            if (ch[1]>30){
                                sal = 30 * sal2[0];
                                MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                            } 
                        }
                        break;

                    //Categoria 2
                    case 2:
                        if (ch[1] <= 30)
                        {
                            sal = ch[1] * sal2[1];
                            MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                        }
                        else
                        {
                            if (ch[1] > 30)
                            {
                                sal = 30 * sal2[1];
                                MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                            }
                        }
                        break;
                   
                    //Categoria 3
                    case 3:
                        if (ch[1] <= 30)
                        {
                            sal = ch[1] * sal2[2];
                            MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                        }
                        else
                        {
                            if (ch[1] > 30)
                            {
                                sal = 30 * sal2[2];
                                MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                            }
                        }
                        break;
                   
                    //Categoria 4
                    case 4:
                        if (ch[1] <= 30)
                        {
                            sal = ch[1] * sal2[3];
                            MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                        }
                        else
                        {
                            if (ch[1] > 30)
                            {
                                sal = 30 * sal2[3];
                                MessageBox.Show("El pago por el total de sus horas extra es de: " + "$" + sal);
                            }
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

        private void Ejercicio9_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal frmp = new frmPrincipal();
            frmp.Show();
        }
    }
}
