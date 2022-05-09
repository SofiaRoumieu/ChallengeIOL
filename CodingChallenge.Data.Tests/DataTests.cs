using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Enums;
using CodingChallenge.Data.Classes.FigurasGeometricas;
using CodingChallenge.Data.Controllers;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        #region "IDIOMAS"
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), Idiomas.Castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), Idiomas.Ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                Reporte.Imprimir(new List<FormaGeometrica>(), Idiomas.Portugues));
        }
        #endregion

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> {new Cuadrado(5)};

            var resumen = Reporte.Imprimir(cuadrados, Idiomas.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perímetro 20 <br/>TOTAL:<br/>1 formas Perímetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = Reporte.Imprimir(cuadrados, Idiomas.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, Idiomas.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perímetro 28 <br/>2 Círculos | Area 13,01 | Perímetro 18,06 <br/>3 Triángulos | Area 49,64 | Perímetro 51,6 <br/>TOTAL:<br/>7 formas Perímetro 97,66 Area 91,65",
                resumen);
        }
        [TestCase]
        public void TestResumenListaConTrapecioEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(3,5,3,7,3),
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new Trapecio(4,7,2,9,2),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, Idiomas.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perímetro 28 <br/>2 Círculos | Area 13,01 | Perímetro 18,06 <br/>3 Triángulos | Area 49,64 | Perímetro 51,6 <br/>2 Trapecios | Area 23 | Perímetro 40 <br/>TOTAL:<br/>9 formas Perímetro 137,66 Area 114,65",
                resumen);
        }
        [TestCase]
        public void TestResumenListaConTrapecioEnPortugues()
        {
            var formas = new List<FormaGeometrica>
            {
                new Trapecio(3,5,3,7,3),
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new Trapecio(4,7,2,9,2),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = Reporte.Imprimir(formas, Idiomas.Portugues);

            Assert.AreEqual(
                "<h1>Relatório de forma</h1>2 Quadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13,01 | Perímetro 18,06 <br/>3 Triângulos | Área 49,64 | Perímetro 51,6 <br/>2 Trapézios | Área 23 | Perímetro 40 <br/>TOTAIS:<br/>9 formas Perímetro 137,66 Área 114,65",
                resumen);
        }
    }
}
