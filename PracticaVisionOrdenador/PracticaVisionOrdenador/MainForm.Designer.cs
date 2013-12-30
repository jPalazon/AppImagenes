namespace Vision
{
    partial class MainForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absolutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acumuladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monocromoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brilloYContrasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especificaciónHistogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecualizaciónHistogramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correcciónGammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferenciaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalizaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesGeométricasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espejoVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espejoHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traspuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionesSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ºToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ºToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.poToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escaladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Brillo = new System.Windows.Forms.Label();
            this.Contraste = new System.Windows.Forms.Label();
            this.MinMax = new System.Windows.Forms.Label();
            this.Tamaño = new System.Windows.Forms.Label();
            this.Entropia = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.positionx = new System.Windows.Forms.ToolStripStatusLabel();
            this.positiony = new System.Windows.Forms.ToolStripStatusLabel();
            this.RLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.GLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.transformarToolStripMenuItem,
            this.filtrosToolStripMenuItem,
            this.operacionesGeométricasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirImagenToolStripMenuItem,
            this.guardarImagenToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirImagenToolStripMenuItem
            // 
            this.abrirImagenToolStripMenuItem.Name = "abrirImagenToolStripMenuItem";
            this.abrirImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.abrirImagenToolStripMenuItem.Text = "Abrir Imagen";
            this.abrirImagenToolStripMenuItem.Click += new System.EventHandler(this.abrirImagenToolStripMenuItem_Click);
            // 
            // guardarImagenToolStripMenuItem
            // 
            this.guardarImagenToolStripMenuItem.Name = "guardarImagenToolStripMenuItem";
            this.guardarImagenToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarImagenToolStripMenuItem.Text = "Guardar Imagen";
            this.guardarImagenToolStripMenuItem.Click += new System.EventHandler(this.guardarImagenToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histogramaToolStripMenuItem,
            this.informaciónToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // histogramaToolStripMenuItem
            // 
            this.histogramaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absolutoToolStripMenuItem,
            this.acumuladoToolStripMenuItem});
            this.histogramaToolStripMenuItem.Name = "histogramaToolStripMenuItem";
            this.histogramaToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.histogramaToolStripMenuItem.Text = "Histograma";
            // 
            // absolutoToolStripMenuItem
            // 
            this.absolutoToolStripMenuItem.Name = "absolutoToolStripMenuItem";
            this.absolutoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.absolutoToolStripMenuItem.Text = "Absoluto";
            this.absolutoToolStripMenuItem.Click += new System.EventHandler(this.absolutoToolStripMenuItem_Click);
            // 
            // acumuladoToolStripMenuItem
            // 
            this.acumuladoToolStripMenuItem.Name = "acumuladoToolStripMenuItem";
            this.acumuladoToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.acumuladoToolStripMenuItem.Text = "Acumulativo";
            this.acumuladoToolStripMenuItem.Click += new System.EventHandler(this.acumuladoToolStripMenuItem_Click);
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            this.informaciónToolStripMenuItem.Click += new System.EventHandler(this.informaciónToolStripMenuItem_Click);
            // 
            // transformarToolStripMenuItem
            // 
            this.transformarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trazosToolStripMenuItem,
            this.noLinealesToolStripMenuItem});
            this.transformarToolStripMenuItem.Name = "transformarToolStripMenuItem";
            this.transformarToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transformarToolStripMenuItem.Text = "Transformar";
            // 
            // trazosToolStripMenuItem
            // 
            this.trazosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monocromoToolStripMenuItem,
            this.trazosToolStripMenuItem1,
            this.brilloYContrasteToolStripMenuItem});
            this.trazosToolStripMenuItem.Name = "trazosToolStripMenuItem";
            this.trazosToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.trazosToolStripMenuItem.Text = "Lineales";
            // 
            // monocromoToolStripMenuItem
            // 
            this.monocromoToolStripMenuItem.Name = "monocromoToolStripMenuItem";
            this.monocromoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.monocromoToolStripMenuItem.Text = "Monocromo";
            this.monocromoToolStripMenuItem.Click += new System.EventHandler(this.monocromoToolStripMenuItem_Click_1);
            // 
            // trazosToolStripMenuItem1
            // 
            this.trazosToolStripMenuItem1.Name = "trazosToolStripMenuItem1";
            this.trazosToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.trazosToolStripMenuItem1.Text = "Tramos";
            this.trazosToolStripMenuItem1.Click += new System.EventHandler(this.trazosToolStripMenuItem1_Click);
            // 
            // brilloYContrasteToolStripMenuItem
            // 
            this.brilloYContrasteToolStripMenuItem.Name = "brilloYContrasteToolStripMenuItem";
            this.brilloYContrasteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.brilloYContrasteToolStripMenuItem.Text = "Brillo y contraste";
            this.brilloYContrasteToolStripMenuItem.Click += new System.EventHandler(this.brilloYContrasteToolStripMenuItem_Click);
            // 
            // noLinealesToolStripMenuItem
            // 
            this.noLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especificaciónHistogramaToolStripMenuItem,
            this.ecualizaciónHistogramaToolStripMenuItem,
            this.correcciónGammaToolStripMenuItem,
            this.diferenciaciónToolStripMenuItem,
            this.digitalizaciónToolStripMenuItem});
            this.noLinealesToolStripMenuItem.Name = "noLinealesToolStripMenuItem";
            this.noLinealesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.noLinealesToolStripMenuItem.Text = "No lineales";
            // 
            // especificaciónHistogramaToolStripMenuItem
            // 
            this.especificaciónHistogramaToolStripMenuItem.Name = "especificaciónHistogramaToolStripMenuItem";
            this.especificaciónHistogramaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.especificaciónHistogramaToolStripMenuItem.Text = "Especificación Histograma";
            this.especificaciónHistogramaToolStripMenuItem.Click += new System.EventHandler(this.especificaciónHistogramaToolStripMenuItem_Click);
            // 
            // ecualizaciónHistogramaToolStripMenuItem
            // 
            this.ecualizaciónHistogramaToolStripMenuItem.Name = "ecualizaciónHistogramaToolStripMenuItem";
            this.ecualizaciónHistogramaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.ecualizaciónHistogramaToolStripMenuItem.Text = "Ecualización Histograma";
            this.ecualizaciónHistogramaToolStripMenuItem.Click += new System.EventHandler(this.ecualizaciónHistogramaToolStripMenuItem_Click);
            // 
            // correcciónGammaToolStripMenuItem
            // 
            this.correcciónGammaToolStripMenuItem.Name = "correcciónGammaToolStripMenuItem";
            this.correcciónGammaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.correcciónGammaToolStripMenuItem.Text = "Corrección Gamma";
            this.correcciónGammaToolStripMenuItem.Click += new System.EventHandler(this.correcciónGammaToolStripMenuItem_Click);
            // 
            // diferenciaciónToolStripMenuItem
            // 
            this.diferenciaciónToolStripMenuItem.Name = "diferenciaciónToolStripMenuItem";
            this.diferenciaciónToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.diferenciaciónToolStripMenuItem.Text = "Diferenciación";
            this.diferenciaciónToolStripMenuItem.Click += new System.EventHandler(this.diferenciaciónToolStripMenuItem_Click);
            // 
            // digitalizaciónToolStripMenuItem
            // 
            this.digitalizaciónToolStripMenuItem.Name = "digitalizaciónToolStripMenuItem";
            this.digitalizaciónToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.digitalizaciónToolStripMenuItem.Text = "Digitalización";
            this.digitalizaciónToolStripMenuItem.Click += new System.EventHandler(this.digitalizaciónToolStripMenuItem_Click);
            // 
            // filtrosToolStripMenuItem
            // 
            this.filtrosToolStripMenuItem.Name = "filtrosToolStripMenuItem";
            this.filtrosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.filtrosToolStripMenuItem.Text = "Filtros";
            this.filtrosToolStripMenuItem.Click += new System.EventHandler(this.filtrosToolStripMenuItem_Click);
            // 
            // operacionesGeométricasToolStripMenuItem
            // 
            this.operacionesGeométricasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espejoVerticalToolStripMenuItem,
            this.espejoHorizontalToolStripMenuItem,
            this.traspuestaToolStripMenuItem,
            this.rotacionesSimplesToolStripMenuItem,
            this.escaladoToolStripMenuItem});
            this.operacionesGeométricasToolStripMenuItem.Name = "operacionesGeométricasToolStripMenuItem";
            this.operacionesGeométricasToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.operacionesGeométricasToolStripMenuItem.Text = "Operaciones Geométricas";
            // 
            // espejoVerticalToolStripMenuItem
            // 
            this.espejoVerticalToolStripMenuItem.Name = "espejoVerticalToolStripMenuItem";
            this.espejoVerticalToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.espejoVerticalToolStripMenuItem.Text = "Espejo Vertical";
            this.espejoVerticalToolStripMenuItem.Click += new System.EventHandler(this.espejoVerticalToolStripMenuItem_Click);
            // 
            // espejoHorizontalToolStripMenuItem
            // 
            this.espejoHorizontalToolStripMenuItem.Name = "espejoHorizontalToolStripMenuItem";
            this.espejoHorizontalToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.espejoHorizontalToolStripMenuItem.Text = "Espejo Horizontal";
            this.espejoHorizontalToolStripMenuItem.Click += new System.EventHandler(this.espejoHorizontalToolStripMenuItem_Click);
            // 
            // traspuestaToolStripMenuItem
            // 
            this.traspuestaToolStripMenuItem.Name = "traspuestaToolStripMenuItem";
            this.traspuestaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.traspuestaToolStripMenuItem.Text = "Traspuesta";
            this.traspuestaToolStripMenuItem.Click += new System.EventHandler(this.traspuestaToolStripMenuItem_Click);
            // 
            // rotacionesSimplesToolStripMenuItem
            // 
            this.rotacionesSimplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ºToolStripMenuItem,
            this.ºToolStripMenuItem1,
            this.ºToolStripMenuItem2,
            this.poToolStripMenuItem});
            this.rotacionesSimplesToolStripMenuItem.Name = "rotacionesSimplesToolStripMenuItem";
            this.rotacionesSimplesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.rotacionesSimplesToolStripMenuItem.Text = "Rotaciones";
            // 
            // ºToolStripMenuItem
            // 
            this.ºToolStripMenuItem.Name = "ºToolStripMenuItem";
            this.ºToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ºToolStripMenuItem.Text = "90º";
            this.ºToolStripMenuItem.Click += new System.EventHandler(this.ºToolStripMenuItem_Click);
            // 
            // ºToolStripMenuItem1
            // 
            this.ºToolStripMenuItem1.Name = "ºToolStripMenuItem1";
            this.ºToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.ºToolStripMenuItem1.Text = "180º";
            this.ºToolStripMenuItem1.Click += new System.EventHandler(this.ºToolStripMenuItem1_Click);
            // 
            // ºToolStripMenuItem2
            // 
            this.ºToolStripMenuItem2.Name = "ºToolStripMenuItem2";
            this.ºToolStripMenuItem2.Size = new System.Drawing.Size(121, 22);
            this.ºToolStripMenuItem2.Text = "270º";
            this.ºToolStripMenuItem2.Click += new System.EventHandler(this.ºToolStripMenuItem2_Click);
            // 
            // poToolStripMenuItem
            // 
            this.poToolStripMenuItem.Name = "poToolStripMenuItem";
            this.poToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.poToolStripMenuItem.Text = "por valor";
            this.poToolStripMenuItem.Click += new System.EventHandler(this.poToolStripMenuItem_Click);
            // 
            // escaladoToolStripMenuItem
            // 
            this.escaladoToolStripMenuItem.Name = "escaladoToolStripMenuItem";
            this.escaladoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.escaladoToolStripMenuItem.Text = "Escalado";
            this.escaladoToolStripMenuItem.Click += new System.EventHandler(this.escaladoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Brillo);
            this.panel1.Controls.Add(this.Contraste);
            this.panel1.Controls.Add(this.MinMax);
            this.panel1.Controls.Add(this.Tamaño);
            this.panel1.Controls.Add(this.Entropia);
            this.panel1.Controls.Add(this.Tipo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(408, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 214);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Brillo
            // 
            this.Brillo.AutoSize = true;
            this.Brillo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Brillo.Location = new System.Drawing.Point(67, 147);
            this.Brillo.Name = "Brillo";
            this.Brillo.Size = new System.Drawing.Size(22, 13);
            this.Brillo.TabIndex = 15;
            this.Brillo.Text = "     ";
            // 
            // Contraste
            // 
            this.Contraste.AutoSize = true;
            this.Contraste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Contraste.Location = new System.Drawing.Point(67, 177);
            this.Contraste.Name = "Contraste";
            this.Contraste.Size = new System.Drawing.Size(22, 13);
            this.Contraste.TabIndex = 14;
            this.Contraste.Text = "     ";
            // 
            // MinMax
            // 
            this.MinMax.AutoSize = true;
            this.MinMax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinMax.Location = new System.Drawing.Point(67, 117);
            this.MinMax.Name = "MinMax";
            this.MinMax.Size = new System.Drawing.Size(22, 13);
            this.MinMax.TabIndex = 13;
            this.MinMax.Text = "     ";
            // 
            // Tamaño
            // 
            this.Tamaño.AutoSize = true;
            this.Tamaño.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tamaño.Location = new System.Drawing.Point(67, 82);
            this.Tamaño.Name = "Tamaño";
            this.Tamaño.Size = new System.Drawing.Size(22, 13);
            this.Tamaño.TabIndex = 12;
            this.Tamaño.Text = "     ";
            // 
            // Entropia
            // 
            this.Entropia.AutoSize = true;
            this.Entropia.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Entropia.Location = new System.Drawing.Point(67, 51);
            this.Entropia.Name = "Entropia";
            this.Entropia.Size = new System.Drawing.Size(22, 13);
            this.Entropia.TabIndex = 11;
            this.Entropia.Text = "     ";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tipo.Location = new System.Drawing.Point(67, 20);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(22, 13);
            this.Tipo.TabIndex = 10;
            this.Tipo.Text = "     ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Brillo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min/Max:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamaño:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entropía:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionx,
            this.positiony,
            this.RLevel,
            this.GLevel,
            this.BLevel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 412);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(728, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // positionx
            // 
            this.positionx.Name = "positionx";
            this.positionx.Size = new System.Drawing.Size(12, 17);
            this.positionx.Text = "x";
            // 
            // positiony
            // 
            this.positiony.Name = "positiony";
            this.positiony.Size = new System.Drawing.Size(13, 17);
            this.positiony.Text = "y";
            // 
            // RLevel
            // 
            this.RLevel.Name = "RLevel";
            this.RLevel.Size = new System.Drawing.Size(14, 17);
            this.RLevel.Text = "R";
            // 
            // GLevel
            // 
            this.GLevel.Name = "GLevel";
            this.GLevel.Size = new System.Drawing.Size(15, 17);
            this.GLevel.Text = "G";
            // 
            // BLevel
            // 
            this.BLevel.Name = "BLevel";
            this.BLevel.Size = new System.Drawing.Size(14, 17);
            this.BLevel.Text = "B";
            // 
            // panelContainer
            // 
            this.panelContainer.AllowDrop = true;
            this.panelContainer.AutoSize = true;
            this.panelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContainer.Location = new System.Drawing.Point(221, 90);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(0, 0);
            this.panelContainer.TabIndex = 6;
            this.panelContainer.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 434);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "VO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transformarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trazosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Brillo;
        private System.Windows.Forms.Label Contraste;
        private System.Windows.Forms.Label MinMax;
        private System.Windows.Forms.Label Tamaño;
        private System.Windows.Forms.Label Entropia;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.ToolStripMenuItem guardarImagenToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem absolutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acumuladoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel positionx;
        private System.Windows.Forms.ToolStripStatusLabel positiony;
        private System.Windows.Forms.ToolStripStatusLabel RLevel;
        private System.Windows.Forms.ToolStripStatusLabel GLevel;
        private System.Windows.Forms.ToolStripStatusLabel BLevel;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.ToolStripMenuItem monocromoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trazosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brilloYContrasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especificaciónHistogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecualizaciónHistogramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correcciónGammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diferenciaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalizaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesGeométricasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espejoVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espejoHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traspuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionesSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ºToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ºToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem poToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escaladoToolStripMenuItem;
    }
}

