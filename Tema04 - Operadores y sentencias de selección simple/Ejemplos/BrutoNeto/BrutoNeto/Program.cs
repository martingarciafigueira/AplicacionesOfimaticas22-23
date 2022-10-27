//Declaramos las variables
float tasaHora, salarioBruto, tasaHoraExtra, salarioNeto;
int horasTrabajadas, horasExtra;

//Pedimos las variables por pantalla
Console.Write("Dame las horas que has trabajado: ");
horasTrabajadas = int.Parse(Console.ReadLine());

Console.Write("Dame la tasa hora a la que te pagan:");
tasaHora = float.Parse(Console.ReadLine());

//Hacemos los cálculos
//Calculamos el salario bruto
if (horasTrabajadas <= 38)
{
    salarioBruto = horasTrabajadas * tasaHora;
}
else
{
    tasaHoraExtra = tasaHora + (tasaHora * 50 / 100);
    horasExtra = horasTrabajadas - 38;
    salarioBruto = (horasTrabajadas * tasaHora) + (horasExtra * tasaHoraExtra);
}

//Le quitamos los impuestos
if (salarioBruto <= 300)
{
    salarioNeto = salarioBruto;
}
else
{
    salarioNeto = salarioBruto - salarioBruto * (10f / 100f);
}

//Mostramos por pantalla
Console.WriteLine("El salario bruto es: " + salarioBruto);
Console.WriteLine("El salario neto es: " + salarioNeto);

Console.ReadLine();
