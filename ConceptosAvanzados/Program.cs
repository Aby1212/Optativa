using System;

// Clases
abstract class Figura
{
    public abstract double Area();
    public abstract double Perimetro();
}

class Circulo : Figura
{
    public double Radio { get; set; }
    public override double Area() => Math.PI * Radio * Radio;
    public override double Perimetro() => 2 * Math.PI * Radio;
}

class Rectangulo : Figura
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public override double Area() => Base * Altura;
    public override double Perimetro() => 2 * Base + 2 * Altura;
}


class Program
{
    static void Main()
    {
        bool continuar = true;
        
       
        while (continuar)
        {
            try
            {
                Console.WriteLine("\n=== MENU ===");
                Console.WriteLine("1. Calcular Circulo");
                Console.WriteLine("2. Calcular Rectangulo");
                Console.WriteLine("0. Salir");
                Console.Write("Opcion: ");
                
                int opcion = int.Parse(Console.ReadLine());
                
                
                Figura figura = null;
                
                switch (opcion)
                {
                    case 1:
                        Console.Write("\nIngrese el radio: ");
                        double radio = double.Parse(Console.ReadLine());
                        
                        if (radio <= 0) 
                            throw new Exception("El radio debe ser mayor a 0");
                        
                        figura = new Circulo { Radio = radio };
                        MostrarResultados(figura, "Circulo");
                        break;
                        
                    case 2:
                        Console.Write("\nIngrese la base: ");
                        double baseR = double.Parse(Console.ReadLine());
                        
                        Console.Write("Ingrese la altura: ");
                        double altura = double.Parse(Console.ReadLine());
                        
                        if (baseR <= 0 || altura <= 0) 
                            throw new Exception("Base y altura deben ser mayores a 0");
                        
                        figura = new Rectangulo { Base = baseR, Altura = altura };
                        MostrarResultados(figura, "Rectangulo");
                        break;
                        
                    case 0:
                        continuar = false;
                        Console.WriteLine("\nAdios!");
                        break;
                        
                    default:
                        Console.WriteLine("\nOpcion invalida");
                        break;
                }
            }
            catch (FormatException)  
            {
                Console.WriteLine("\nError: Debe ingresar un numero valido");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
        }
    }
    
    
    static void MostrarResultados(Figura figura, string tipo)
    {
        Console.WriteLine($"\n--- Resultados del {tipo} ---");
        Console.WriteLine($"Area: {figura.Area():F2}");
        Console.WriteLine($"Perimetro: {figura.Perimetro():F2}");
    }
}