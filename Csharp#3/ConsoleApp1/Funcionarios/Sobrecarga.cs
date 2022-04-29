using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Sobrecarga
    {

        public double Maior(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        public double Maior(double a, double b, double c)
        {
            if (a > b)
            {
                if (a > c)
                {
                    return a;
                }
                return c;
            }

            if (c > b)
            {
                return c;
            }
            return b;
        }
        //public double Maior(double a, double b, double c)
        //{
        //    double maiorEntreAeB = Maior(a, b);
        //    return Maior(maiorEntreAeB, c);
        //}
        //public double Maior(double a, double b, double c)
        //{
        //    double maiorEntreAeB = Maior(a, b);
        //    return Maior(maiorEntreAeB, c);
        //}
        //public double Maior(double a, double b, double c)
        //{
        //    return Maior(Maior(a, b), c);
        //}
    }
}
