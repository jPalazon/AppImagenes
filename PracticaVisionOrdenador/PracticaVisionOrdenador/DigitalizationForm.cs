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
    public partial class DigitalizationForm : Form
    {
        private Bitmap bmp_;

        public DigitalizationForm()
        {
            InitializeComponent();
        }


        public DigitalizationForm(Bitmap bmpo)
        {
            InitializeComponent();
            bmp_ = new Bitmap (bmpo);
        }


        private void textBoxQuantize_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(e);
        }

        private void textBoxSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(e);
        }


        private void OnlyDigit(KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números 
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
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
            
            if ((textBoxSample.Text == String.Empty) && (textBoxQuantize.Text == String.Empty))
                MessageBox.Show("Especifica algún valor para el muestreo o la cuantización");
            else
            {
                ImageForm digitalImage = new ImageForm();
                digitalImage.MdiParent = this.MdiParent;

                if ((textBoxSample.Text != String.Empty) && (textBoxQuantize.Text != String.Empty))
                {
                    digitalImage.samplingImage(bmp_, Convert.ToInt32(textBoxSample.Text));
                    digitalImage.quantizationImage(digitalImage.getPicture(), Convert.ToInt32(textBoxQuantize.Text));
                }
                else
                    if (textBoxQuantize.Text != String.Empty)
                        digitalImage.quantizationImage(bmp_, Convert.ToInt32(textBoxQuantize.Text));
                    else
                        if (textBoxSample.Text != String.Empty)
                            digitalImage.samplingImage(bmp_, Convert.ToInt32(textBoxSample.Text));
               




               


                digitalImage.Show();

            }
          
          
          

        }







    }
}
