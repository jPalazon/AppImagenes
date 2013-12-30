namespace Vision
{
    partial class DigitalizationForm
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
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelQuantize = new System.Windows.Forms.Label();
            this.labelSample = new System.Windows.Forms.Label();
            this.textBoxQuantize = new System.Windows.Forms.TextBox();
            this.textBoxSample = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(184, 178);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelQuantize
            // 
            this.labelQuantize.AutoSize = true;
            this.labelQuantize.Location = new System.Drawing.Point(33, 50);
            this.labelQuantize.Name = "labelQuantize";
            this.labelQuantize.Size = new System.Drawing.Size(71, 13);
            this.labelQuantize.TabIndex = 1;
            this.labelQuantize.Text = "Cuantización:";
            // 
            // labelSample
            // 
            this.labelSample.AutoSize = true;
            this.labelSample.Location = new System.Drawing.Point(36, 141);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(54, 13);
            this.labelSample.TabIndex = 2;
            this.labelSample.Text = "Muestreo:";
            // 
            // textBoxQuantize
            // 
            this.textBoxQuantize.Location = new System.Drawing.Point(132, 47);
            this.textBoxQuantize.Name = "textBoxQuantize";
            this.textBoxQuantize.Size = new System.Drawing.Size(57, 20);
            this.textBoxQuantize.TabIndex = 3;
            this.textBoxQuantize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantize_KeyPress);
            // 
            // textBoxSample
            // 
            this.textBoxSample.Location = new System.Drawing.Point(132, 138);
            this.textBoxSample.Name = "textBoxSample";
            this.textBoxSample.Size = new System.Drawing.Size(57, 20);
            this.textBoxSample.TabIndex = 4;
            this.textBoxSample.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSample_KeyPress);
            // 
            // DigitalizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 215);
            this.Controls.Add(this.textBoxSample);
            this.Controls.Add(this.textBoxQuantize);
            this.Controls.Add(this.labelSample);
            this.Controls.Add(this.labelQuantize);
            this.Controls.Add(this.buttonNext);
            this.Name = "DigitalizationForm";
            this.Text = "DigitalizationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelQuantize;
        private System.Windows.Forms.Label labelSample;
        private System.Windows.Forms.TextBox textBoxQuantize;
        private System.Windows.Forms.TextBox textBoxSample;
    }
}