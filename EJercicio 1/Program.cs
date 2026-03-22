//Desarrolle un programa que solicite la edad de una persona,
//validando que el valor ingresado sea un número entero válido, repitiendo hasta que el dato sea correcto y mostrando la edad ingresada
bool correrto;
int edad;

do
{
    Console.WriteLine("Ingrese sue edad");
    correrto = int.TryParse(Console.ReadLine(), out edad);
    if (correrto)
    {
        if (edad < 0 || edad > 120)
        {
            correrto = false;
            Console.WriteLine($"Edad {edad} INVALIDA");
        }
    }
    else
    {
        Console.WriteLine("No es un numero");
    }
} while (!correrto);
    Console.WriteLine("Edad valida");
