using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace CalculadoraDefini 
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
        
    {
        double a ;
        
        double resultado ;
        string operacion;
        string resultadostring;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            resultadostring = Convert.ToString(resultado);
            if(mantisa.Text==resultadostring)
                mantisa.Text = "";
            if (mantisa.Text == "0" )
                mantisa.Text = "";
            if (mantisa2.Text == "0")
                mantisa2.Text = "";
            mantisa.Text = mantisa.Text + button.Text;
            mantisa2.Text = mantisa2.Text + button.Text;
        }
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            mantisa.Text = "0";
            mantisa2.Text = "0";
            a = 0;
            resultado = 0;
            operacion = "";
        }

        private void Button_Clicked_operacion(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            a = Convert.ToDouble(mantisa.Text);

            if(operacion =="+" || operacion == "-")
            {
                if (operacion == "+")
                {
                    mantisa2.Text = mantisa2.Text + button.Text;
                    resultado = resultado + a;
                }
                    

                if (operacion == "-")
                {
                    resultado = resultado - a;
                    mantisa2.Text = mantisa2.Text + button.Text;
                }
                    

            }
            else
            {
                if (button.Text == "+")
                {
                    operacion = "+";
                    resultado = a;
                    mantisa2.Text = mantisa2.Text + button.Text;
                }

                if (button.Text == "-")
                {
                    operacion = "-";
                    resultado = a;
                    mantisa2.Text = mantisa2.Text + button.Text;
                }
            }
                


            



            mantisa.Text = Convert.ToString(resultado);


        }


        private void Button_Clicked_igual(object sender, EventArgs e)
        {
            Button button = sender as Button;
            a = Convert.ToDouble(mantisa.Text);
            if (operacion == "+")
            {
                resultado = a + resultado;
            }
            if (operacion == "-")
            {
                resultado = resultado - a;
            }
            if (operacion == "*")
            {
                resultado = a * resultado;
            }
            if (operacion == "/")
            {
                resultado = a / resultado;
            }
            mantisa.Text = Convert.ToString(resultado);
            mantisa2.Text = "";
                
                
        }
    }

    public class Calculadora
    {
        float mantisa;
        string operacion;


        public void Mas()
        {
            operacion = "+";
        }
        public void Menos()
        {
            operacion = "-";
        }
        public void Igual()
        {
        }
        public float GetResultado()
        {
            return mantisa;
        }
    }


}