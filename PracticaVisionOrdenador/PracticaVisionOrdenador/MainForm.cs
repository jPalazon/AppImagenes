using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Vision
{
    public partial class MainForm : Form
    {
        private Bitmap p_;
        private int umbral_ = 0;

        public MainForm()
        {
            InitializeComponent();
            panel1.Visible = true;
        }

        public void setUmbral(int t) { umbral_ = t; }
        public int getUmbral() { return umbral_; }


        private void abrirImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFile = new OpenFileDialog();
            OpenFile.Filter = " Archivos JPEG(*.jpg)|*.jpg| Archivos TIFF(*.tif, *.tiff)|*.tif; *.tiff";
            OpenFile.InitialDirectory = "C:\\Users\\Jose\\Desktop\\Imagenes";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                ImageForm ImageForm = new ImageForm();
                ImageForm.MdiParent = this;
                ImageForm.Show();
                String Dir = OpenFile.FileName;
                ImageForm.Text = Dir;
                ImageForm.OpenImage(Dir);
                writePanel();

            }

        }


        private void guardarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm Image = (ImageForm)ActiveMdiChild;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "JPeg Image |*.jpg|Bitmap Image|*.Tiff|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        Image.save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        Image.save(fs,
                           System.Drawing.Imaging.ImageFormat.Tiff);
                        break;

                    case 3:
                        Image.save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }

        }


        public void writePanel()
        {
            ImageForm Image = (ImageForm)ActiveMdiChild;
            this.Entropia.Text = Image.getEntropy().ToString();
            string ext = Path.GetExtension(Image.Text);
            this.Tipo.Text = ext;
            this.Brillo.Text = Image.getBrightness().ToString();
            this.Contraste.Text = Image.getContrast().ToString();
            if (Image.getMonocrom())
                this.MinMax.Text = Image.getMinMax(0) + "/" + Image.getMinMax(1);
            else
                this.MinMax.Text = "R" + Image.getMinMax(0) + "/" + Image.getMinMax(1) +
                                   " G" + Image.getMinMax(2) + "/" + Image.getMinMax(3) +
                                   " B" + Image.getMinMax(4) + "/" + Image.getMinMax(5);

            this.Tamaño.Text = Image.getWidth() + "x" + Image.getHeigth();

        }


        private void informaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.panel1.Visible = true;
        }


        /// <summary>
        /// boton de cerrar el panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void absolutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm Image = (ImageForm)ActiveMdiChild;
            Image.showHistogram(true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>



        private void acumuladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm Image = (ImageForm)ActiveMdiChild;
            Image.showHistogram(false);


        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="posx"></param>
        /// <param name="posy"></param>
        /// <param name="RLevel"></param>
        /// <param name="GLevel"></param>
        /// <param name="BLevel"></param>

        public void writeStatusLabel(double posx, double posy, double RLevel, double GLevel, double BLevel)
        {
            this.positionx.Text = "x: " + posx;
            this.positiony.Text = "y: " + posy;
            this.RLevel.Text = "R: " + RLevel;
            this.GLevel.Text = "G: " + GLevel;
            this.BLevel.Text = "B: " + BLevel;
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="formHijo"></param>


        private void monocromoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm Image2 = new ImageForm();
                Image2.Text = "Imagen en monocromo";
                Image2.MdiParent = this;
                Image2.toMonocrom(Image1.getPicture());
                Image2.Show();
                writePanel();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }




        private void trazosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                p_ = Image1.getPicture();
                Traces trace = new Traces();
                trace.MdiParent = this;
                trace.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

        public void createImageTrame(int[] dat, int ntrames)
        {

            ImageForm Image2 = new ImageForm();
            Image2.MdiParent = this;
            Image2.Text = "Imagen por tramos";
            Image2.loadTrames(dat, ntrames, p_);
            Image2.Show();
            writePanel();
        }

        private void brilloYContrasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                p_ = Image1.getPicture();
                BCForm bc = new BCForm(Image1.getBrightness(), Image1.getContrast());
                bc.MdiParent = this;
                bc.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }

        /// <summary>
        /// crear form con la imagen con el brillo y el contraste modificados
        /// </summary>
        /// <param name="dat"></param>
        /// <param name="ntrames"></param>

        public void createImageBC(double b, double c, double newb, double newc)
        {

            ImageForm Image2 = new ImageForm();
            Image2.MdiParent = this;
            Image2.Text = "Imagen brillo y contraste modificados";
            Image2.loadbc(b, c, newb, newc, p_);
            Image2.Show();
            writePanel();
        }

        private void especificaciónHistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = " Archivos JPEG(*.jpg)|*.jpg| Archivos TIFF(*.tif, *.tiff)|*.tif; *.tiff";
                OpenFile.InitialDirectory = "C:\\Users\\Jose\\Desktop\\Imagenes";
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    ImageForm ImageForm = new ImageForm();
                    ImageForm.MdiParent = this;
                    ImageForm.Show();
                    String Dir = OpenFile.FileName;
                    ImageForm.Text = Dir;
                    ImageForm.HistogramSpecification(Dir, Image1.getR(), Image1.getPicture());
                    writePanel();

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }


        private void ecualizaciónHistogramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm Image1 = (ImageForm)ActiveMdiChild;
            Image1.Ecualization();
        }

        private void correcciónGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                Gamma g = new Gamma(Image1.getPicture());
                g.MdiParent = this;
                g.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }

        private void diferenciaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = " Archivos JPEG(*.jpg)|*.jpg| Archivos TIFF(*.tif, *.tiff)|*.tif; *.tiff";
                OpenFile.InitialDirectory = "C:\\Users\\Jose\\Desktop\\Imagenes";
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    ImageForm ImageForm = new ImageForm();
                    ImageForm.MdiParent = this;
                    ImageForm.Show();
                    String Dir = OpenFile.FileName;
                    ImageForm.Text = Dir;
                    ImageForm.OpenImage(Dir);
                    ImageForm.Show();
                    ImageForm ImageDifference = new ImageForm();
                    ImageDifference.MdiParent = this;
                    ImageDifference.DifferencePart1(Image1.getPicture(), ImageForm.getPicture());
                    ImageDifference.Show();

                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }

        private void digitalizaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                DigitalizationForm df = new DigitalizationForm(Image1.getPicture());
                df.MdiParent = this;
                df.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }

        private void espejoVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm ImageVertical = new ImageForm();
                ImageVertical.MdiParent = this;
                ImageVertical.vertical(Image1.getPicture());
                ImageVertical.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

        private void espejoHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm ImageHorizontal = new ImageForm();
                ImageHorizontal.MdiParent = this;
                ImageHorizontal.horizontal(Image1.getPicture());
                ImageHorizontal.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

        private void traspuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm ImageTransposition = new ImageForm();
                ImageTransposition.MdiParent = this;
                ImageTransposition.transposition(Image1.getPicture());
                ImageTransposition.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

        /// <summary>
        ///  Rotación de 90
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void ºToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm ImageRotation = new ImageForm();
                ImageRotation.MdiParent = this;
                ImageRotation.rotation90(Image1.getPicture());
                ImageRotation.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }


        /// <summary>
        /// Rotación de 180
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void ºToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm ImageRotation = new ImageForm();
                ImageRotation.MdiParent = this;
                ImageRotation.rotation180(Image1.getPicture());
                ImageRotation.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }

        /// <summary>
        /// Rotación de 270
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ºToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                ImageForm ImageRotation = new ImageForm();
                ImageRotation.MdiParent = this;
                ImageRotation.rotation270(Image1.getPicture());
                ImageRotation.Show();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }

        }

        private void escaladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                EscalatingForm Escalate = new EscalatingForm(Image1.getPicture());
                Escalate.MdiParent = this;
                Escalate.Show();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

        private void poToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                RotationForm rf = new RotationForm(Image1.getPicture());
                rf.MdiParent = this;
                rf.Show();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

        private void filtrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ImageForm Image1 = (ImageForm)ActiveMdiChild;
                FilterForm ff = new FilterForm(Image1.getPicture()); 
                ff.MdiParent = this;
                ff.Show();

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No hay ninguna foto seleccionada");
            }
        }

    } //Fin clase
    
}
