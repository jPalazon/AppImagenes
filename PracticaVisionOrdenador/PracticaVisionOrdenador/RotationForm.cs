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
    public partial class RotationForm : Form
    {
        private Bitmap bmp_;
        public RotationForm()
        {
            InitializeComponent();
        }

        public RotationForm(Bitmap bmpo)
        {
            InitializeComponent();
            bmp_ = new Bitmap(bmpo);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxRotation.Text != String.Empty)
            {
                ImageForm image = new ImageForm();
                image.MdiParent = this.MdiParent;
                image.rotationValue(bmp_, Convert.ToDouble(textBoxRotation.Text), comboBoxMethod.SelectedItem.ToString());
                image.Show();
            }
            else
                MessageBox.Show("Indique un valor para la rotación");
        }
    }
}
