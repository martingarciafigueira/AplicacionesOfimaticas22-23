
//Declaramos las variables
int numero1, numero2, numero3, numero4, numero5, sumaTotal;
float numeroPromedio;

//Obtenemos la información por pantalla

Console.Write("Dame el n1: ");
numero1 = int.Parse(Console.ReadLine());

Console.Write("Dame el n2: ");
numero2 = int.Parse(Console.ReadLine());

Console.Write("Dame el n3: ");
numero3 = int.Parse(Console.ReadLine());

Console.Write("Dame el n4: ");
numero4 = int.Parse(Console.ReadLine());

Console.Write("Dame el n5: ");
numero5 = int.Parse(Console.ReadLine());

sumaTotal = numero1 + numero2 + numero3 + numero4 + numero5;

numeroPromedio = sumaTotal / 5f;

Console.WriteLine("El promedio es: " + numeroPromedio);

Console.ReadLine();
