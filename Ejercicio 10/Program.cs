//Desarrolle un programa que solicite la cantidad de productos a comprar,
//validando que sea un número entero positivo y luego simule el ingreso de esos productos
int cantidad;
bool correcto;
string productos;
string Aux = "";
do
{
    Console.WriteLine("Ingrese la cantidad de productos a comprar");
    correcto = int.TryParse(Console.ReadLine(), out cantidad);
    if(correcto)
    {
        if(cantidad <= 0)
        {
            correcto = false;
            Console.WriteLine("Cantidad no valida");
        }
    }else
    {
        Console.WriteLine("No es una cantidad.... malo");
    }

}while (!correcto);
for(int i = 1; i <= cantidad; i++)
{
    Console.WriteLine($"Ingrese el producto {i}");
    productos = Console.ReadLine();
    Aux += productos + "\n";
}
Console.WriteLine($"La cantidad de productos es de: {cantidad}\nLos productos fueron:");
Console.WriteLine($"{Aux}");
