using CodingChallenge.Data.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FigurasGeometricas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal baseFigura) : base(baseFigura, 0) {
            Tipo = FormasGeometricas.TrianguloEquilatero;
        }
        public override decimal CalcularArea() 
        { 
            Area = ((decimal)Math.Sqrt(3) / 4) * MedidaUno * MedidaUno;
            return Area;
        }

        public override decimal CalcularPerimetro()
        { 
            Perimetro = MedidaUno * 3;
            return Perimetro;
        }
    }
}
