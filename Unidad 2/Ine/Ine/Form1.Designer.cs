namespace Ine
{
    partial class Form1
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
            this.btntest = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblActual = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAct = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(15, 187);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(221, 56);
            this.btntest.TabIndex = 13;
            this.btntest.Text = "Verificar Edad";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 14);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(100, 13);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Cual es su nombre?";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 73);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(110, 13);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Año en el que naciste";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(12, 98);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 4;
            this.txtYear.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 132);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Edad";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.Location = new System.Drawing.Point(128, 73);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(58, 13);
            this.lblActual.TabIndex = 5;
            this.lblActual.Text = "Año actual";
            this.lblActual.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 151);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 8;
            // 
            // txtAct
            // 
            this.txtAct.Location = new System.Drawing.Point(129, 98);
            this.txtAct.Name = "txtAct";
            this.txtAct.Size = new System.Drawing.Size(100, 20);
            this.txtAct.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 259);
            this.Controls.Add(this.txtAct);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btntest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblActual;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAct;
    }
}

