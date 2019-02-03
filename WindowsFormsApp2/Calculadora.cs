using calc;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{




    public partial class Form1 : Form
    {

        Calculadora c = new Calculadora();
        String numeros;
        String numerosCadena;



        public Form1()
        {

            InitializeComponent();
            numeros = "";
            numerosCadena = "";

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        /*============================
         *         NUMEROS
         *============================*/

        private void uno_Click(object sender, EventArgs e)
        {
            ponerNumeros("1");
        }

        private void dos_Click(object sender, EventArgs e)
        {
            ponerNumeros("2");
        }


        private void tres_Click(object sender, EventArgs e)
        {
            ponerNumeros("3");
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            ponerNumeros("4");
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            ponerNumeros("5");
        }

        private void seis_Click(object sender, EventArgs e)
        {
            ponerNumeros("6");
        }

        private void siete_Click(object sender, EventArgs e)
        {
            ponerNumeros("7");
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            ponerNumeros("8");
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            ponerNumeros("9");
        }

        private void cero_Click(object sender, EventArgs e)
        {
            ponerNumeros("0");
        }



        private void coma_Click_1(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (!numeros.Equals("-"))
                {
                    ponerNumeros(",");
                }
            }
            else
            {
                resultado.Text = "0";
            }
        }


        private void ponerNumeros(String num)
        {
            numeros = numeros + num;
            numerosCadena = numerosCadena + num;
            operaciones.Text = numerosCadena;
            resultado.Text = numeros;
        }



        private void operaciones_Click(object sender, EventArgs e)
        {

        }


        /*============================
          *         OPERACIONES
          *===========================*/

        private void suma_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (!numeros.Equals("-"))
                {
                    ponerOperacion('+', " + ");
                }   
            }
            else
            {
                resultado.Text = "0";
            }
        }

        private void menos_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (!numeros.Equals("-"))
                {
                    ponerOperacion('-', " - ");
                }
            }
            else
            {
                resultado.Text = "0";
            }
        }

        private void por_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (!numeros.Equals("-"))
                {
                    ponerOperacion('*', " x ");
                }
            }
            else
            {
                resultado.Text = "0";
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (!numeros.Equals("-"))
                {
                    ponerOperacion('/', " ÷ ");
                }
            }
            else
            {
                resultado.Text = "0";
            }
        }


        private void ponerOperacion(char ope, String simbolo)
        {
            c.insert_num(float.Parse(numeros));
            c.insert_op(ope);
            numerosCadena = numerosCadena + simbolo;
            operaciones.Text = numerosCadena;
            resultado.Text = numeros;
            numeros = "";
        }



        /*============================
          *         CONTROL
          *===========================*/

        //igual
        private void igual_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (!numeros.Equals("-"))
                {
                    c.insert_num(float.Parse(numeros));
                    operaciones.Text = numerosCadena;
                    resultado.Text = c.operar().ToString();
                    numeros = "";
                    numerosCadena = "";
                }
            }
            else
            {
                resultado.Text = "0";
                operaciones.Text = "";
            }

        }

        //atras

        private void atras_Click_1(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                numeros = numeros.Substring(0, numeros.Length - 1);
                numerosCadena = numerosCadena.Substring(0, numerosCadena.Length - 1);
                resultado.Text = numeros;
                operaciones.Text = numerosCadena;
                if (numeros.Equals(""))
                {
                    resultado.Text = "0";
                }
            }
            else
            {
                resultado.Text = "0";
            }

        }


        //borrar

        private void borrar_Click(object sender, EventArgs e)
        {

            operaciones.Text = c.oper_actual().ToString();
            resultado.Text = c.operar().ToString();

            resultado.Text = "0";
            operaciones.Text = "";
            numeros = "";
            numerosCadena = "";


        }

        private void masmenos_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                if (numeros.Substring(0, 1).Equals("-"))
                {
                    numerosCadena = numerosCadena.Substring(0, numerosCadena.Length - numeros.Length);
                    numeros = numeros.Replace("-", "");

                    numerosCadena = numerosCadena + numeros;

                }
                else
                {
                    numerosCadena = numerosCadena.Substring(0, numerosCadena.Length - numeros.Length);
                    numeros = "-" + numeros;

                    numerosCadena = numerosCadena + numeros;

                }

                operaciones.Text = numerosCadena;
            }
            else
            {
                resultado.Text = "0";
            }
        }

        //borrar numero entero
        private void borrarNum_Click(object sender, EventArgs e)
        {
            if (!numeros.Equals(""))
            {
                numerosCadena = numerosCadena.Substring(0, numerosCadena.Length - numeros.Length);
                resultado.Text = "0";
                numeros = "";
                operaciones.Text = numerosCadena;
            }
            else
            {
                resultado.Text = "0";
            }

        }

        
    }
}
