using CodingChallenge.Data.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal baseFigura) : base(baseFigura) {
            Tipo = FormasGeometricas.Cuadrado;
        }

        public override decimal CalcularArea() 
        { 
            Area = MedidaUno * MedidaUno;
            return Area;
        }

        public override decimal CalcularPerimetro() 
        { 
            Perimetro = MedidaUno * 4;
            return Perimetro;
        }
    }
}
