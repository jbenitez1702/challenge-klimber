using System;

namespace DevelopmentChallenge.Data.FormasGeometricas
{
    public class Circulo : IFormaGeometrica
    {
        private readonly decimal _radio;
        private readonly string _nombre = "circulo";

        public Circulo(decimal radio) => _radio = radio;

        public string Nombre() => _nombre;

        public decimal CalcularArea() => (decimal)Math.PI * (_radio / 2) * (_radio / 2);

        public decimal CalcularPerimetro() =>(decimal)Math.PI * _radio;
    }
}
