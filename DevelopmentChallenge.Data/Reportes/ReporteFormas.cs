using DevelopmentChallenge.Data.FormasGeometricas;
using DevelopmentChallenge.Data.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Reportes
{
    public class ReporteFormas
    {
        private readonly IIdioma _idioma;

        public ReporteFormas(IIdioma idioma)
        {
            _idioma = idioma;
        }

        public string Imprimir(List<IFormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(_idioma.ObtenerTraduccion("listaVacia")); //si la lista esta vacia retorno mensaje de lista vacia
                return sb.ToString();
            }

            sb.Append(_idioma.ObtenerTraduccion("encabezado")); // agrego encabezado

            var resultados = formas
                .GroupBy(f => f.GetType())
                .Select(g => new
                {
                    Forma = g.First(),
                    Cantidad = g.Count(),
                    AreaTotal = g.Sum(f => f.CalcularArea()),
                    PerimetroTotal = g.Sum(f => f.CalcularPerimetro())
                });

            foreach (var resultado in resultados)
            {
                string nombre = resultado.Cantidad > 1 ? resultado.Forma.Nombre() + "Plural" : resultado.Forma.Nombre();
                sb.Append($"{resultado.Cantidad} {_idioma.ObtenerTraduccion(nombre)} | ");
                sb.Append($"{_idioma.ObtenerTraduccion("area")} {resultado.AreaTotal:#.##} | ");
                sb.Append($"{_idioma.ObtenerTraduccion("perimetro")} {resultado.PerimetroTotal:#.##} <br/>");
            }

            // Footer
            sb.Append("TOTAL:<br/>");
            sb.Append($"{resultados.Sum(r => r.Cantidad)} {_idioma.ObtenerTraduccion("formas")} ");
            sb.Append($"{_idioma.ObtenerTraduccion("perimetro")} {resultados.Sum(r => r.PerimetroTotal):#.##} ");
            sb.Append($"{_idioma.ObtenerTraduccion("area")} {resultados.Sum(r => r.AreaTotal):#.##}");

            return sb.ToString();
        }
    }
}
