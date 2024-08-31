using Principio_LSP;
/*El codigo anterior tenia un error que ya no se le podia aplicar el metodo al cuadrado por lo que no cumplia con el principio
 LSP, asi que converti la clase principal en abstracta y desarrolle el metodo calcular por separado en cada clase.*/

FiguraGeometrica figuraRectangulo = new Rectangulo { Base = 6, Altura = 8 };
FiguraGeometrica figuraCuadrado = new Cuadrado { Lado=6}; // Para un cuadrado, base y altura son iguales.

Console.WriteLine($"Área del rectángulo: {figuraRectangulo.CalcularArea()}");  // Correcto: 20
Console.WriteLine($"Área del cuadrado: {figuraCuadrado.CalcularArea()}");  // Incorrecto: 16
