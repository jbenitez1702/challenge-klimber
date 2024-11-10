using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class IdiomaIngles : IIdioma
    {
        public string ObtenerTraduccion(string key) => traducciones[key];

        private readonly Dictionary<string, string> traducciones = new Dictionary<string, string>
        {
            {"encabezado","<h1>Shapes report</h1>"},
            {"listaVacia","<h1>Empty list of shapes!</h1>"},
            {"formas","shapes"},
            {"perimetro","Perimeter"},
            {"area","Area"},
            {"cuadrado","Square"},
            {"cuadradoPlural","Squares"},
            {"circulo","Circle"},
            {"circuloPlural","Circles"},
            {"triangulo","Triangle"},
            {"trianguloPlural","Triangles"},
            {"trapecio","Trapezoid"},
            {"trapecioPlural","Trapezoids"},
        };
    }
}
