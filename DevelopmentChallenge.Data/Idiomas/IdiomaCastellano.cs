using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class IdiomaCastellano : IIdioma
    {
        public string ObtenerTraduccion(string key) => traducciones[key];

        private readonly Dictionary<string, string> traducciones = new Dictionary<string, string>
        {
            {"encabezado","<h1>Reporte de Formas</h1>"},
            {"listaVacia","<h1>Lista vacía de formas!</h1>"},
            {"formas","formas"},
            {"perimetro","Perimetro"},
            {"area","Area"},
            {"cuadrado","Cuadrado"},
            {"cuadradoPlural","Cuadrados"},
            {"circulo","Circulo"},
            {"circuloPlural","Círculos"},
            {"triangulo","Triangulo"},
            {"trianguloPlural","Triángulos"},
            {"trapecio","Trapecio"},
            {"trapecioPlural","Trapecios"},
        };
    }
}
