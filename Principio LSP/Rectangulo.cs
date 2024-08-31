

namespace Principio_LSP
{
    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public override double CalcularArea()
        {
            return Base * Altura;  // Área del rectángulo: base * altura
        }
    }
}
