using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDefini.Class
{
    public class Calculadora
    {

        string simbolo;
        float ingreso;


        public void Suma()
        {
            simbolo = "+";
        }
        public void operacion(float numero)
        {
            if (simbolo == "+")
                ingreso = ingreso + numero;
        }


    }
}
