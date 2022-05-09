using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Enums;
using CodingChallenge.Data.Mensajes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;

namespace CodingChallenge.Data.Controllers
{
    public class Reporte
    {
        public static string Imprimir(List<FormaGeometrica> formas, Idiomas idioma)
        {
            var sb = new StringBuilder();

            ObtenerIdioma(idioma);

            if (!(formas.Count>0))
            {
                sb.Append($"<h1>{Textos.ListaVacia}</h1>");
            }
            else
            {
                //HEADER
                sb.Append($"<h1>{Textos.ReporteFormas}</h1>");

                //BODY
                for (var i = 0; i < formas.Count; i++)
                {
                    formas[i].CalcularArea();
                    formas[i].CalcularPerimetro();
                }

                foreach (FormasGeometricas tipo in Enum.GetValues(typeof(FormasGeometricas)))
                {
                    ObtenerLineasTotalesPorForma(formas, tipo, sb);
                }
                
                //FOOTER
                ObtenerLineasTotalesFinal(formas, sb);
            }

            return sb.ToString();
        }

        private static void ObtenerIdioma(Idiomas idioma) 
        {
            string codigo = "es-AR";
            switch (idioma)
            {
                case Idiomas.Castellano:
                    codigo = "es-AR";
                    break;
                case Idiomas.Ingles:
                    codigo = "en-US";
                    break;
                case Idiomas.Portugues:
                    codigo = "pt-BR";
                    break;
            }
            Thread.CurrentThread.CurrentCulture = new CultureInfo(codigo);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(codigo);
        }

        private static void ObtenerLineasTotalesPorForma(List<FormaGeometrica> formas, FormasGeometricas tipo, StringBuilder sb)
        {
            List<FormaGeometrica> listaAuxiliar = new List<FormaGeometrica>(formas.Where(f => f.Tipo == tipo).ToList());

            int cantidad = listaAuxiliar.Count;
            decimal area = listaAuxiliar.Sum(x => x.Area);
            decimal perimetro = listaAuxiliar.Sum(x => x.Perimetro);

            if (cantidad > 0)
            {
                sb.Append($"{cantidad} {TraducirForma(tipo, cantidad)} | {Textos.Area} {area:#.##} | {Textos.Perimetro} {perimetro:#.##} <br/>");
            }
        }

        private static void ObtenerLineasTotalesFinal(List<FormaGeometrica> formas, StringBuilder sb) {
            decimal perimetroTotal = formas.Sum(x => x.Perimetro);
            decimal areaTotal = formas.Sum(x => x.Area);
            
            sb.Append($"{Textos.Total.ToUpper()}:<br/>");
            sb.Append(formas.Count + " " + $"{Textos.Formas.ToLower()} ");
            sb.Append($"{Textos.Perimetro} " + perimetroTotal.ToString("#.##") + " ");
            sb.Append($"{Textos.Area} " + areaTotal.ToString("#.##"));
        }

        private static string TraducirForma(FormasGeometricas tipo, int cantidad)
        {
            switch (tipo)
            {
                case FormasGeometricas.Cuadrado:
                    return cantidad == 1 ? Textos.Cuadrado : Textos.Cuadrados;
                case FormasGeometricas.Circulo:
                    return cantidad == 1 ? Textos.Circulo : Textos.Circulos;
                case FormasGeometricas.TrianguloEquilatero:
                    return cantidad == 1 ? Textos.Triangulo : Textos.Triangulos;
                case FormasGeometricas.Trapecio:
                    return cantidad == 1 ? Textos.Trapecio : Textos.Trapecios;
            }
            return string.Empty;
        }
    }
}
