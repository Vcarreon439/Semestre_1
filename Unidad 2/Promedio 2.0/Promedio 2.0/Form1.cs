using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio_2._0
{
    public partial class Promedio : Form{
        //Definir variables
        double calf, cal1, cal2, cal3, calp;
        double calex, caltf;
        private void txtP1_TextChanged(object sender, EventArgs e){
            }

        private void textBox4_TextChanged(object sender, EventArgs e){
        }
        public Promedio(){
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e){
            cal1 = Convert.ToInt16(txtP1.Text);
            cal2 = Convert.ToInt16(txtP2.Text);
            cal3 = Convert.ToInt16(txtP3.Text);
            calp = (cal1 + cal2 + cal3)/3;
            calp = calp*.55;
            calex = Convert.ToInt16(txtExf.Text);
            calex = calex * .30;
            caltf = Convert.ToInt16(txtTrf.Text);
            caltf = caltf * .15;
            calf = (calp+calex+caltf);
            lblShow.Text = Convert.ToString(calf);
            lblShow.Visible=true;
        }

        private void Promedio_Load(object sender, EventArgs e){

        }
    }
}
