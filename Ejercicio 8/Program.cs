//Desarrolle un programa que solicite un número y calcule su raíz cuadrada,
//validando que el valor ingresado sea numérico y no negativo
double numero;
bool correcto;
do
{
    Console.WriteLine("Ingrese un numero");
    correcto = double.TryParse(Console.ReadLine(), out numero);
    if(correcto)
    {
        if(numero < 0)
        {
            correcto = false;
            Console.WriteLine("Numero invalido");
        }
    }else
    {
        Console.WriteLine("No es un numero");
    }
} while (!correcto);
Console.WriteLine($"La raiz de: {numero} es {Math.Sqrt(numero)}");