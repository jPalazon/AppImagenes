namespace Vision
{
    partial class Gamma
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelGamma = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelGamma
            // 
            this.labelGamma.AutoSize = true;
            this.labelGamma.Location = new System.Drawing.Point(12, 67);
            this.labelGamma.Name = "labelGamma";
            this.labelGamma.Size = new System.Drawing.Size(86, 13);
            this.labelGamma.TabIndex = 0;
            this.labelGamma.Text = "Valor de gamma:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(235, 58);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 30);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(111, 64);
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(100, 20);
            this.textBoxGamma.TabIndex = 2;
            this.textBoxGamma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGamma_KeyPress);
            // 
            // Gamma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 155);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelGamma);
            this.Name = "Gamma";
            this.Text = "Gamma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGamma;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxGamma;
    }
}