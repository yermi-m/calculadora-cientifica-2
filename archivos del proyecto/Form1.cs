using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraCientifica_v3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void TeclaPresionadaEnElBuffer(object sender, KeyEventArgs e)
        {
            // guardamos el id de la tecla presionada.
            string tecla = e.KeyValue.ToString();

            // si la tecla presionada es ENTER, entonces hacemos el calculo y lo mostramos en el control.
            if (tecla == "13")
            {
                this.buffer.Text = BibliotecaDeLosMetodos.Metodos.CalcularExpresion(this.buffer.Text);

                // esto es para poner el cursor al final del buffer.
                this.buffer.SelectionStart = this.buffer.Text.Length;
            }
            // si la tecla presionada es ESC, entonces limpiamos el buffer.
            if (tecla == "27")
            {
                this.buffer.Clear();
            }
            
        }
        void BotonPresionado(object sender, EventArgs e)
        {
            //this.buffer.Text += "(";

            // esto es para poner el foco en el buffer.
            this.buffer.Focus();

            // vamos a guardar el argumento para luego poder verificar qué boton se ha presionado.
            Button sender2 = sender as Button;

            // ahora vamos a verificar que boton se ha presionado y poder poner su valor en el buffer.
            switch (sender2.Name)
            {
                case "buttonResultado":
                    this.buffer.Text = BibliotecaDeLosMetodos.Metodos.CalcularExpresion(this.buffer.Text);
                    break;
                case "buttonLimpiarBuffer":
                    this.buffer.Clear();
                    break;
                case "buttonRetroceder":
                    if (this.buffer.Text.Length > 0)
                    {
                        this.buffer.Text = this.buffer.Text.Remove(this.buffer.Text.Length - 1);
                    }
                    break;
                case "buttonParentesisAbierto":
                    this.buffer.Text += "(";
                    break;
                case "buttonParentesisCerrado":
                    this.buffer.Text += ")";
                    break;
                case "buttonDividir":
                    this.buffer.Text += "/";
                    break;
                case "buttonMultiplicar":
                    this.buffer.Text += "*";
                    break;
                case "buttonRestar":
                    this.buffer.Text += "-";
                    break;
                case "buttonSumar":
                    this.buffer.Text += "+";
                    break;
                case "button9":
                    this.buffer.Text += "9";
                    break;
                case "button8":
                    this.buffer.Text += "8";
                    break;
                case "button7":
                    this.buffer.Text += "7";
                    break;
                case "button6":
                    this.buffer.Text += "6";
                    break;
                case "button5":
                    this.buffer.Text += "5";
                    break;
                case "button4":
                    this.buffer.Text += "4";
                    break;
                case "button3":
                    this.buffer.Text += "3";
                    break;
                case "button2":
                    this.buffer.Text += "2";
                    break;
                case "button1":
                    this.buffer.Text += "1";
                    break;
                case "button0":
                    this.buffer.Text += "0";
                    break;
                case "buttonPunto":
                    this.buffer.Text += ".";
                    break;
                default:
                    break;
            }

            // esto es para poner el cursor al final del buffer.
            this.buffer.SelectionStart = this.buffer.Text.Length;
        }

        void button1_Enter(object sender, EventArgs e)
        {
            this.buffer.Text += "(";
            this.buffer.SelectionStart = this.buffer.Text.Length;
            this.buffer.Focus();
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            this.buffer.Text += ")";
            this.buffer.SelectionStart = this.buffer.Text.Length;
            this.buffer.Focus();
        }
        
    }
}
