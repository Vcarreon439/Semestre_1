namespace Evidencia_Prac01_U3_WindowsForm
{
    partial class frmPrincipal
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
            this.btnPr2 = new System.Windows.Forms.Button();
            this.btnPr6 = new System.Windows.Forms.Button();
            this.btnPr8 = new System.Windows.Forms.Button();
            this.btnPr9 = new System.Windows.Forms.Button();
            this.btnPr10 = new System.Windows.Forms.Button();
            this.btnPr11 = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPr2
            // 
            this.btnPr2.Location = new System.Drawing.Point(35, 78);
            this.btnPr2.Name = "btnPr2";
            this.btnPr2.Size = new System.Drawing.Size(103, 31);
            this.btnPr2.TabIndex = 1;
            this.btnPr2.Text = "Ejercicio 2";
            this.btnPr2.UseVisualStyleBackColor = true;
            this.btnPr2.Click += new System.EventHandler(this.btnPr2_Click);
            // 
            // btnPr6
            // 
            this.btnPr6.Location = new System.Drawing.Point(35, 131);
            this.btnPr6.Name = "btnPr6";
            this.btnPr6.Size = new System.Drawing.Size(103, 31);
            this.btnPr6.TabIndex = 2;
            this.btnPr6.Text = "Ejercicio 6";
            this.btnPr6.UseVisualStyleBackColor = true;
            this.btnPr6.Click += new System.EventHandler(this.btnPr6_Click);
            // 
            // btnPr8
            // 
            this.btnPr8.Location = new System.Drawing.Point(35, 180);
            this.btnPr8.Name = "btnPr8";
            this.btnPr8.Size = new System.Drawing.Size(103, 31);
            this.btnPr8.TabIndex = 3;
            this.btnPr8.Text = "Ejercicio 8";
            this.btnPr8.UseVisualStyleBackColor = true;
            this.btnPr8.Click += new System.EventHandler(this.btnPr8_Click);
            // 
            // btnPr9
            // 
            this.btnPr9.Location = new System.Drawing.Point(154, 78);
            this.btnPr9.Name = "btnPr9";
            this.btnPr9.Size = new System.Drawing.Size(103, 31);
            this.btnPr9.TabIndex = 4;
            this.btnPr9.Text = "Ejercicio 9";
            this.btnPr9.UseVisualStyleBackColor = true;
            this.btnPr9.Click += new System.EventHandler(this.btnPr9_Click);
            // 
            // btnPr10
            // 
            this.btnPr10.Location = new System.Drawing.Point(154, 131);
            this.btnPr10.Name = "btnPr10";
            this.btnPr10.Size = new System.Drawing.Size(103, 31);
            this.btnPr10.TabIndex = 5;
            this.btnPr10.Text = "Ejercicio 10";
            this.btnPr10.UseVisualStyleBackColor = true;
            this.btnPr10.Click += new System.EventHandler(this.btnPr10_Click);
            // 
            // btnPr11
            // 
            this.btnPr11.Location = new System.Drawing.Point(154, 180);
            this.btnPr11.Name = "btnPr11";
            this.btnPr11.Size = new System.Drawing.Size(103, 31);
            this.btnPr11.TabIndex = 6;
            this.btnPr11.Text = "Ejercicio 11";
            this.btnPr11.UseVisualStyleBackColor = true;
            this.btnPr11.Click += new System.EventHandler(this.btnPr11_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(48, 28);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(201, 20);
            this.lblTittle.TabIndex = 6;
            this.lblTittle.Text = "Seleccione un problema";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(307, 249);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.btnPr11);
            this.Controls.Add(this.btnPr10);
            this.Controls.Add(this.btnPr9);
            this.Controls.Add(this.btnPr8);
            this.Controls.Add(this.btnPr6);
            this.Controls.Add(this.btnPr2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Evidencia Prac01 U3";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPr2;
        private System.Windows.Forms.Button btnPr6;
        private System.Windows.Forms.Button btnPr8;
        private System.Windows.Forms.Button btnPr9;
        private System.Windows.Forms.Button btnPr10;
        private System.Windows.Forms.Button btnPr11;
        private System.Windows.Forms.Label lblTittle;
    }
}

