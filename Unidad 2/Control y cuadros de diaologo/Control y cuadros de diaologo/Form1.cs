using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_y_cuadros_de_diaologo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#, espero sea de su agrado.");
            lblLetrero.Text = "Bienvenidos a C#, espero que sea de su agrado.";
            txtLetrero.Text = "Bienvenidos a C#, espero que sea de su agrado.";
        }
    }
}
