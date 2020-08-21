using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ine
{
    public partial class Form1 : Form
    {
        int fn, fa, r1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fn = Convert.ToInt32(txtYear.Text);
            fa = Convert.ToInt32(txtAct.Text);
            r1 = fa - fn;
            txtAge.Text = r1.ToString();
            if (r1 >= 18){
                MessageBox.Show("Señor " + txtName.Text + " ya puede tramitar su INE");
            }
            else{
                MessageBox.Show("Señor " + txtName.Text + " usted aun no puede tramitar su INE");
            }
                            
        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
