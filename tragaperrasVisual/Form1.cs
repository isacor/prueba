using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tragaperrasVisual
{
    public partial class Tragaperras : Form
    {
            int premio = 0;
        List<int> vImagenes = new List<int>();
        public Tragaperras()
        {
            InitializeComponent();
        }


        private void ImagenesVentanas(List<int> vimagenes)
        {
            int i;



            if (vimagenes[0] == 1)
            {
                pictureBoxVent1.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\cerezas.jpg");
            }
            else
            {
                if (vimagenes[0] == 2)
                {
                    pictureBoxVent1.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\naranja.jpg");
                }
                else
                {
                    if (vimagenes[0] == 3)
                    {
                        pictureBoxVent1.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\limon.jpg");
                    }
                    else
                    {
                        if (vimagenes[0] == 4)
                        {
                            pictureBoxVent1.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\uvas.jpg");
                        }
                        else
                        {
                            if (vimagenes[0] == 5)
                            {
                                pictureBoxVent1.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\b.jpg");
                            }
                        }
                    }
                }
            }

            if (vimagenes[1] == 1)
            {
                pictureBoxVent2.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\cerezas.jpg");
            }
            else
            {
                if (vimagenes[1] == 2)
                {
                    pictureBoxVent2.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\naranja.jpg");
                }
                else
                {
                    if (vimagenes[1] == 3)
                    {
                        pictureBoxVent2.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\limon.jpg");
                    }
                    else
                    {
                        if (vimagenes[1] == 4)
                        {
                            pictureBoxVent2.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\uvas.jpg");
                        }
                        else
                        {
                            if (vimagenes[1] == 5)
                            {
                                pictureBoxVent2.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\b.jpg");
                            }
                        }
                    }
                }
            }

            if (vimagenes[2] == 1)
            {
                pictureBoxVent3.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\cerezas.jpg");
            }
            else
            {
                if (vimagenes[2] == 2)
                {
                    pictureBoxVent3.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\naranja.jpg");
                }
                else
                {
                    if (vimagenes[2] == 3)
                    {
                        pictureBoxVent3.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\limon.jpg");
                    }
                    else
                    {
                        if (vimagenes[2] == 4)
                        {
                            pictureBoxVent3.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\uvas.jpg");
                        }
                        else
                        {
                            if (vimagenes[2] == 5)
                            {
                                pictureBoxVent3.Image = Image.FromFile(@"C:\Users\Pablo\Dropbox (Personal)\DAW1\Programacion\JUNIO\listas\tragaperrasVisual\tragaperrasVisual\bin\Debug\imagenes\b.jpg");
                            }
                        }
                    }
                }
            }


        }

        
        static int CombiVentanas(List<int> ventanas)
        {
            int resultado = 0;

            if ((ventanas[0] == 1 && ventanas[1] == 1) || (ventanas[1] == 1 && ventanas[2] == 1))
            {
                resultado = 6;
            }
            else
            {
                if (ventanas[0] == 1 || ventanas[2] == 1)
                {
                    resultado = 7;
                }
                else
                {
                    if (ventanas[1] == 1 && ventanas[2] == 1 && ventanas[0] == 1)
                    {
                        resultado = 5;
                    }
                    else
                    {
                        if (ventanas[1] == 2 && ventanas[2] == 2 && ventanas[0] == 2)
                        {
                            resultado = 4;
                        }
                        else
                        {
                            if (ventanas[1] == 3 && ventanas[2] == 3 && ventanas[0] == 3)
                            {
                                resultado = 3;
                            }
                            else
                            {
                                if (ventanas[1] == 4 && ventanas[2] == 4 && ventanas[0] == 4)
                                {
                                    resultado = 2;
                                }
                                else
                                {
                                    if (ventanas[1] == 5 && ventanas[2] == 5 && ventanas[0] == 5)
                                    {
                                        resultado = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return resultado;

        }

        static int Premio(int premio)
        {
            int resultado = 0;

            switch (premio)
            {
                case 1:
                    {
                        resultado = 100;
                    }
                    break;
                case 2:
                    {
                        resultado = 50;
                    }
                    break;
                case 3:
                    {
                        resultado = 25;
                    }
                    break;
                case 4:
                    {
                        resultado = 10;
                    }
                    break;
                case 5:
                    {
                        resultado = 5;
                    }
                    break;
                case 6:
                    {
                        resultado = 2;
                    }
                    break;
                case 7:
                    {
                        resultado = 1;
                    }
                    break;


            }

            return resultado;
        }

        private void RecogerPremio(List<int> ventanas)
        {
            


            premio = premio + Premio(CombiVentanas(ventanas));

            textBoxPremioTotal.Text = premio.ToString();

        }

        private void buttonJugar_Click(object sender, EventArgs e)
        {
            int i, aleatorio;
            vImagenes = new List<int>();
           
            Random r = new Random();

            for(i = 1; i <= 3; i++)
            {
                aleatorio = r.Next(1, 5 + 1);
                vImagenes.Add(aleatorio);
            }

            ImagenesVentanas(vImagenes);
            textBoxPremio.Text = Premio(CombiVentanas(vImagenes)).ToString();



            RecogerPremio(vImagenes);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            premio = 0;

            textBoxPremio.Clear();
            textBoxPremioTotal.Clear();
         
        }
    }
}
