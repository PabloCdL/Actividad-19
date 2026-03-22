//Desarrolle un programa que solicite la cantidad de estudiantes en un curso,
//validando que sea un número entero positivo, evitando valores negativos o letras
bool correcto;
int alumnos;
do
{
    Console.WriteLine("Ingrese la cantidad de alumnos");
    correcto = int.TryParse(Console.ReadLine(), out alumnos);
    if (correcto)
    {
        if (alumnos < 0)
        {
            Console.WriteLine($"Valores negativo son invalidos");
        }
    }else
    {
        Console.WriteLine("No es un numero");
    }
}while (!correcto);
Console.WriteLine($"La cantidad de alumnos es de: {alumnos}");