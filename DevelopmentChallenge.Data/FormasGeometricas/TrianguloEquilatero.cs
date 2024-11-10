using System;

namespace DevelopmentChallenge.Data.FormasGeometricas
{
    public class TrianguloEquilatero : IFormaGeometrica
    {
        private readonly decimal _lado;
        private readonly string _nombre = "triangulo";

        public TrianguloEquilatero(decimal lado) => _lado = lado;
        public string Nombre() => _nombre;

        public decimal CalcularArea() => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;

        public decimal CalcularPerimetro() => _lado * 3;
    }
}
