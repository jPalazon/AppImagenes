namespace Vision
{
    partial class BCForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hScrollBarBrightness = new System.Windows.Forms.HScrollBar();
            this.hScrollBarConstrast = new System.Windows.Forms.HScrollBar();
            this.Apply = new System.Windows.Forms.Button();
            this.textBoxBrightness = new System.Windows.Forms.TextBox();
            this.textBoxContrast = new System.Windows.Forms.TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indica el Brillo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indica el contraste";
            // 
            // hScrollBarBrightness
            // 
            this.hScrollBarBrightness.Location = new System.Drawing.Point(25, 54);
            this.hScrollBarBrightness.Name = "hScrollBarBrightness";
            this.hScrollBarBrightness.Size = new System.Drawing.Size(80, 17);
            this.hScrollBarBrightness.TabIndex = 2;
            // 
            // hScrollBarConstrast
            // 
            this.hScrollBarConstrast.Location = new System.Drawing.Point(25, 142);
            this.hScrollBarConstrast.Name = "hScrollBarConstrast";
            this.hScrollBarConstrast.Size = new System.Drawing.Size(80, 17);
            this.hScrollBarConstrast.TabIndex = 3;
            // 
            // Apply
            // 
            this.Apply.Location = new System.Drawing.Point(286, 142);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(75, 23);
            this.Apply.TabIndex = 4;
            this.Apply.Text = "Aplicar";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // textBoxBrightness
            // 
            this.textBoxBrightness.Location = new System.Drawing.Point(136, 23);
            this.textBoxBrightness.Name = "textBoxBrightness";
            this.textBoxBrightness.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrightness.TabIndex = 5;
            this.textBoxBrightness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBrightness_KeyPress);
            // 
            // textBoxContrast
            // 
            this.textBoxContrast.Location = new System.Drawing.Point(136, 104);
            this.textBoxContrast.Name = "textBoxContrast";
            this.textBoxContrast.Size = new System.Drawing.Size(100, 20);
            this.textBoxContrast.TabIndex = 6;
            this.textBoxContrast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContrast_KeyPress);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(12, 189);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(357, 13);
            this.labelNote.TabIndex = 8;
            this.labelNote.Text = "\"Dejar alguna casilla vacía equivale a tomar el valor de la imagen original\"";
            // 
            // BCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 214);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxContrast);
            this.Controls.Add(this.textBoxBrightness);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.hScrollBarConstrast);
            this.Controls.Add(this.hScrollBarBrightness);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BCForm";
            this.Text = "Ajuste brillo y contraste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HScrollBar hScrollBarBrightness;
        private System.Windows.Forms.HScrollBar hScrollBarConstrast;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.TextBox textBoxBrightness;
        private System.Windows.Forms.TextBox textBoxContrast;
        private System.Windows.Forms.Label labelNote;
    }
}