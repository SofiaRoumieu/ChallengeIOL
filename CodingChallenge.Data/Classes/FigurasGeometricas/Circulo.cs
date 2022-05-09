using CodingChallenge.Data.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.FigurasGeometricas
{
    public class Circulo : FormaGeometrica
    {
        private decimal Radio { get; set; }

        public Circulo(decimal diametroFigura) : base(diametroFigura) {
            Tipo = FormasGeometricas.Circulo;
            Radio = diametroFigura / 2;
        }

        public override decimal CalcularArea() 
        { 
            Area = (decimal)Math.PI * Radio * Radio;
            return Area; 
        }
        public override decimal CalcularPerimetro() 
        {
            Perimetro = (decimal)Math.PI * MedidaUno;
            return Perimetro; 
        }
    }
}
