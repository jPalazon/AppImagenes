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
    public partial class BCForm : Form
    {
        private double brigthness_ = 0;
        private double contrast_ = 0;
        public BCForm()
        {
            InitializeComponent();
        }

        public BCForm(double b, double c)
        {
            InitializeComponent();
            brigthness_ = b;
            contrast_ = c;
           textBoxBrightness.Text = (Math.Floor(b)).ToString();
           textBoxContrast.Text = (Math.Floor(c)).ToString();
        }




        private void textBoxBrightness_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyDigit(e);
        }

        private void textBoxContrast_KeyPress(object sender, KeyPressEventArgs e)
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


        private void Apply_Click(object sender, EventArgs e)
        {
            MainForm mf = (MainForm)ParentForm;
            if (textBoxBrightness.Text == String.Empty)
                mf.createImageBC(brigthness_, contrast_, brigthness_, Convert.ToInt32(textBoxContrast.Text));
            if (textBoxContrast.Text == String.Empty)
                mf.createImageBC(brigthness_, contrast_, Convert.ToInt32(textBoxBrightness.Text), contrast_);
            if ((textBoxContrast.Text == String.Empty) && (textBoxBrightness.Text == String.Empty))
                MessageBox.Show("Especifica algún valor para el brillo y el contraste");
            else
                mf.createImageBC(brigthness_, contrast_, Convert.ToInt32(textBoxBrightness.Text), Convert.ToInt32(textBoxContrast.Text));


        }





    }
}
