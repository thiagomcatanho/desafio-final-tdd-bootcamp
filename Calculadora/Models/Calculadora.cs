using System;

namespace Calculadora.Models
{
    public class CalculadoraImp
    {
        public double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public double Subtrair(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public double Dividir(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            return numero1 / numero2;
        }
    }

}
