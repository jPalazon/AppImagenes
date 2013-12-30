namespace Vision
{
    partial class FilterForm
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
            this.labelSize = new System.Windows.Forms.Label();
            this.labelColumns = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.buttonLoadFilter = new System.Windows.Forms.Button();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.labelNormalize = new System.Windows.Forms.Label();
            this.textBoxNormalize = new System.Windows.Forms.TextBox();
            this.openFileDialogFilter = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(212, 174);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(78, 27);
            this.buttonNext.TabIndex = 0;
            this.buttonNext.Text = "Siguiente";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(12, 24);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(85, 13);
            this.labelSize.TabIndex = 1;
            this.labelSize.Text = "Tamaño del filtro";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(12, 94);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(69, 13);
            this.labelColumns.TabIndex = 2;
            this.labelColumns.Text = "nº Columnas:";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(12, 61);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(44, 13);
            this.labelRows.TabIndex = 3;
            this.labelRows.Text = "nº Filas:";
            // 
            // buttonLoadFilter
            // 
            this.buttonLoadFilter.Location = new System.Drawing.Point(105, 176);
            this.buttonLoadFilter.Name = "buttonLoadFilter";
            this.buttonLoadFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFilter.TabIndex = 4;
            this.buttonLoadFilter.Text = "Cargar Filtro";
            this.buttonLoadFilter.UseVisualStyleBackColor = true;
            this.buttonLoadFilter.Click += new System.EventHandler(this.buttonLoadFilter_Click);
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(153, 58);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxRows.TabIndex = 6;
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(153, 91);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumns.TabIndex = 7;
            // 
            // labelNormalize
            // 
            this.labelNormalize.AutoSize = true;
            this.labelNormalize.Location = new System.Drawing.Point(12, 128);
            this.labelNormalize.Name = "labelNormalize";
            this.labelNormalize.Size = new System.Drawing.Size(116, 13);
            this.labelNormalize.TabIndex = 8;
            this.labelNormalize.Text = "Valor de normalización:";
            // 
            // textBoxNormalize
            // 
            this.textBoxNormalize.Location = new System.Drawing.Point(153, 125);
            this.textBoxNormalize.Name = "textBoxNormalize";
            this.textBoxNormalize.Size = new System.Drawing.Size(100, 20);
            this.textBoxNormalize.TabIndex = 9;
            // 
            // openFileDialogFilter
            // 
            this.openFileDialogFilter.FileName = "openFileDialog1";
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 211);
            this.Controls.Add(this.textBoxNormalize);
            this.Controls.Add(this.labelNormalize);
            this.Controls.Add(this.textBoxColumns);
            this.Controls.Add(this.textBoxRows);
            this.Controls.Add(this.buttonLoadFilter);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelColumns);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonNext);
            this.Name = "FilterForm";
            this.Text = "FilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.Button buttonLoadFilter;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label labelNormalize;
        private System.Windows.Forms.TextBox textBoxNormalize;
        private System.Windows.Forms.OpenFileDialog openFileDialogFilter;
    }
}