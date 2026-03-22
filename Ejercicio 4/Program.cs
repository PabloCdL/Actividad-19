//Desarrolle un programa que solicite el año de nacimiento de una persona,
//validando que sea un número válido y que esté en un rango lógico (por ejemplo entre 1900 y el año actual)
DateTime Fecha;
bool correcto;
DateTime fechacomparacion = new DateTime(1900, 12, 25);
do
{
    Console.WriteLine("Ingrese su edad xx/yy/zzzz");
    correcto = DateTime.TryParse(Console.ReadLine(), out Fecha);
    if (correcto)
    {
        if (Fecha < fechacomparacion || Fecha > DateTime.Now)
        {
            correcto = false;
            Console.WriteLine("Fecha invalida");
        }
    }else
    {
        Console.WriteLine("No es fecha");
    }    
}while (!correcto);
Console.WriteLine("Fecha Valida");