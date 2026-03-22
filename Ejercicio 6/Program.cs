//Desarrolle un programa que solicite una fecha,
//validando que el formato ingresado sea correcto, y luego mostrarla en formato corto
bool correcto;
DateTime fecha;

do
{
    Console.WriteLine("Ingrese una fecha");
    correcto = DateTime.TryParse(Console.ReadLine(), out fecha );
    if(!correcto)
    {
        Console.WriteLine("Fecha no valida");
    }

}while(!correcto);
Console.WriteLine($"Valida, la fecha es: {fecha.ToShortDateString()}");