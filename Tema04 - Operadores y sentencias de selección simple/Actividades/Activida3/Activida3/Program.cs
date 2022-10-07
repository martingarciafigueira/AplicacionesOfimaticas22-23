//Condiciones para aprobar la asignatura
bool aprueboExamen = true, aprueboTareas = true, tengoBuenComportamiento = true;
string respuestaExamen, respuestaTarea, respuestaComportamiento;

//Pedimos esos datos por teclado
Console.Write("¿Aprobé el examen?: ");
respuestaExamen = Console.ReadLine();

Console.Write("¿Aprobé las tareas?: ");
respuestaTarea = Console.ReadLine();

Console.Write("¿Tuve buen comportamiento?: ");
respuestaComportamiento = Console.ReadLine();

//Pido respuesta del examen
if (respuestaExamen == "SI")
{
    aprueboExamen = true;
}
else if (respuestaExamen == "NO")
{
    aprueboExamen = false;
}
else
{
    Environment.Exit(0);
}

//Pido respuesta de las tareas
if (respuestaTarea == "SI")
{
    aprueboTareas = true;
}
else if (respuestaTarea == "NO")
{
    aprueboTareas = false;
}
else
{
    Environment.Exit(0);
}

//Pido respuesta del comportamiento
if (respuestaComportamiento == "SI")
{
    tengoBuenComportamiento = true;
}
else if (respuestaComportamiento == "NO")
{
    tengoBuenComportamiento = false;
}
else
{
    Environment.Exit(0);
}

//Establezco las condiciones
if (aprueboExamen)
{
    if (aprueboTareas)
    {
        if (tengoBuenComportamiento)
        {
            Console.WriteLine("Apruebo la asignatura");
        }
        else
        {
            Console.WriteLine("Apruebo la asignatura, con el profe enfadado");
        }
    }
    else
    {
        if (tengoBuenComportamiento)
        {
            Console.WriteLine("Recupero las tareas, pero el profe contento");
        }
        else
        {
            Console.WriteLine("Recupero las tareas, y el profe enfadado ");
        }
    }
}
else
{
    if (aprueboTareas)
    {
        if (tengoBuenComportamiento)
        {
            Console.WriteLine("Recupero el examen, y el profe contento");
        }
        else
        {
            Console.WriteLine("Recupero el examen, y el profe enfadado");
        }
    }
    else
    {
        if (tengoBuenComportamiento)
        {
            Console.WriteLine("Soy buen chaval, pero tengo que estudiar más");
        }
        else
        {
            Console.WriteLine("EXPULSADO");
            Console.Beep();
        }
    }
}

Console.ReadLine();