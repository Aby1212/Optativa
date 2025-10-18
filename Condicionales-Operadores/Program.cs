
/*Condicionales
Console.WriteLine("Ingrese un número: ");
int num = int.Parse(Console.ReadLine());

if (num > 0) Console.WriteLine("Positivo");
else if (num < 0) Console.WriteLine("Negativo");
else Console.WriteLine("Es cero");*/

//Operadores
/*Console.WriteLine("Ingrese un número: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo número: ");
double b = double.Parse(Console.ReadLine());

Console.WriteLine($"Suma: {a + b}, Multiplicación: {a * b}, División: {(b != 0 ? a / b : 0)} Indeterminado");*/

class Calculadora
{
    public double NumeroA { get; set; }
    public double NumeroB { get; set; }
    
    public Calculadora(double a, double b)
    {
        NumeroA = a;
        NumeroB = b;
    }
    
    public double Sumar() => NumeroA + NumeroB;
    public double Restar() => NumeroA - NumeroB;
    public double Multiplicar() => NumeroA * NumeroB;
    public string Dividir() => NumeroB != 0 ? (NumeroA / NumeroB).ToString("F2") : "Indeterminado";
    public string Modulo() => NumeroB != 0 ? (NumeroA % NumeroB).ToString("F2") : "Indeterminado";
    public double Potencia() => Math.Pow(NumeroA, NumeroB);
    
    public void MostrarResultados()
    {
        Console.WriteLine($"\n{"Operación",-15} {"Resultado",10}");
        Console.WriteLine(new string('-', 30));
        Console.WriteLine($"{"Suma",-15} {Sumar(),10:F2}");
        Console.WriteLine($"{"Resta",-15} {Restar(),10:F2}");
        Console.WriteLine($"{"Multiplicación",-15} {Multiplicar(),10:F2}");
        Console.WriteLine($"{"División",-15} {Dividir(),10}");
        Console.WriteLine($"{"Módulo",-15} {Modulo(),10}");
        Console.WriteLine($"{"Potencia",-15} {Potencia(),10:F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double b = double.Parse(Console.ReadLine());

        var calc = new Calculadora(a, b);
        calc.MostrarResultados();
    }
}




