//Desarrolle un programa que solicite el precio de un producto,
//validando que sea un número decimal mayor que 0,
//repitiendo hasta que el usuario ingrese correctamente el valor
bool correcto;
double precio;

do
{
    Console.WriteLine("Ingrese el precio");
    correcto = double.TryParse(Console.ReadLine(), out precio);
    if (correcto)
    {
        if (precio < 0)
        {
            correcto = false;
            Console.WriteLine("Precio no valido");
        }
    }else
    {
        Console.WriteLine("No es un valor numerico");
    }
    
} while (!correcto);
Console.WriteLine("Precio valido");