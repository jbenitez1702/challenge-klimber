namespace DevelopmentChallenge.Data.FormasGeometricas
{
    public class Cuadrado : IFormaGeometrica
    {
        private readonly decimal _lado;
        private readonly string _nombre = "cuadrado";

        public Cuadrado(decimal lado) => _lado = lado;
        public string Nombre() => _nombre;
        public decimal CalcularArea() => _lado * _lado;

        public decimal CalcularPerimetro() => _lado * 4;
    }
}
