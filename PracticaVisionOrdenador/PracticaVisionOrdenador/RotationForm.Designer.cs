namespace Vision
{
    partial class RotationForm
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
            this.Rotación = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxRotation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Rotación
            // 
            this.Rotación.AutoSize = true;
            this.Rotación.Location = new System.Drawing.Point(12, 87);
            this.Rotación.Name = "Rotación";
            this.Rotación.Size = new System.Drawing.Size(202, 13);
            this.Rotación.TabIndex = 0;
            this.Rotación.Text = "Indica el valor en grados para la rotación:";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(15, 128);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 1;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxRotation
            // 
            this.textBoxRotation.Location = new System.Drawing.Point(220, 84);
            this.textBoxRotation.Name = "textBoxRotation";
            this.textBoxRotation.Size = new System.Drawing.Size(100, 20);
            this.textBoxRotation.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Indica el método de interpolación:";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "Bilineal",
            "VMP"});
            this.comboBoxMethod.Location = new System.Drawing.Point(220, 32);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMethod.TabIndex = 4;
            // 
            // RotationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 174);
            this.Controls.Add(this.comboBoxMethod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRotation);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.Rotación);
            this.Name = "RotationForm";
            this.Text = "Rotación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rotación;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxRotation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMethod;
    }
}