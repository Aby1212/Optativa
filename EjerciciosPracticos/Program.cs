using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("=== MENU DE EJERCICIOS ===\n");
                Console.WriteLine("1. Potencia Positiva");
                Console.WriteLine("2. Doble o Triple");
                Console.WriteLine("3. Raiz o Cuadrado");
                Console.WriteLine("4. Perimetro del Circulo");
                Console.WriteLine("5. Dia de Semana Laboral");
                Console.WriteLine("6. Calculadora de Impuestos");
                Console.WriteLine("7. Buscador de Residuo");
                Console.WriteLine("8. Suma de Pares");
                Console.WriteLine("9. Diferencia de Fracciones");
                Console.WriteLine("10. Longitud de Cadena");
                Console.WriteLine("11. Promedio de Cuatro");
                Console.WriteLine("12. Menor de Cinco");
                Console.WriteLine("13. Contador de Vocales");
                Console.WriteLine("14. Buscador de Factorial");
                Console.WriteLine("15. Validador de Rango");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opcion: ");

                int opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        PotenciaPositiva();
                        break;
                    case 2:
                        DobleOTriple();
                        break;
                    case 3:
                        RaizOCuadrado();
                        break;
                    case 4:
                        PerimetroCirculo();
                        break;
                    case 5:
                        DiaSemanaLaboral();
                        break;
                    case 6:
                        CalculadoraImpuestos();
                        break;
                    case 7:
                        BuscadorResiduo();
                        break;
                    case 8:
                        SumaPares();
                        break;
                    case 9:
                        DiferenciaFracciones();
                        break;
                    case 10:
                        LongitudCadena();
                        break;
                    case 11:
                        PromedioCuatro();
                        break;
                    case 12:
                        MenorCinco();
                        break;
                    case 13:
                        ContadorVocales();
                        break;
                    case 14:
                        BuscadorFactorial();
                        break;
                    case 15:
                        ValidadorRango();
                        break;
                    case 0:
                        continuar = false;
                        Console.WriteLine("Adios!");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

                if (continuar && opcion != 0)
                {
                    Console.WriteLine("\nPresione Enter para continuar...");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                Console.WriteLine("\nPresione Enter para continuar...");
                Console.ReadLine();
            }
        }
    }

    // 1. Potencia Positiva
    static void PotenciaPositiva()
    {
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine($"Resultado: {num * num}");
        else if (num == 0)
            Console.WriteLine("Resultado: 0");
        else
            Console.WriteLine("Resultado: Numero negativo.");
    }

    // 2. Doble o Triple
    static void DobleOTriple()
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
            Console.WriteLine($"Resultado: {num1 * 2}");
        else if (num2 > num1)
            Console.WriteLine($"Resultado: {num2 * 3}");
        else
            Console.WriteLine($"Resultado: {num1 * 2}");
    }

    // 3. Raiz o Cuadrado
    static void RaizOCuadrado()
    {
        Console.Write("Ingrese un numero: ");
        double num = double.Parse(Console.ReadLine());

        if (num > 0)
            Console.WriteLine($"Resultado: {Math.Sqrt(num):F2}");
        else if (num == 0)
            Console.WriteLine("Resultado: 0");
        else
            Console.WriteLine($"Resultado: {num * num}");
    }

    // 4. Perimetro del Circulo
    static void PerimetroCirculo()
    {
        Console.Write("Ingrese el radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());

        double perimetro = 2 * Math.PI * radio;
        Console.WriteLine($"Resultado: {perimetro:F2}");
    }

    // 5. Dia de Semana Laboral
    static void DiaSemanaLaboral()
    {
        Console.Write("Ingrese un numero (1-7): ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Resultado: Lunes");
                break;
            case 2:
                Console.WriteLine("Resultado: Martes");
                break;
            case 3:
                Console.WriteLine("Resultado: Miercoles");
                break;
            case 4:
                Console.WriteLine("Resultado: Jueves");
                break;
            case 5:
                Console.WriteLine("Resultado: Viernes");
                break;
            default:
                Console.WriteLine("Resultado: Numero fuera del rango laboral.");
                break;
        }
    }

    // 6. Calculadora de Impuestos
    static void CalculadoraImpuestos()
    {
        Console.Write("Ingrese su salario anual: ");
        double salario = double.Parse(Console.ReadLine());

        if (salario > 12000)
        {
            double impuesto = (salario - 12000) * 0.15;
            Console.WriteLine($"Resultado: {impuesto:F2}");
        }
        else
        {
            Console.WriteLine("Resultado: No debe impuestos.");
        }
    }

    // 7. Buscador de Residuo
    static void BuscadorResiduo()
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());

        int residuo = num1 % num2;
        Console.WriteLine($"Resultado: {residuo}");
    }

    // 8. Suma de Pares
    static void SumaPares()
    {
        int suma = 0;
        for (int i = 2; i <= 50; i += 2)
        {
            suma += i;
        }
        Console.WriteLine($"Resultado: {suma}");
    }

    // 9. Diferencia de Fracciones
    static void DiferenciaFracciones()
    {
        Console.Write("Ingrese el numerador de la primera fraccion: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el denominador de la primera fraccion: ");
        int den1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el numerador de la segunda fraccion: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el denominador de la segunda fraccion: ");
        int den2 = int.Parse(Console.ReadLine());

        int numResultado = (num1 * den2) - (num2 * den1);
        int denResultado = den1 * den2;

        // Simplificar la fraccion
        int mcd = MCD(Math.Abs(numResultado), Math.Abs(denResultado));
        numResultado /= mcd;
        denResultado /= mcd;

        Console.WriteLine($"Resultado: {numResultado}/{denResultado}");
    }

    static int MCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // 10. Longitud de Cadena
    static void LongitudCadena()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        Console.WriteLine($"Resultado: {palabra.Length}");
    }

    // 11. Promedio de Cuatro
    static void PromedioCuatro()
    {
        Console.Write("Ingrese el primer numero: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.Write("Ingrese el cuarto numero: ");
        double num4 = double.Parse(Console.ReadLine());

        double promedio = (num1 + num2 + num3 + num4) / 4;
        Console.WriteLine($"Resultado: {promedio}");
    }

    // 12. Menor de Cinco
    static void MenorCinco()
    {
        Console.Write("Ingrese el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el tercer numero: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el cuarto numero: ");
        int num4 = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el quinto numero: ");
        int num5 = int.Parse(Console.ReadLine());

        int menor = num1;
        if (num2 < menor) menor = num2;
        if (num3 < menor) menor = num3;
        if (num4 < menor) menor = num4;
        if (num5 < menor) menor = num5;

        Console.WriteLine($"Resultado: {menor}");
    }

    // 13. Contador de Vocales
    static void ContadorVocales()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        int contador = 0;
        foreach (char c in palabra)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                contador++;
        }

        Console.WriteLine($"Resultado: {contador}");
    }

    // 14. Buscador de Factorial
    static void BuscadorFactorial()
    {
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Resultado: {factorial}");
    }

    // 15. Validador de Rango
    static void ValidadorRango()
    {
        Console.Write("Ingrese un numero: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 10 && num <= 20)
            Console.WriteLine("Resultado: Esta en el rango.");
        else
            Console.WriteLine("Resultado: Fuera del rango.");
    }
}