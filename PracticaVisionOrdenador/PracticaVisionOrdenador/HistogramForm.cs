using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Vision
{
    public partial class HistogramForm : Form
    {
        private double[] R_ = new double[256];
        private double[] G_ = new double[256];
        private double[] B_ = new double[256];
        private bool Monocrom = true;
        private bool Absolute = true;
        private Bitmap bitmapToDifference_;
        private Bitmap bmpo_;
        int t_ = 0;

        public HistogramForm(double[] r, double[] g, double[] b, bool monocrom, bool absolute)
        {
            InitializeComponent();
            R_ = r;
            G_ = g;
            B_ = b;
            Monocrom = monocrom;
            Absolute = absolute;
            textBoxT.Visible = false;
            labelT.Visible = false;
            buttonNext.Visible = false;
            
        }



        public HistogramForm(double[] r, double[] g, double[] b, bool monocrom, bool absolute, Bitmap bmpo, Bitmap bmpd)
        {
            InitializeComponent();
            R_ = r;
            G_ = g;
            B_ = b;
            Monocrom = monocrom;
            Absolute = absolute;
            textBoxT.Visible = true;
            labelT.Visible = true;
            buttonNext.Visible = true;
            bitmapToDifference_ = new Bitmap(bmpd);
            bmpo_ = new Bitmap(bmpo);
        }
 

        public HistogramForm()
        {
            InitializeComponent();
        }

        private void HistogramForm_Load(object sender, EventArgs e)
        {
            // Data arrays.
            this.chart1.Titles.Add("Histograma");
             Series series = this.chart1.Series.Add("R");
             Series series2 = this.chart1.Series.Add("G");
             Series series3 = this.chart1.Series.Add("B");
             this.chart1.Palette = ChartColorPalette.None;
            if (!Monocrom)
            {   
                this.chart1.PaletteCustomColors = new Color[] {Color.Red, Color.Green, Color.Blue};

                this.chart1.Legends.Add("R");
                this.chart1.Legends.Add("G");
                this.chart1.Legends.Add("B");
            }
            else
                this.chart1.PaletteCustomColors = new Color[] { Color.Gray };

            //series.ChartTypeName = "Line";
            //Add series
            if (Absolute)
            {
                for (int i = 0; i < 256; i++)
                {

                    // Add point.
                    series.Points.AddY(R_[i]);

                    if (!Monocrom)
                    {
                        series2.Points.AddY(G_[i]);
                        series3.Points.AddY(B_[i]);
                    }
                }
            }
            else
            {
                double aux1 = 0;
                double aux2 = 0;
                double aux3 = 0;
                for (int i = 0; i < 256; i++)
                {

                    // Add point.
                    aux1 += R_[i];
                    series.Points.AddY(aux1);

                    if (!Monocrom)
                    {
                        aux2 += G_[i];
                        aux3 += B_[i];
                        series2.Points.AddY(aux2);
                        series3.Points.AddY(aux3);
                    }
                }
            }
        }
        private void textBoxT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar)|| (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }


        private void buttonNext_Click_1(object sender, EventArgs e)
        {

            if ((textBoxT.Text != String.Empty) && (textBoxT.Text != "0"))
            {
                t_ = (Convert.ToInt32(textBoxT.Text));
                ImageForm i = new ImageForm();
                i.MdiParent = this.MdiParent;
                i.DifferencePart2(bmpo_, bitmapToDifference_, t_);
                i.Show();
            }
        }


    }
}
