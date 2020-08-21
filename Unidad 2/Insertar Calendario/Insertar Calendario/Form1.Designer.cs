namespace Insertar_Calendario
{
    partial class frmFechahora
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnHora = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.mcrCalendario = new System.Windows.Forms.MonthCalendar();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(131, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 0;
            // 
            // btnHora
            // 
            this.btnHora.Location = new System.Drawing.Point(111, 209);
            this.btnHora.Name = "btnHora";
            this.btnHora.Size = new System.Drawing.Size(75, 23);
            this.btnHora.TabIndex = 1;
            this.btnHora.Text = "Hora Actual";
            this.btnHora.UseVisualStyleBackColor = true;
            this.btnHora.Click += new System.EventHandler(this.btnHora_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(111, 320);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 23);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Salir";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // mcrCalendario
            // 
            this.mcrCalendario.Location = new System.Drawing.Point(18, 38);
            this.mcrCalendario.Name = "mcrCalendario";
            this.mcrCalendario.TabIndex = 3;
            this.mcrCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcrCalendario_DateChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.Location = new System.Drawing.Point(45, 251);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(200, 20);
            this.dtpHora.TabIndex = 4;
            // 
            // frmFechahora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(280, 361);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.mcrCalendario);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnHora);
            this.Controls.Add(this.lblFecha);
            this.MaximizeBox = false;
            this.Name = "frmFechahora";
            this.Text = "Fecha y hora";
            this.Load += new System.EventHandler(this.frmFechahora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnHora;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.MonthCalendar mcrCalendario;
        private System.Windows.Forms.DateTimePicker dtpHora;
    }
}

