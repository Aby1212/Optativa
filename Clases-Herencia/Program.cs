/*var rect = new Rectangulo();
rect.Base=20;
rect.Altura=40;
Console.WriteLine($"El area es: {rect.Area()}");
Console.WriteLine($"El perimetro es: {rect.Perimetro()}");*/

var cuadr = new Cuadrado();
cuadr.Lado = 20;  // Esto automáticamente asigna Base=20 y Altura=20
Console.WriteLine($"El area es: {cuadr.Area()}");
Console.WriteLine($"El perimetro es: {cuadr.Perimetro()}");
Console.WriteLine($"El lado es: {cuadr.Lado}");

[Serializable]
class Rectangulo
{
    // 3 references
    public double Base { get; set; }
    // 3 references
    public double Altura { get; set; }
    // 1 reference
    public double Area() => Base * Altura;
    // 1 reference
    public double Perimetro() => 2 * Base + 2 * Altura;
}

class Cuadrado : Rectangulo
{
    // 0 references
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }
    }

}



