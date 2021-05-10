using System;

namespace Calcular
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, numero1, numero2, resul;
            double resulDivision;

            do{
                Console.WriteLine("===================================");
                Console.WriteLine("*******Seleccione Operación*******");
                Console.WriteLine("===================================");
                Console.WriteLine(" 1. sumar");
                Console.WriteLine(" 2. restar");
                Console.WriteLine(" 3. multiplicar");
                Console.WriteLine(" 4. dividir");
                Console.WriteLine(" 5. salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion){
                    case 1:
                        Console.WriteLine("Ingrese primer valor");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese segundo valor");
                        numero2 = int.Parse(Console.ReadLine());

                        resul = numero1 + numero2;

                        Console.WriteLine("Su resultado de la suma es de: " + resul);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese primer valor");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese segundo valor");
                        numero2 = int.Parse(Console.ReadLine());

                        resul = numero1 - numero2;

                        Console.WriteLine("Su resultado de la resta es de: " + resul);

                        break;
                    case 3:
                        Console.WriteLine("Ingrese primer valor");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese segundo valor");
                        numero2 = int.Parse(Console.ReadLine());

                        resul = numero1 * numero2;

                        Console.WriteLine("Su resultado de la multiplicaion es de: " + resul);

                        break;
                    case 4:
                        Console.WriteLine("Ingrese primer valor");
                        numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese segundo valor");
                        numero2 = int.Parse(Console.ReadLine());

                        resulDivision = numero1 / numero2;

                        Console.WriteLine("Su resultado de la Division es de: " + resulDivision);

                        break;
                    default:
                        Console.WriteLine("Seleccion invalida!");
                        break;
                }

            } while (opcion != 5);
            Console.WriteLine("El programa ha finalizado.");
        }
    }
}
