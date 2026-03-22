//Desarrolle un programa que solicite el salario de un empleado,
//validando que sea un número decimal válido mayor o igual a 0
using System.Data.SqlTypes;

double salario;
bool correcto;
do
{
    Console.WriteLine("Ingrese su salario");
    correcto = double.TryParse(Console.ReadLine(), out salario);
    if(correcto)
    {
        if(salario < 0)
        {
            correcto = false;
            Console.WriteLine("Salario invalido");
        }
    }
    else
    {
        Console.WriteLine("No es un valor numerico");
    }

}while (!correcto);
Console.WriteLine($"Valido, el salario es de: {salario}");