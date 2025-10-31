namespace Calculadora_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Num1 = 0;
            double Num2 = 0;
            double Resultado = 0;
            String operacion = "";

            Console.Write("ingrese el primer numero: ");
            Num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("ingrese el segundo numero: ");
            Num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la operacion (+, -, *, /)");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "+":
                    Resultado = Num1 + Num2;
                    break;
                case "-":
                    Resultado = Num1 - Num2;
                    break;
                case "*":
                    Resultado = Num1 * Num2;
                    break;
                case "/":
                    if (Num2 != 0)
                    {
                        Resultado = Num1 / Num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Error opcion no valida.");
                    return;
            }

            Console.WriteLine($"\nEl resultado de {Num1} {operacion} {Num2} es: {Resultado}");

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
