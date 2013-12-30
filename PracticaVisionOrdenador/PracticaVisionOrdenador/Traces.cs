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
    public partial class Traces : Form
    {
        public List<TextBox> TextboxList = new List<TextBox>();

        public Traces()
        {
            InitializeComponent();
            AutoScroll = true;
        }


        private void textBoxTraces_KeyPress(object sender,KeyPressEventArgs e)
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

            if ((textBoxTraces.Text != String.Empty) && (textBoxTraces.Text != "0"))
            {
                labelTraceNum.Visible = false;
                textBoxTraces.Visible = false;
                buttonNext.Visible = false;
               
                addControls();
            }
            else
                MessageBox.Show("Selecciona un número de trazos válido");
        }



        public void addLabel ( string text, int x, int y, int w, int h){
            Label lab = new Label();
            lab.Text = text;
            lab.SetBounds(x, y, w, h);
            Controls.Add(lab);
        }

        public void addTextBox(string text, int x, int y, int w, int h)
        {
            TextBox tb = new TextBox();
            tb.Name = text;
            tb.SetBounds(x, y, w, h);
            TextboxList.Add(tb);
            Controls.Add(tb);
            

        }

        public void addButton(string name,string text, int x, int y, int w, int h)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.SetBounds(x, y, w, h);
            button.Click += new EventHandler(buttonNext2_Click);
            Controls.Add(button);

        }


        private void addControls()
        {

            int distancey = 50;
            Label labelStartEnd = new Label();
            addLabel( "Inicio", 100, 20, 35, 25);
            addLabel( "Fin", 150, 20, 25, 25);
            addLabel("nueva escala", 200, 20, 75, 25);
            addLabel( "Inicio", 300, 20, 35, 25);
            addLabel( "Fin", 350, 20, 25, 25);

            for (int i = 0; i < Convert.ToInt32(textBoxTraces.Text); i++)
            {
                addLabel( "Tramo " + (i + 1) + ":", 10, distancey, 75, 25);
                addTextBox("TextBoxStart " + (i + 1), 100, distancey, 35, 25);
                addTextBox("TextBoxEnd " + (i + 1), 150, distancey, 35, 25);
                addTextBox("newTextBoxStart " + (i + 1), 300, distancey, 35, 25);
                addTextBox("newTextBoxEnd " + (i + 1), 350, distancey, 35, 25);
                distancey += 40;

            }
            addButton("buttonNext2","Siguiente", 500, distancey, 75, 25);


        }

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            int[] values;
            bool allvalues = true;
            if (Convert.ToInt32(textBoxTraces.Text) > 1)
                values = new int[Convert.ToInt32(textBoxTraces.Text) * 4];
            else
               values = new int[Convert.ToInt32(textBoxTraces.Text) + 3];

            for (int i = 0; i < TextboxList.Count; i++ )
            {
                if (TextboxList[i].Text == String.Empty)
                {
                    MessageBox.Show("Falta por introducir un valor");
                    allvalues = false;
                    break;
                }
                else
                    values[i] = Convert.ToInt32(TextboxList[i].Text);

            }
            if (allvalues == true)
            {
                MainForm mf = (MainForm)ParentForm;
                mf.createImageTrame(values, Convert.ToInt32(textBoxTraces.Text));

            }

            
        }

 

    }
}
