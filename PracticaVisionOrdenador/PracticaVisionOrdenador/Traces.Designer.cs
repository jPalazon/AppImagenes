namespace Vision
{
    partial class Traces
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
            this.labelTraceNum = new System.Windows.Forms.Label();
            this.textBoxTraces = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(209, 99);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelTraceNum
            // 
            this.labelTraceNum.AutoSize = true;
            this.labelTraceNum.Location = new System.Drawing.Point(25, 99);
            this.labelTraceNum.Name = "labelTraceNum";
            this.labelTraceNum.Size = new System.Drawing.Size(96, 13);
            this.labelTraceNum.TabIndex = 1;
            this.labelTraceNum.Text = "Número de tramos:";
            // 
            // textBoxTraces
            // 
            this.textBoxTraces.Location = new System.Drawing.Point(124, 99);
            this.textBoxTraces.Name = "textBoxTraces";
            this.textBoxTraces.Size = new System.Drawing.Size(58, 20);
            this.textBoxTraces.TabIndex = 2;
            this.textBoxTraces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTraces_KeyPress);
            // 
            // Traces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(318, 220);
            this.Controls.Add(this.textBoxTraces);
            this.Controls.Add(this.labelTraceNum);
            this.Controls.Add(this.buttonNext);
            this.Name = "Traces";
            this.Text = "Transformación por tramos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelTraceNum;
        private System.Windows.Forms.TextBox textBoxTraces;
    }
}