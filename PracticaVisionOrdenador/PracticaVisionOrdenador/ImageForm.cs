using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Vision
{


    public partial class ImageForm : Form
    {
        
        private double[] R_ = new double[256];
        private double[] G_ = new double[256];
        private double[] B_ = new double[256];
        private double brightness_ = 0;
        private double entropy_ = 0;
        private double contrast_= 0;
        private double height_ = 0;
        private double width_ = 0;
        private double[] MinMax = new double[6];
        private bool monocrom_ = true;
        private Bitmap picture_;
        // atributos para la seleccion de un trozo de la imagen 
        private bool seleccionar = false;
        private Point PuntoInicio;
        private Point PuntoFin;
  


        /*
         * Metodos get and set
        */
        public double[] getR() { return R_; }
        public double[] getG() { return G_; }
        public double[] getB() { return B_; }
        public double getEntropy() { return entropy_; }
        public double getBrightness() { return brightness_; }
        public double getContrast() { return contrast_; }
        public double getWidth() { return width_; }
        public double getHeigth() { return height_; }
        public double getMinMax(int i) { return MinMax[i]; }
        public bool getMonocrom() { return monocrom_; }
        public Bitmap getPicture() { return picture_; }
        public void setPicture(Bitmap p) { picture_ = p; }


        public ImageForm()
        {
            InitializeComponent();
            this.AutoSize = true;
            for (int i = 0; i < MinMax.Length; i++)
            {
                if ((i % 2) == 0)
                    MinMax[i] = 255;
                else
                    MinMax[i] = 0;
            }
        }


        public void AssignAtributtes(Bitmap Picture)
        {
            picture_ = new Bitmap (Picture);
            
            width_ = Picture.Width;
            height_ = Picture.Height;
            for (int x = 0; x < Picture.Width; x++)
            {
                for (int y = 0; y < Picture.Height; y++)
                {

                    R_[Picture.GetPixel(x, y).R]++;
                    G_[Picture.GetPixel(x, y).G]++;
                    B_[Picture.GetPixel(x, y).B]++;

                    CheckMonocrom(Picture, x, y);
                    CheckMinMax(Picture, x, y);
                }
            }
            this.pictureBox1.Image = (Image)Picture;
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }

        /// <summary>
        /// Comprobar min and max
        /// </summary>
        /// <param name="Dir"></param>

        public void CheckMinMax(Bitmap Picture, int x, int y)
        {
            if (Picture.GetPixel(x, y).R < MinMax[0])
                MinMax[0] = Picture.GetPixel(x, y).R;
            if (Picture.GetPixel(x, y).R > MinMax[1])
                MinMax[1] = Picture.GetPixel(x, y).R;
            if (Picture.GetPixel(x, y).G < MinMax[2])
                MinMax[2] = Picture.GetPixel(x, y).G;
            if (Picture.GetPixel(x, y).G > MinMax[3])
                MinMax[3] = Picture.GetPixel(x, y).G;
            if (Picture.GetPixel(x, y).B < MinMax[4])
                MinMax[4] = Picture.GetPixel(x, y).B;
            if (Picture.GetPixel(x, y).B > MinMax[5])
                MinMax[5] = Picture.GetPixel(x, y).B;
        }

        public void CheckMonocrom(Bitmap Picture, int x, int y)
        {
            if ((monocrom_) &&
               (Picture.GetPixel(x, y).R != Picture.GetPixel(x, y).G) &&
               (Picture.GetPixel(x, y).R != Picture.GetPixel(x, y).B) &&
               (Picture.GetPixel(x, y).G != Picture.GetPixel(x, y).B))
                monocrom_ = false;
        }



        public void OpenImage(String Dir)
        {

            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
         
            Bitmap Picture = new Bitmap(Dir);
            picture_ = Picture;
            pictureBox1.Image = (Image)Picture;
            width_ = Picture.Width;
            height_ = Picture.Height;

            for (int x = 0; x < Picture.Width; x++)
            {
                for (int y = 0; y < Picture.Height; y++)
                {

                    R_[Picture.GetPixel(x, y).R]++;
                    G_[Picture.GetPixel(x, y).G]++;
                    B_[Picture.GetPixel(x, y).B]++;
                    CheckMinMax(Picture, x, y);
                    CheckMonocrom(Picture, x, y);
                }

            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }

        public void save(System.IO.FileStream fs, ImageFormat imageFormat)
        { 
            pictureBox1.Image.Save(fs, imageFormat);
            MessageBox.Show("Imagen guardada");


        }

        /*
         * 
         * 
         * PARTE DEL CÓDIGO PARA SELECCIONAR UNA IMAGEN
         * 
         * 
         * */

        /// <summary>
        /// Codigo 
        /// </summary>
        /// <param name="Absolute"></param>

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            MainForm mf = (MainForm)ParentForm;
            Point pos = MousePosition;
            Point posPictureBox = this.pictureBox1.PointToClient(pos);
            if ((picture_ != null) && 
                (posPictureBox.Y <= picture_.Height) && 
                (posPictureBox.X <= picture_.Width) && 
                (posPictureBox.Y >= 0) && 
                (posPictureBox.X >= 0)) 
            {
                double rLevel = picture_.GetPixel(posPictureBox.X, posPictureBox.Y).R;
                double gLevel = picture_.GetPixel(posPictureBox.X, posPictureBox.Y).G;
                double bLevel = picture_.GetPixel(posPictureBox.X, posPictureBox.Y).B;
                mf.writeStatusLabel(posPictureBox.X, posPictureBox.Y, rLevel, gLevel, bLevel);
            }
        }
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {
                this.Cursor = System.Windows.Forms.Cursors.Cross;
                seleccionar = true;
                PuntoInicio = new Point(e.X, e.Y);
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (seleccionar)
            {
                PuntoFin = new Point(e.X, e.Y);
                int anchoRectangulo = PuntoFin.X - PuntoInicio.X;
                int  alturaRectangulo = PuntoFin.Y- PuntoInicio.Y;
                Rectangle RectanguloSeleccion = new Rectangle(PuntoInicio.X, PuntoInicio.Y, anchoRectangulo, alturaRectangulo);
                Graphics objGrafico = this.pictureBox1.CreateGraphics();
                Pen pen = new Pen(Color.Red, 1);
                float[] valoresLineaDiscontinua = { 3, 2, 3, 2 };
                pen.DashPattern = valoresLineaDiscontinua;
                objGrafico.DrawRectangle(pen, RectanguloSeleccion);
                
                ImageForm smallImage = new ImageForm();
                smallImage.seleccion(this.picture_, PuntoInicio, PuntoFin, RectanguloSeleccion);
                smallImage.MdiParent = this.MdiParent;
                smallImage.Show();
            }
        }

        public void seleccion(Bitmap Picture, Point StartPoint, Point EndPoint, Rectangle Rectangulo)
        {
            this.picture_ = new Bitmap(Rectangulo.Width, Rectangulo.Height, Picture.PixelFormat);
            
            width_ = Rectangulo.Width;
            height_ = Rectangulo.Height;
            int contadorx = 0;
            int contadory = 0;
            for (int x = StartPoint.X; x < EndPoint.X; x++)
            {
                for (int y = StartPoint.Y; y < EndPoint.Y; y++)
                {

                    Color Grey =  Color.FromArgb(Picture.GetPixel(x, y).R, Picture.GetPixel(x, y).G, Picture.GetPixel(x, y).B);
                    picture_.SetPixel(contadorx, contadory, Grey);
                    R_[Picture.GetPixel(x, y).R]++;
                    G_[Picture.GetPixel(x, y).G]++;
                    B_[Picture.GetPixel(x, y).B]++;
                    CheckMinMax(picture_, contadorx, contadory);
                    contadory++;
                }
                contadorx++;
                contadory = 0;
            }
            this.pictureBox1.Image = (Image)this.picture_;
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }




    /*
    * 
    * FIN
    * 
    * */





        public void showHistogram(bool Absolute)
        {

                HistogramForm Histograma = new HistogramForm(R_, G_, B_, monocrom_, Absolute);
                Histograma.MdiParent = this.MdiParent;
                Histograma.Show();
        }

        public void calculateEntropy()
        {
            double P  = 0;
            for (int i = 0; i <= 255; i++)
            {
                if (R_[i] > 0)
                {
                    P = R_[i] / (height_ * width_);
                    double log = Math.Log(P);
                    entropy_ += P * log;
                }
            }
            entropy_ = -Math.Round(entropy_,3);
        }


        public void calculateBrightness()
        {
            for (int i = 0; i <= 255; i++)
            {
                brightness_ += R_[i] * i;

            }
            brightness_ = Math.Round( (1 / (height_ * width_)) * brightness_, 3);


        }

        public void calculateConstrast()
        {
            for (int i = 0; i <= 255; i++)
            {
                contrast_ += (Math.Pow((i - brightness_), 2)) * R_[i];
            }
            contrast_ = Math.Round(Math.Sqrt((1 / (height_ * width_)) * contrast_), 3);
        
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm mf =  (MainForm)ParentForm;
            mf.writePanel();

        }



        /*
         metodo para pasar a monocromo
         
         * */


        public void toMonocrom(Bitmap picture)
        {
            monocrom_ = true;

            picture_ = new Bitmap(picture);  //no olvidar hacer el new del bitmap
            Color Grey;
            width_ = picture.Width;
            height_ = picture.Height;

            for (int x = 0; x < picture_.Width; x++)
            {
                for (int y = 0; y < picture_.Height; y++)
                {
                    double tempR = picture.GetPixel(x, y).R * 0.299;
                    double tempG = picture.GetPixel(x, y).G * 0.587;
                    double tempB = picture.GetPixel(x, y).B * 0.114;
                    int temp = (int)(tempR + tempG + tempB);
                    Grey = Color.FromArgb(temp, temp, temp);
                    picture_.SetPixel(x, y, Grey);
                    R_[temp]++;
                    G_[temp]++;
                    B_[temp]++;

                    CheckMinMax(picture_, x, y);
                }
            }
           
            this.pictureBox1.Image = (Image)picture_;
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();

        }




        /// <summary>
        /// función que carga en el image form la imagen por tramos
        /// </summary>
        /// <param name="dat"></param>
        /// <param name="ntrames"></param>
        /// <param name="p"></param>



        public void loadTrames(int[] dat, int ntrames, Bitmap p)
        {
           
            double[] lut = new double[256];
            for (int i = 0; i < ntrames; i++)
            {
                double min = dat[i*4];
                double max = dat[i*4+1];
                int l =  dat[i*4+2];
                int h = dat[i * 4 + 3];
                double a = (h-l)/(max-min);
                double b = l-a*min;
               
                if (min == max)
                    max++;
                for (int j = (int)min; j <= max; j++)
                {
                    
                    double temp = Math.Ceiling((a * (j) + b )+0.5);
                    if (temp > 255)
                        lut[j] = 255;
                    else
                        if (temp < 0)
                            lut[j] = 0;
                        else
                            lut[j] = temp;
                  

                }
            }
           
            picture_ = new Bitmap(p);
            width_ = p.Width;
            height_ = p.Height;

            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {
                    int temp = (int)lut[picture_.GetPixel(x, y).R];
                    Color Grey = Color.FromArgb(temp, temp, temp);
                    picture_.SetPixel(x, y, Grey);
                    R_[temp]++;
                    G_[temp]++;
                    B_[temp]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            this.pictureBox1.Image = (Image)picture_;
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }

        public void loadbc(double b, double c, double newb, double newc, Bitmap p)
        {
            double[] lut = new double[256];
            double A = newc/c;
            double B = newb - A * b;
            for (int i = 0; i <= 255; i++)
            {
                double temp = Math.Ceiling((A * i + B) + 0.5);
                if (temp > 255)
                    lut[i] = 255;
                else
                    if (temp < 0)
                        lut[i] = 0;
                    else
                        lut[i] = temp;


            }
            picture_ = new Bitmap(p);
            width_ = p.Width;
            height_ = p.Height;

            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {

                    int temp = (int)lut[picture_.GetPixel(x, y).R];
                    Color Grey = Color.FromArgb(temp, temp, temp);
                    picture_.SetPixel(x, y, Grey);
                    R_[temp]++;
                    G_[temp]++;
                    B_[temp]++;
                    CheckMinMax(picture_, x, y);

                }
            }
            this.pictureBox1.Image = (Image)picture_;
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();

        }

        public void HistogramSpecification(String dir, double[] ho, Bitmap bmpo)
        {
            OpenImage(dir);
            int m = 256;
            double[] po = new double[m];
            double[] pr = new double[m];
/*
            if ((bmpo.Width != width_) || (bmpo.Height != height_))
            {
                for (int i = 0; i < m; i++)
                {
                    po[i] = ho[i] / (bmpo.Height*bmpo.Width);
                    pr[i] = R_[i] / (width_ * height_);
                }
            }

            for (int i = 1; i < m; i++)
            {
                po[i] = (ho[i] + po[i - 1]) ;
                pr[i] = (R_[i] + pr[i - 1]);
             }
*/
            double n1 = 0; // imagen original
            double n2 = 0; // imagen referencia
            for (int i = 0; i < 256; i++)
            {
                n1 += ho[i];
                n2 += R_[i];
            }
            double c1 = 0;
            double c2 = 0;
            for (int i = 0; i < 256; i++)
            {
                c1 += ho[i];
                c2 += R_[i];
                po[i] = c1 / n1;
                pr[i] = c2 / n2;
            }


            double[] lut = new double[256];
            int j = m - 1;
            for (int i = 0; i <= 255; i++)
            {
                j = m - 1;
                do
                {
                    lut[i] = j;
                    j--;
                } while ((j>=0) && (po[i] <= pr[j]));

            }


            ImageForm SpecificationImage = new ImageForm();
            SpecificationImage.MdiParent = this.MdiParent;
            Bitmap SpecificationBmp= new Bitmap(bmpo);


            for (int x = 0; x < bmpo.Width; x++)
            {
                for (int y = 0; y < bmpo.Height; y++)
                {

                    int temp = (int)lut[bmpo.GetPixel(x, y).R];
                    Color Grey = Color.FromArgb(temp, temp, temp);
                    SpecificationBmp.SetPixel(x, y, Grey);
                }
            }
            SpecificationImage.AssignAtributtes(SpecificationBmp);
            SpecificationImage.Show();


        }


        public void Ecualization()
        {
            double k = (width_ * height_)/256;
            double[] C = new double[256];
            double[] lut = new double[256];
            C[0] = R_[0];
            for (int i = 1; i < 256; i++)
            {
                C[i] = (R_[i] + C[i - 1]);

            }
            for (int i = 0; i <= 255; i++)
            {
                lut[i] = Math.Max(0, (Math.Round(C[i] / k) - 1));

            }

            ImageForm EcualizationImage = new ImageForm();
            EcualizationImage.MdiParent = this.MdiParent;
            Bitmap EcualizationBmp = new Bitmap(picture_);


            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {

                    int temp = (int)lut[picture_.GetPixel(x, y).R];
                    Color Grey = Color.FromArgb(temp, temp, temp);
                    EcualizationBmp.SetPixel(x, y, Grey);
                }
            }
            EcualizationImage.AssignAtributtes(EcualizationBmp);
            //SpecificationImage.pictureBox1.Image = (Image)(SpecificationBmp);
            EcualizationImage.Show();

        }

        /// <summary>
        /// Crear Imagen con correción gamma
        /// </summary>
        /// <param name="g"></param>
        /// <param name="bmpo"></param>
        /// 
        public void Gamma(double g, Bitmap bmpo)
        {
            int k = 256;
            double aMax = k - 1;
            double[] lut = new double[256];
            double a, bp, b;
            for (int i = 0; i <= 255; i++)
            {
                a = ((double)i / 255);
                bp = Math.Pow(a, g);
                b = Math.Round(bp * aMax);
                lut[i] = b;
            }

            CreateImageUsingLut(bmpo, lut);
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        
        }



        public void DifferencePart1(Bitmap bmpo, Bitmap bmpn)
        {
            
            picture_ = new Bitmap(bmpo);
            width_ = bmpo.Width;
            height_ = bmpo.Height;

            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {

                    int temp = Math.Abs(bmpo.GetPixel(x, y).R - bmpn.GetPixel(x,y).R);
                    Color color = Color.FromArgb(temp, temp, temp);
                    picture_.SetPixel(x, y, color);
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);

                }
            }

            this.pictureBox1.Image = (Image)(picture_);
            HistogramForm h = new HistogramForm(R_, G_, B_, true, true, bmpo, picture_);
            h.MdiParent = this.MdiParent;
            h.Show();

        }

        public void DifferencePart2(Bitmap bmpo, Bitmap bmpDifference, double t)
        {

            width_ = bmpo.Width;
            height_ = bmpo.Height;
            picture_ = new Bitmap(bmpo);
            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {
                    if (bmpDifference.GetPixel(x, y).R > t)
                        picture_.SetPixel(x, y, Color.Red);
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            this.pictureBox1.Image = (Image)(picture_);
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }





        /// <summary>
        /// crear imagen pasandole el bitmap de la imagen y la tabla lut
        /// </summary>
        /// <param name="bmpo"></param>
        /// <param name="lut"></param>

        public void CreateImageUsingLut(Bitmap bmpo, double[] lut)
        {

            picture_ = new Bitmap(bmpo);
            width_ = bmpo.Width;
            height_ = bmpo.Height;

            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {

                    int temp = (int)lut[picture_.GetPixel(x, y).R];
                    Color Grey = Color.FromArgb(temp, temp, temp);
                    picture_.SetPixel(x, y, Grey);
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMinMax(picture_, x, y);
                    CheckMonocrom(picture_, x, y);

                }
            }

            this.pictureBox1.Image = (Image)(picture_);

        }

        /// <summary>
        /// Muestreo de la imagen 
        /// </summary>
        /// <param name="bmpo"></param>
        /// <param name="sampleValue"></param>


        public void samplingImage(Bitmap bmpo, int sampleValue)
        {
            picture_ = new Bitmap(bmpo);
            height_ = bmpo.Height;
            width_ = bmpo.Width;
            for (int x = 0; x < width_ - sampleValue; x = x + sampleValue)
            {
                for (int y = 0; y < height_ - sampleValue; y = y + sampleValue)
                {
                    double mean = 0;
                    for (int i = 0; i < sampleValue; i++)
                    {
                        for (int j = 0; j < sampleValue; j++)
                        {
                            mean += bmpo.GetPixel(x + i, y + j).R;
                        }
                    }
                    mean =  Math.Round (mean/(Math.Pow(sampleValue, 2)));
                    Color Grey = Color.FromArgb((int)mean, (int)mean, (int)mean);

                    for (int i = 0; i < sampleValue; i++)
                    {
                        for (int j = 0; j < sampleValue; j++)
                        {
                             picture_.SetPixel(x + i, y + j, Grey);
                             R_[picture_.GetPixel(x + i, y + j).R]++;
                             G_[picture_.GetPixel(x + i, y + j).G]++;
                             B_[picture_.GetPixel(x + i, y + j).B]++;
                             CheckMinMax(picture_,x + i, y + j);
                             CheckMonocrom(picture_, x + i, y + j);
                        }
                    }

                }
            }
            this.pictureBox1.Image = (Image)(picture_);
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }


        /// <summary>
        ///  Cuantización de la imagen
        /// </summary>
        /// <param name="bmpo"></param>
        /// <param name="quantizeValue"></param>

        public void quantizationImage(Bitmap bmpo, int quantizeValue)
        {
            double numLevels = Math.Pow(2, quantizeValue);
            double difLevel = (255 / (numLevels - 1));
            int range = (int)Math.Ceiling((double)(256 / numLevels));
            double[] lut = new double[256];
            for (int i = 0; i < numLevels; i++)
            {
                double mapValue = Math.Round(i * difLevel);
                int superiorTrame = range * (i + 1);
                int inferiorTrame = range * i;
                for (int j = inferiorTrame; j < superiorTrame; j++)
                {
                    lut[j] = mapValue;
                }
            }

            CreateImageUsingLut(bmpo, lut);
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
        }




        ///// OPERACIONES GEOMÉTRICAS

        public void vertical (Bitmap bmpo)
        {
            AssignAtributtes(bmpo);

            for (int x = 0; x < (bmpo.Width); x++)
            {
                for (int y = 0; y < (bmpo.Height/2); y++)
                {
                    Color temp = bmpo.GetPixel(x, y);
                    picture_.SetPixel(x, y, bmpo.GetPixel(x, ((bmpo.Height - 1) -y)));
                    picture_.SetPixel(x, ((bmpo.Height - 1) -y), temp);
                }
            }
            this.pictureBox1.Image = (Image)picture_;

        }


        public void horizontal (Bitmap bmpo)
        {
            AssignAtributtes(bmpo);

            for (int x = 0; x < (bmpo.Width/2); x++)
            {
                for (int y = 0; y < bmpo.Height; y++)
                {
                    Color temp = bmpo.GetPixel(x, y);
                    picture_.SetPixel(x, y, bmpo.GetPixel((bmpo.Width-1) - x, y));
                    picture_.SetPixel((bmpo.Width - 1) - x, y, temp);
                }
            }
            this.pictureBox1.Image = (Image)picture_;
        }

        public void transposition(Bitmap bmpo)
        {

            width_ = bmpo.Height;
            height_ = bmpo.Width;
            picture_ = new Bitmap(bmpo.Height, bmpo.Width);


            for (int x = 0; x < bmpo.Width; x++)
            {
                for (int y = 0; y < bmpo.Height; y++)
                {                
                    picture_.SetPixel(y, x, bmpo.GetPixel(x, y));
                    R_[picture_.GetPixel(y, x).R]++;
                    G_[picture_.GetPixel(y, x).G]++;
                    B_[picture_.GetPixel(y, x).B]++;
                    CheckMinMax(picture_, y, x);
                    CheckMonocrom(picture_, y, x);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;

        }


        public void rotation90(Bitmap bmpo)
        {

            width_ = bmpo.Height;
            height_ = bmpo.Width;
            picture_ = new Bitmap(bmpo.Height, bmpo.Width);


            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {
                    picture_.SetPixel(x, y, bmpo.GetPixel((bmpo.Width -1 )- y, x));
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }


        public void rotation180(Bitmap bmpo)
        {

            width_ = bmpo.Width;
            height_ = bmpo.Height;
            picture_ = new Bitmap(bmpo.Width, bmpo.Height);


            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {
                    picture_.SetPixel(x, y, bmpo.GetPixel((bmpo.Width - 1) - x, (bmpo.Height - 1) - y));
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }



        public void rotation270(Bitmap bmpo)
        {

            width_ = bmpo.Height;
            height_ = bmpo.Width;
            picture_ = new Bitmap(bmpo.Height, bmpo.Width);


            for (int x = 0; x < width_; x++)
            {
                for (int y = 0; y < height_; y++)
                {
                    picture_.SetPixel(x, y, bmpo.GetPixel((bmpo.Width - 1) - y, (bmpo.Height - 1) - x));
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }



        public void bilinealEscalating(Bitmap bmpo, int newSizeWidth, int newSizeHeight, double escalateValueX, double escalateValueY)
        {
            int newx;
            int newy;
            double p;
            double q;
            int A, B, C, D;
            double Q, R, P;
            Color finalColor;
            height_ = newSizeHeight;
            width_ = newSizeWidth;
            picture_ = new Bitmap(newSizeWidth, newSizeHeight);
            for (int x = 0; x < newSizeWidth; x++)
            {
                for (int y = 0; y < newSizeHeight; y++)
                {
                    newx = (int)Math.Floor(x / escalateValueX);
                    newy = (int)Math.Floor(y / escalateValueY);
                    p = (x / escalateValueX) - newx;
                    q = (y / escalateValueY) - newy;

                    int Xp = 0;
                    int Yp = 0;
                    if (newx >= bmpo.Width - 1)
                        Xp = newx;
                    else
                        Xp = newx + 1;

                    if (newy >= bmpo.Height - 1)
                        Yp = newy;
                    else
                        Yp = newy + 1;
         
                        A = bmpo.GetPixel(newx, Yp).R;
                        B = bmpo.GetPixel(Xp, Yp).R;
                        C = bmpo.GetPixel(newx, newy).R;
                        D = bmpo.GetPixel(Xp, newy).R;


                    Q = A + (B - A) * p;
                    R = C + (D - C) * p;
                    P = R + (Q-R) *q ;
                    finalColor = Color.FromArgb((int)P, (int)P, (int)P);
                    picture_.SetPixel(x, y, finalColor);
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }




        public void vmpEscalating(Bitmap bmpo, int newSizeWidth, int newSizeHeight, double escalateValueX, double escalateValueY)
        {
            int newx;
            int newy;
            height_ = newSizeHeight;
            width_ = newSizeWidth;
            picture_ = new Bitmap(newSizeWidth, newSizeHeight);
            for (int x = 0; x < newSizeWidth; x++)
            {
                for (int y = 0; y < newSizeHeight; y++)
                {
                    newx = (int)Math.Round(x / escalateValueX);
                    newy = (int)Math.Round(y / escalateValueY);
                    if (newx >= bmpo.Width)
                        newx = newx - 1;
                    if (newy >= bmpo.Height)
                        newy = newy - 1;

                    picture_.SetPixel(x, y, bmpo.GetPixel(newx, newy));
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }


        public void rotationValue(Bitmap bmpo, double rValue, String method)
        {         
            double[] O = new double[2] {0, 0};
            double[] F = new double[2] {bmpo.Width-1, 0};
            double[] G = new double[2] {bmpo.Width - 1, bmpo.Height - 1};
            double[] H = new double[2] {0, bmpo.Height - 1};
            double[] Op = new double[2];
            double[] Fp= new double[2];
            double[] Gp = new double[2];
            double[] Hp = new double[2];
            double rValueRad = Math.PI * (rValue / 180);
            double[,] R = {{Math.Cos(rValueRad), -Math.Sin(rValueRad)}, {Math.Sin(rValueRad), Math.Cos(rValueRad)}};
            double[,] Rp = {{ Math.Cos(rValueRad), Math.Sin(rValueRad) }, {-Math.Sin(rValueRad), Math.Cos(rValueRad)}};
            Fp = mul(F, R);
            Gp = mul(G, R);
            Hp = mul(H, R);

            Op[0] = Math.Min(Fp[0], Math.Min(Gp[0], Math.Min(O[0], Hp[0])));
            Op[1] = Math.Min(Fp[1], Math.Min(Gp[1], Math.Min(O[1], Hp[1])));
            int newWidth = (int)((Math.Max(Fp[0], Math.Max(Gp[0], Math.Max(O[0], Hp[0]))) - Op[0]) + 1 );
            int newHeight = (int)((Math.Max(Fp[1], Math.Max(Gp[1], Math.Max(O[1], Hp[1]))) -Op[1]) + 1);
            width_ = newWidth;
            height_ = newHeight;
            picture_ = new Bitmap(newWidth, newHeight);
            double[] xy = new double[2];
            double[] OOp = new double[2];
            for (int xp = 0; xp < newWidth; xp++)
            {
                for (int yp = 0; yp < newHeight; yp++)
                {
                    OOp[0] = Op[0]-O[0];
                    OOp[1] = Op[1]-O[1];
                    double xvalue = (xp + OOp[0]);
                    double yvalue = (yp + OOp[1]);
                    xy[0] = xvalue;
                    xy[1] = yvalue;
                    xy = mul(xy, Rp);
                    if ((xy[0] >= bmpo.Width) || (xy[0] < 0) || (xy[1] >= bmpo.Height) || (xy[1] < 0))
                        picture_.SetPixel(xp, yp, Color.White);
                    else
                    {
                        if (String.Equals(method, "Bilineal"))
                            picture_.SetPixel(xp, yp, bilinealRotation(bmpo, xy[0], xy[1]));
                        else
                            picture_.SetPixel(xp, yp, vmpRotation(bmpo, xy[0], xy[1]));

                        R_[picture_.GetPixel(xp, yp).R]++;
                        G_[picture_.GetPixel(xp, yp).G]++;
                        B_[picture_.GetPixel(xp, yp).B]++;
                        CheckMonocrom(picture_, xp, yp);
                        CheckMinMax(picture_, xp, yp);
                    }
                }
            }

            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }



        public Color bilinealRotation(Bitmap bmpo, double x, double y)
        {
            int newx = (int)Math.Floor(x);
            int newy = (int)Math.Floor(y);
            double p = x - newx;
            double q = y - newy;

            int Xp = 0;
            int Yp = 0;
            if (newx >= bmpo.Width - 1)
                Xp = newx;
            else
                Xp = newx + 1;

            if (newy >= bmpo.Height - 1)
                Yp = newy;
            else
                Yp = newy + 1;

            int A = bmpo.GetPixel(newx, Yp).R;
            int B = bmpo.GetPixel(Xp, Yp).R;
            int C = bmpo.GetPixel(newx, newy).R;
            int D = bmpo.GetPixel(Xp, newy).R;


            double Q = A + (B - A) * p;
            double R = C + (D - C) * p;
            int P = (int)(R + (Q - R) * q);
            Color finalColor = Color.FromArgb(P, P, P);
            return finalColor;
        }

        public Color vmpRotation(Bitmap bmpo, double x , double y)
        {
            int newx = (int)Math.Round(x);
            if (newx >= bmpo.Width)
                newx = newx - 1;
            int newy = (int)Math.Round(y);
            if (newy >= bmpo.Height)
                newy = newy - 1;
            return bmpo.GetPixel(newx, newy);
        }


        public double[] mul(double[] v, double[,] m)
        {
            double[] result = new double[2];
            result[0] = v[0] * m[0, 0] + v[1] * m[0, 1];
            result[1] = v[0] * m[1, 0] + v[1] * m[1, 1];
            return result;
        }

        ///// PARTE  DE FILTROS



        // método filtros desde interfaz
        public void applyFilter (Bitmap bmpo, double[,] kernel, int r, int c, double normalizeValue)
        {
            picture_ = new Bitmap(bmpo);
            height_ = bmpo.Height;
            width_ = bmpo.Width;
            int rows = (r/2);
            int columns = (c/2);
            Color color;
            double s = 1/normalizeValue;
            for (int x = columns; x < width_ - columns; x++)
            {
                for (int y = rows; y < height_- rows; y++)
                {
                    double sum = 0;
                    for (int i = -columns; i <= columns; i++)
                    {

                        for (int j = -rows; j <= rows; j++)
                        {
                            double cosa = bmpo.GetPixel(x + i, y + j).R;
                            sum = sum + bmpo.GetPixel(x+i,y+j).R * kernel[j+rows,i+columns];
                            
                        }

                    }
                    int q = (int)(sum*s);
                    if (q > 255)
                        q = 255;
                    if (q < 0)
                        q = 0;
                    color = Color.FromArgb(q,q,q);
                    picture_.SetPixel(x, y, color);
                    R_[picture_.GetPixel(x, y).R]++;
                    G_[picture_.GetPixel(x, y).G]++;
                    B_[picture_.GetPixel(x, y).B]++;
                    CheckMonocrom(picture_, x, y);
                    CheckMinMax(picture_, x, y);
                }
            }
            calculateEntropy();
            calculateBrightness();
            calculateConstrast();
            this.pictureBox1.Image = (Image)picture_;
        }


    }

}