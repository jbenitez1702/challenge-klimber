using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Idiomas
{
    public class IdiomaItaliano: IIdioma
    {
        public string ObtenerTraduccion(string key) => traducciones[key];

        private readonly Dictionary<string, string> traducciones = new Dictionary<string, string>
        {
            {"encabezado","<h1>Rapporto sulle forme</h1>"},
            {"listaVacia","<h1>Elenco vuoto di forme!</h1>"},
            {"formas","forme"},
            {"perimetro","Perimetro"},
            {"area","Area"},
            {"cuadrado","piazza"},
            {"cuadradoPlural","piazze"},
            {"circulo","cerchio"},
            {"circuloPlural","cerchi"},
            {"triangulo","triangolo"},
            {"trianguloPlural","triangoli"},
            {"trapecio","Trapezio"},
            {"trapecioPlural","Trapezi"},
        };
    }
}
