
//AYUDA: Como saber si necesitamos un bucle anidado o no.
//Si nos pasan el dato de un número, NO HACE FALTA.

//Ejemplo: Saber si un número es primo -> Hace falta solamente un bucle porque tenemos que calcular los divisores de ese número

//Ejemplo: Saber si todos los números hasta uno determinado son primos: Hace falta un bucle anidado:
//                - Un bucle para pintar todos los números desde 1 hasta el número
//                - Otro bucle para calcular los divisores de cada número

int numero = 0, opcion, divisores = 0, sumaDivisores = 0, factorial = 1;

do
{
    Console.WriteLine("1) Calcula el factorial ");
    Console.WriteLine("2) Comprueba si es perfecto ");
    Console.WriteLine("3) Comprueba si es primo ");
    Console.WriteLine("4) Comprueba si es par ");
    Console.WriteLine("5) Salir ");
    Console.Write("Selecciona una opción: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion != 5)
    {
        Console.Write("Introduce un número:");
        numero = int.Parse(Console.ReadLine()); 
    }

    switch (opcion)
    {
        case 1:
            {
                //Calculamos el factorial
                for (int i = numero; i >= 1; i--)
                {
                    factorial = factorial * i;

                    if (i == 1)
                    {
                        Console.Write(i + " = ");
                    }
                    else
                    {
                        Console.Write(i + " x ");
                    }
                }
                Console.WriteLine(factorial);
                break;
            }
        case 2:
            {
                //Comprobamos si un número es perfecto
                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores = sumaDivisores + i;
                    }
                }
                if (sumaDivisores == numero)
                {
                    Console.WriteLine("Es un número perfecto");
                }
                else
                {
                    Console.WriteLine("No es un número perfecto");
                }
                break;
            }
        case 3:
            {
                //Comprobamos si un número es primo
                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        divisores = divisores + 1;
                    }
                }
                if (divisores <= 2)
                {
                    Console.WriteLine("Es un número primo");
                }
                else
                {
                    Console.WriteLine("No es un número primo");
                }
                break;
            }
        case 4:
            {
                //Comprobamos si un número es par
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es par");
                }
                else
                {
                    Console.WriteLine("El número es impar");
                }
                break;
            }
        default:
            {
                break;
            }
    }
    Console.ReadLine();
    Console.Clear();

} while (opcion != 5);




