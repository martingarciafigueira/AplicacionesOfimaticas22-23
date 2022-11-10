
using System.Numerics;

int opcion;

do
{
    Console.WriteLine("1. Resolver Ecuación 2º Grado");
    Console.WriteLine("2. Mostrar Tabla de Multiplicar");
    Console.WriteLine("3. Salir");

    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            {
                int a, b, c;
                double x1 = 0, x2 = 0, solucionIntermedia;

                Console.WriteLine("Opción 1: ");
                Console.Write("Introduce el valor de A:");
                a = int.Parse(Console.ReadLine());
                Console.Write("Introduce el valor de B:");
                b = int.Parse(Console.ReadLine());
                Console.Write("Introduce el valor de C:");
                c = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    x1 = -(c / b);
                    x2 = -(c / b);
                }
                else if (b == 0)
                {
                    solucionIntermedia = -c / a;

                    if (solucionIntermedia >= 0)
                    {
                        x1 = Math.Sqrt(solucionIntermedia);
                        x2 = -Math.Sqrt(solucionIntermedia);
                    }
                    else
                    {
                        Console.Write("No hay soluciones reales");
                    }
                }
                else if (c == 0)
                {
                    x1 = 0;
                    x2 = -(b / a);
                }
                else if (a != 0 && b != 0 && c != 0)
                {
                    x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
                    x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
                }

                Console.WriteLine("Solución x1: " + x1);
                Console.WriteLine("Solución x2: " + x2);

                break;
            }
        case 2:
            {
                int factor, numElementos, resultado;
                Console.WriteLine("Opción 2: ");
                Console.Write("Introduce el factor:");
                factor = int.Parse(Console.ReadLine());
                Console.Write("Introduce el número de elementos:");
                numElementos = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numElementos; i++)
                {
                    resultado = factor * i;
                    Console.WriteLine(factor + " x " + i + " = " + resultado);
                }

                break;
            }
        case 3:
            {
                Environment.Exit(0);
                break;
            }
        default:
            {
                Console.Clear();
                break;
            }
    }

} while (true);
