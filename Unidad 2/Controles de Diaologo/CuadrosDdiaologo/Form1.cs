using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles_de_Diaologo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            //Opcion de escoger el color
            MyDialog.AllowFullOpen = false;
            //Opcion para obtener ayuda
            MyDialog.ShowHelp = true;
            //Sets the intial color slect to the current text color
            MyDialog.Color = txtColor.ForeColor;
            //Actualiza el color del text box si el ususario da en ok
            if (MyDialog.ShowDialog() == DialogResult.OK){
                txtColor.ForeColor = MyDialog.Color;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.Font = txtColor.Font;
            fontDialog1.Color = txtColor.ForeColor;
            if(fontDialog1.ShowDialog()!=DialogResult.Cancel){
                txtColor.Font = fontDialog1.Font;
                txtColor.ForeColor = fontDialog1.Color;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string foto;
            OpenFileDialog FileDialog1 = new OpenFileDialog();
            //Definimos los filtros de archivos a permitir, en este caso imagenes
            FileDialog1.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JPG files (*.jpg)|*.jpg|All(*.*)|*.*|PNG(*.paisaje)|*.png";
            //Establece que filtro se mostrara por defecto en este caso 3=jpg
            FileDialog1.FilterIndex = 3;
            //Esto aparece en el Nombre del archivo a seleccionar, se puede quitar no es fundamental
            FileDialog1.FileName = "Slecciones un imagen";
            //El titulo de la Ventana
            FileDialog1.Title = "Paisaje";
            //El directorio que por defecto abrirá, para cada contrapleca del Path colocar \\
            //C:\\Fotitos\\Wizard y así sucesivamente
            FileDialog1.InitialDirectory = "c:\\";
            //Evalua que si al aparecer el cuadro de dialogo la persona presiono OK
            if (FileDialog1.ShowDialog() == DialogResult.OK) {
                //Si esto se cumplre, capturamos la propiedad File Name y la guardamos en la variable foto
                foto = FileDialog1.FileName;
                //Por ultimo le asignamos una picture box
                pctImagen.Image = Image.FromFile(@foto);
            }
        }

    }
}
