//Desarrolle un programa que solicite la nota de un estudiante,
//validando que sea un número entre 0 y 100 antes de mostrar si aprueba o reprueba
int nota;
bool correcto;
do
{
    res();
}while(!correcto);
Console.WriteLine($"Valido: La nota es de {nota}");
void res()
{
    Console.WriteLine("ingrese la nota del alumno");
    correcto = int.TryParse(Console.ReadLine(), out nota);
    if (correcto)
    {
        if (nota < 0 || nota > 100)
        {
            correcto = false;
            Console.WriteLine("Nota no valida");
        }
    }
    else
    {
        Console.WriteLine("No es un numero");
    }
}