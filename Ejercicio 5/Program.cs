//Desarrolle un programa que solicite un número entero y determine si es par o impar,
//validando previamente que el dato ingresado sea correcto

bool correcto;
double numero;
do
{
    Console.WriteLine("Ingrese un numero");
    correcto = double.TryParse(Console.ReadLine(), out numero);
    if(correcto)
    {
        if(numero % 2 != 0)
        {
            correcto = false;
            Console.WriteLine("Numero impar");
        }
    }else
    {
        Console.WriteLine("No es un numero");
    }
}while (!correcto);
Console.WriteLine("Par");