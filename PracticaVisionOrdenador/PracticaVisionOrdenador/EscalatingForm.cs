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
    public partial class EscalatingForm : Form
    {
        Bitmap bmp_;
        public EscalatingForm()
        {
            InitializeComponent();
        }


        public EscalatingForm(Bitmap bmpo)
        {
            InitializeComponent();
            bmp_ = new Bitmap(bmpo);
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {

            if ((textBoxX.Text != String.Empty) || (textBoxY.Text != String.Empty))
            {
                double newScaleWidth = bmp_.Width;
                double newScaleHeight = bmp_.Height;


                if (textBoxX.Text != String.Empty)
                   newScaleWidth = bmp_.Width * (Convert.ToDouble(textBoxX.Text) / 100);
                if (textBoxY.Text != String.Empty)
                   newScaleHeight = bmp_.Height * (Convert.ToDouble(textBoxY.Text) / 100);



                if (comboBoxMethod.SelectedItem != null)
                {
                   ImageForm image = new ImageForm();
                   image.MdiParent = this.MdiParent;
                   if (String.Equals(comboBoxMethod.SelectedItem.ToString(), "Bilineal"))
                   {
                    image.bilinealEscalating(bmp_, (int)newScaleWidth, (int)newScaleHeight,
                    (Convert.ToDouble(textBoxX.Text) / 100), (Convert.ToDouble(textBoxY.Text) / 100));
                    
                    }
                    else
                    {

                       image.vmpEscalating(bmp_, (int)newScaleWidth, (int)newScaleHeight,
                       (Convert.ToDouble(textBoxX.Text) / 100), (Convert.ToDouble(textBoxY.Text) / 100));
                    }

                    image.Show();
                }
                else
                    MessageBox.Show("Selecciona algún método de interpolación");
            }
            else // first if
                MessageBox.Show("Selecciona algún valor de escalado");


        }






    }
}
