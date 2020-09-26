using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_07_09
{
    class Retangulo
    {
        public double Largura;
        public double Altura; 

        public double areaRetangulo()
        {
            double Area = (Altura * Largura);
            return Area; 
        }
        public double perimetroRetangulo()
        {
            double Perimetro = 2 * (Altura + Largura);
            return Perimetro; 
        }

        public double diagonalRetangulo()
        {
            double Diagonal = Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Largura,2));
            return Diagonal; 
        }
    }
}
