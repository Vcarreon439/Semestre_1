using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insertar_Calendario{
    public partial class frmFechahora : Form{
        public frmFechahora(){
            InitializeComponent();
        }

        private void frmFechahora_Load(object sender, EventArgs e){
            this.dtpHora.Format = DateTimePickerFormat.Time;
            this.dtpHora.Width = 100;
            //this.dtpHora.ShownUpDown = true;
        }

        private void mcrCalendario_DateChanged(object sender, DateRangeEventArgs e){
            this.lblFecha.Text = this.mcrCalendario.SelectionRange.Start.ToShortDateString();
        }

        private void btnHora_Click(object sender, EventArgs e){
            lblFecha.Text = this.mcrCalendario.SelectionRange.Start.ToShortDateString();
            this.dtpHora.Value = DateTime.Now;
        }

        private void btnOut_Click(object sender, EventArgs e){
            this.Close();
        }
    }
}
