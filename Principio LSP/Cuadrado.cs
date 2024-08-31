

namespace Principio_LSP
{
    public class Cuadrado : FiguraGeometrica
    {
        /*
        public override double CalcularArea()
        {
            // Esta implementación es incorrecta y viola el LSP
            return Base * Altura;  // Incorrectamente calculando como si fuera un rectángulo
        }*/
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado;  // Área del cuadrado: lado * lado
        }
    }
}
