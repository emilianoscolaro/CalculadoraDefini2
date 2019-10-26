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
        double b;
        string operacion;
        string resultadostring;
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            resultadostring = Convert.ToString(b);
            if(mantisa.Text==resultadostring)
                mantisa.Text = "";
            if (mantisa.Text == "0" )
                mantisa.Text = "";
            if (mantisa2.Text == "0")
                mantisa2.Text = "";
            mantisa.Text = mantisa.Text + button.Text;
            mantisa2.Text = mantisa2.Text + button.Text;
        }
        private void Button_Clicked_C(object sender, EventArgs e)
        {
            mantisa.Text = "0";
            mantisa2.Text = "0";
            a = 0;
            operacion = null;
            b = 0;
        }
        private void Button_Clicked_operacion(object sender, EventArgs e) 
        {
            Button button = sender as Button;
            a = Convert.ToDouble(mantisa.Text);

            if (operacion == "+")
            {
                b = b + a;
            }
            if (operacion == "-")
            {
                b = b - a;
            }
            if (operacion == "*")
                b = b * a;
            if (operacion == "/")
                b = b / a;
            if (operacion == null)
            {   
                b = a;
            }
            operacion = button.Text;
            mantisa2.Text =  mantisa2.Text + button.Text;
            mantisa.Text = Convert.ToString(b);
            resultadostring= Convert.ToString(b); 
        }

        private void Button_Clicked_igual(object sender, EventArgs e)
        {
            Button button = sender as Button;
            a = Convert.ToDouble(mantisa.Text);
            if (operacion == "+")
            {
                b = b+a;
            }
            if (operacion == "-")
            {
                b = b - a;
            }
            if (operacion == "*")
            {
                b = b*a;
            }
            if (operacion == "/")
            {
                b = b/a;
            }
            mantisa.Text = Convert.ToString(b);
            mantisa2.Text = ""; 
        }
    }


}