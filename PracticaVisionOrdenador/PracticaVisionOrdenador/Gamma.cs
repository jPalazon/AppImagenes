using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vision
{
    public partial class Gamma : Form
    {
        private Bitmap bmp_;
        public Gamma()
        {
            InitializeComponent();
        }

        public Gamma(Bitmap bmp)
        {
            InitializeComponent();
            bmp_ = new Bitmap(bmp);
        }

        private void textBoxGamma_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar) || (Char.IsPunctuation(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if ((textBoxGamma.Text != String.Empty) && (textBoxGamma.Text != "0"))
            {

                ImageForm image = new ImageForm();
                image.MdiParent = this.MdiParent;
                image.Gamma(Convert.ToDouble(textBoxGamma.Text), bmp_);
                image.Show();
            }
        } 






    }
}
