using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

/* Hola, prueba */

namespace Vision
{
    public partial class FilterForm : Form
    {
        private List<TextBox> TextboxList = new List<TextBox>();
        private Bitmap bmp_;
        public FilterForm()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        public FilterForm(Bitmap bmpo)
        {
            InitializeComponent();
            AutoScroll = true;
            bmp_ = new Bitmap(bmpo);
        }

        public void addButtonNext(string name, string text, int x, int y, int w, int h)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.SetBounds(x, y, w, h);
            button.Click += new EventHandler(buttonNext2_Click);
            Controls.Add(button);
        }


        public void addButtonSave(string name, string text, int x, int y, int w, int h)
        {
            Button button = new Button();
            button.Text = text;
            button.Name = name;
            button.SetBounds(x, y, w, h);
            button.Click += new EventHandler(buttonSave_Click);
            Controls.Add(button);
        }


        public void addLabel(string text, int x, int y, int w, int h)
        {
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

        private void addControls()
        {
            
            int distancey = 50;
            int distancex = 30;
            
            if (textBoxRows.Text == "1")
            {
                for (int i = 0; i < Convert.ToInt32(textBoxColumns.Text); i++)
                {
                    addTextBox("TextBoxValue" + (i), distancex, distancey, 35, 25);
                    distancex += 40;
                }
                distancey += 40;
            }

            if (textBoxColumns.Text == "1")
            {
                for (int i = 0; i < Convert.ToInt32(textBoxRows.Text); i++)
                {

                    addTextBox("TextBoxValue" + (i), distancex, distancey, 35, 25);
                    distancey += 40;

                }
            }

            if ((Convert.ToInt32(textBoxColumns.Text) != 1) && (Convert.ToInt32(textBoxRows.Text) != 1))
            {

                for (int i = 0; i < Convert.ToInt32(textBoxColumns.Text); i++)
                {
                    for (int j = 0; j < Convert.ToInt32(textBoxRows.Text); j++)
                    {
                        addTextBox("TextBoxValue" + (i + j), distancex, distancey, 35, 25);
                        distancex += 60;
    
                    }
                    distancey += 40;
                    distancex = 30;
                }
            }
            addLabel("Nombre del filtro:", 15, 15, 100, 25);
            addTextBox("TextBoxNameFile", 120, 15, 100, 25);
            addButtonNext("buttonNext2", "siguiente", 15, distancey, 75, 25);
            addButtonSave("buttonSave", "GuardarFiltro", 100 , distancey, 75, 25);
        }



        private void buttonAddFilter_Click(object sender, EventArgs e)
        {
            if ((textBoxColumns.Text != String.Empty) && (textBoxRows.Text != String.Empty))
            {
                labelSize.Visible = false;
                labelColumns.Visible = false;
                labelRows.Visible = false;
                labelNormalize.Visible = false;
                buttonNext.Visible = false;
                buttonLoadFilter.Visible = false;
                textBoxColumns.Visible = false;
                textBoxRows.Visible = false;
                textBoxNormalize.Visible = false;

                addControls();
            }
            else
                MessageBox.Show("nº de valores incorrectos");
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if ((textBoxColumns.Text != String.Empty) && (textBoxRows.Text != String.Empty) 
                && (textBoxNormalize.Text != String.Empty))
            {
                labelSize.Visible = false;
                labelColumns.Visible = false;
                labelRows.Visible = false;
                labelNormalize.Visible = false;
                buttonNext.Visible = false;
                buttonLoadFilter.Visible = false;
                textBoxColumns.Visible = false;
                textBoxRows.Visible = false;
                textBoxNormalize.Visible = false;

                addControls();
            }
            else
                MessageBox.Show("Faltan campos por rellenar");
        }

        //metodo para ejecutar el filtro

        private void buttonNext2_Click(object sender, EventArgs e)
        {
            bool allvalues = true;
            double[,] kernel = new double[Convert.ToInt32(textBoxRows.Text), Convert.ToInt32(textBoxColumns.Text)];

            int contadori = 0;
            int contadorj = 0;
            for (int i = 0; i < TextboxList.Count-1; i++) //menos uno por que el ultimo valor es el nombre del fichero
            {
               if (i % Convert.ToInt32(textBoxColumns.Text) == 0)
                  contadori = 0;
               if ((contadori == 0) && (i != 0))
                  contadorj += 1;
               if (TextboxList[i].Text == String.Empty)
               {
                   MessageBox.Show("Falta por introducir un valor");
                   allvalues = false;
                   break;
               }
               else
                  kernel[contadorj, contadori] = Convert.ToDouble(TextboxList[i].Text);
               contadori++;

             }
             if (allvalues == true)
             {
                ImageForm image = new ImageForm();
                image.MdiParent = this.MdiParent;
                image.applyFilter(bmp_, kernel, Convert.ToInt32(textBoxRows.Text), Convert.ToInt32(textBoxColumns.Text), Convert.ToDouble(textBoxNormalize.Text));
                image.Show();
             }  
        }


        //método para salvar el filtro

        public void buttonSave_Click(object sender, EventArgs e)
        {
            bool allvalues = true;
            double[,] kernel = new double[Convert.ToInt32(textBoxRows.Text), Convert.ToInt32(textBoxColumns.Text)];

            int contadori = 0;
            int contadorj = 0;
            for (int i = 0; i < TextboxList.Count-1; i++)
            {
                if (i % Convert.ToInt32(textBoxRows.Text) == 0)
                    contadori = 0;
                if ((contadori == 0) && (i != 0))
                    contadorj += 1;
                if (TextboxList[i].Text == String.Empty)
                {
                    MessageBox.Show("Falta por introducir un valor");
                    allvalues = false;
                    break;
                }
                else
                    kernel[contadorj, contadori] = Convert.ToDouble(TextboxList[i].Text);
                contadori++;

            }
            if (allvalues == true)
            {
                try
                {

                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter("C:\\Users\\Jose\\Desktop\\Imagenes\\"+ TextboxList.Last().Text +".txt");
                    for (int i = 0; i < Convert.ToInt32(textBoxRows.Text); i++)
                    {
                        for (int j = 0; j < Convert.ToInt32(textBoxColumns.Text); j++)
                        {
                            //Write a line of text
                            sw.Write(","+ kernel[i,j]);

                        }
                        sw.WriteLine();
                    }
                    //Close the file
                    sw.Close();
                    MessageBox.Show("fichero de texto con el filtro guardado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }

            } 

        }


        //metodo de cargar el filtro


        private void buttonLoadFilter_Click(object sender, EventArgs e)
        {

            if ((textBoxColumns.Text != String.Empty) && (textBoxRows.Text != String.Empty) 
            && (textBoxNormalize.Text != String.Empty))
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Filter = " Archivos de texto (*.txt)|*.txt";
                OpenFile.InitialDirectory = "C:\\Users\\Jose\\Desktop\\Imagenes";
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    labelSize.Visible = false;
                    labelColumns.Visible = false;
                    labelRows.Visible = false;
                    labelNormalize.Visible = false;
                    buttonNext.Visible = false;
                    buttonLoadFilter.Visible = false;
                    textBoxColumns.Visible = false;
                    textBoxRows.Visible = false;
                    textBoxNormalize.Visible = false;
                    addControls();
                    try
                    {
                        StreamReader sr = new StreamReader(OpenFile.FileName);
                        String linea;
                        String digito;
                        int contador = -1;
                        int j = 0;

                        while ((linea = sr.ReadLine()) != null)
                        {
                            for (int i = 0; i < linea.Length; i++)
                            {
                               if (linea[i].Equals(','))
                                   contador++;
                               while ((i+j < linea.Length) && (linea[i+j] != ','))
                               {
                                    j++;
                                    digito = linea.Substring(i, j);
                                    TextboxList[contador].Text = digito;
                                    i += j-1;
                                    
                                }
                               
                                j = 0;
 
                            }
                        }
                        sr.Close();

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Error abriendo el fichero");
            }
            else
                MessageBox.Show("Faltan campos por rellenar");


            
        }

    }// final de clase
}
