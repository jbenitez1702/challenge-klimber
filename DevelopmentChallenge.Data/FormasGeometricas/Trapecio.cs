namespace DevelopmentChallenge.Data.FormasGeometricas
{
    public class Trapecio : IFormaGeometrica
    {
        private readonly decimal _alto;
        private readonly decimal _largo;
        private readonly string _nombre = "Trapecio";

        public Trapecio(decimal alto, decimal largo)
        {
            _alto = alto;
            _largo = largo;
        }
        public string Nombre() => _nombre;
        public decimal CalcularArea() => _alto * _largo;

        public decimal CalcularPerimetro() => (_alto * 2) + (_largo * 2);
    }
}
