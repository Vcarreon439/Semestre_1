namespace Control_y_cuadros_de_diaologo
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
            this.lblLetrero = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.txtLetrero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLetrero
            // 
            this.lblLetrero.AllowDrop = true;
            this.lblLetrero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblLetrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrero.ForeColor = System.Drawing.Color.Red;
            this.lblLetrero.Location = new System.Drawing.Point(12, 9);
            this.lblLetrero.Name = "lblLetrero";
            this.lblLetrero.Size = new System.Drawing.Size(360, 121);
            this.lblLetrero.TabIndex = 0;
            this.lblLetrero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(205, 309);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(167, 40);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // txtLetrero
            // 
            this.txtLetrero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetrero.Location = new System.Drawing.Point(12, 147);
            this.txtLetrero.Multiline = true;
            this.txtLetrero.Name = "txtLetrero";
            this.txtLetrero.Size = new System.Drawing.Size(360, 100);
            this.txtLetrero.TabIndex = 0;
            this.txtLetrero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtLetrero);
            this.Controls.Add(this.lblLetrero);
            this.Name = "Form1";
            this.Text = "Hola Mundo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetrero;
        private System.Windows.Forms.TextBox txtLetrero;
        private System.Windows.Forms.Button btnMostrar;
    }
}

