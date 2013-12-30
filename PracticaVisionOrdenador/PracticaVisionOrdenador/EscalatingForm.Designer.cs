namespace Vision
{
    partial class EscalatingForm
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
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelPorcentx = new System.Windows.Forms.Label();
            this.labelPorcentY = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Bilineal",
            "VMP"});
            this.comboBoxMethod.Location = new System.Drawing.Point(183, 12);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethod.TabIndex = 0;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(183, 52);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(183, 78);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 2;
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.Location = new System.Drawing.Point(12, 15);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(124, 13);
            this.labelMethod.TabIndex = 3;
            this.labelMethod.Text = "Método de interpolación:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 52);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(17, 13);
            this.labelX.TabIndex = 4;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(12, 81);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(17, 13);
            this.labelY.TabIndex = 5;
            this.labelY.Text = "Y:";
            // 
            // labelPorcentx
            // 
            this.labelPorcentx.AutoSize = true;
            this.labelPorcentx.Location = new System.Drawing.Point(289, 55);
            this.labelPorcentx.Name = "labelPorcentx";
            this.labelPorcentx.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentx.TabIndex = 6;
            this.labelPorcentx.Text = "%";
            // 
            // labelPorcentY
            // 
            this.labelPorcentY.AutoSize = true;
            this.labelPorcentY.Location = new System.Drawing.Point(289, 81);
            this.labelPorcentY.Name = "labelPorcentY";
            this.labelPorcentY.Size = new System.Drawing.Size(15, 13);
            this.labelPorcentY.TabIndex = 7;
            this.labelPorcentY.Text = "%";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(300, 108);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 8;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // EscalatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 143);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelPorcentY);
            this.Controls.Add(this.labelPorcentx);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.comboBoxMethod);
            this.Name = "EscalatingForm";
            this.Text = "Escalado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelPorcentx;
        private System.Windows.Forms.Label labelPorcentY;
        private System.Windows.Forms.Button buttonNext;
    }
}