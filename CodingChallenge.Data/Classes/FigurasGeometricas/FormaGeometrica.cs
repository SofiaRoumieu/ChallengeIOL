/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using CodingChallenge.Data.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        #region "ATRIBUTOS"
        protected decimal MedidaUno { get; set; }
        protected decimal MedidaDos { get; set; }
        protected decimal MedidaTres { get; set; }
        protected decimal MedidaCuatro { get; set; }
        protected decimal MedidaCinco { get; set; }
        public FormasGeometricas Tipo { get; set; }
        public decimal Area {get;set;}
        public decimal Perimetro { get; set; }

        #endregion

        #region "CONSTRUCTORES"
        public FormaGeometrica(decimal medidaUno)
        {
            MedidaUno = medidaUno;
        }
        public FormaGeometrica(decimal medidaUno, decimal medidaDos)
            : this(medidaUno)
        {
            MedidaDos = medidaDos;
        }
        public FormaGeometrica(decimal medidaUno, decimal medidaDos, decimal medidaTres) 
            : this(medidaUno, medidaDos)
        {
            MedidaTres = medidaTres;
        }
        public FormaGeometrica(decimal medidaUno, decimal medidaDos, decimal medidaTres, decimal medidaCuatro) 
            :this(medidaUno, medidaDos, medidaTres)
        {
            MedidaCuatro = medidaCuatro;
        }
        public FormaGeometrica(decimal medidaUno, decimal medidaDos, decimal medidaTres, decimal medidaCuatro, decimal medidaCinco) 
            : this(medidaUno, medidaDos, medidaTres, medidaCuatro)
        {
            MedidaCinco = medidaCinco;
        }
        #endregion

        #region "METODOS"
        public virtual decimal CalcularArea()
        {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }
        public virtual decimal CalcularPerimetro()
        {
            throw new ArgumentOutOfRangeException(@"Forma desconocida");
        }
        #endregion
    }
}
