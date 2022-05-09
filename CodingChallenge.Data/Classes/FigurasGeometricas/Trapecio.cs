using CodingChallenge.Data.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FigurasGeometricas
{
    public class Trapecio : FormaGeometrica
    {
        public Trapecio(decimal baseMayor, decimal baseMenor, decimal ladoA, decimal ladoB, decimal altura) 
            : base(baseMayor, baseMenor, ladoA, ladoB, altura) {
            Tipo = FormasGeometricas.Trapecio;
        }

        public override decimal CalcularArea() 
        {
            Area = ((MedidaUno + MedidaDos) / 2) * MedidaCinco;
            return Area;
        }

        public override decimal CalcularPerimetro()
        { 
            Perimetro = MedidaUno + MedidaDos + MedidaTres + MedidaCuatro;
            return Perimetro;
        }
    }
}
