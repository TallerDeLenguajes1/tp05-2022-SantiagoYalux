// See https://aka.ms/new-console-template for more information

/*PUNTO 1*/
/*int num = 0;
Console.WriteLine("ingresa el numero ");
num = int.Parse(Console.ReadLine());


int aux = num;
int numInvert = 0;
while (aux > 0)
{
    numInvert = numInvert * 10 + aux % 10;
    aux = aux / 10;
}

Console.WriteLine("numero original: " + num.ToString());
Console.WriteLine("numero modificado: " + numInvert.ToString());
*/

/*Ejercicio 2*/

ConsoleKeyInfo op;
Menu miMenu = new Menu();

float num1 = 0;
float num2 = 0;
float resultado = 0;

do
{

    miMenu.DibujarMenu();
    op = Console.ReadKey();

    switch (op.Key)
    {
        case ConsoleKey.A:
            //Opción de sumar
            Console.Clear();
            Console.WriteLine("Ingresa el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            num2 = float.Parse(Console.ReadLine());

            resultado = SumarDosNumeros(num1, num2);

            Console.WriteLine($"La suma de {num1} + {num2} = {resultado}");
            Console.ReadKey();
            break;

        case ConsoleKey.B:
            //Opción de restar
            Console.Clear();

            Console.WriteLine("Ingresa el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            num2 = float.Parse(Console.ReadLine());
            resultado = RestarDosNumeros(num1, num2);

            Console.WriteLine($"La resta de {num1} - {num2} = {resultado}");

            Console.ReadKey();
            break;

        case ConsoleKey.C:
            //Opción de multiplicar
            Console.Clear();
            Console.WriteLine("Ingresa el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            num2 = float.Parse(Console.ReadLine());
            resultado = Multiplicar(num1, num2);

            Console.WriteLine($"EL resultado de multiplicar {num1} * {num2} = {resultado}");

            Console.ReadKey();
            break;

        case ConsoleKey.D:
            //Opción de dividir
            Console.Clear();

            Console.WriteLine("Ingresa el dividendo");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el divisor número");
            num2 = float.Parse(Console.ReadLine());
            resultado = Dividir(num1, num2);

            Console.WriteLine($"EL resultado de dividir {num1} * {num2} = {resultado}");

            Console.ReadKey();
            break;

    }
} while (op.Key != ConsoleKey.E);


float SumarDosNumeros(float num1, float num2)
{
    return num1 + num2;
}

float RestarDosNumeros(float num1, float num2)
{
    return num1 - num2;
}

float Multiplicar(float num1, float num2)
{
    return num1 * num2;
}

float Dividir(float num1, float num2)
{
    return num1 / num2;
}


#region Menu
class Menu
{

    #region Metodos
    public void DibujarMenu()
    {
        Console.Clear();

        Console.WriteLine("*************************");
        Console.WriteLine("A- Sumar\n");
        Console.WriteLine("B- Restar\n");
        Console.WriteLine("C- Multiplicar\n");
        Console.WriteLine("D- Dividir\n");
        Console.WriteLine("E- Salir\n");
        Console.WriteLine("*************************");

    }
    #endregion
}
#endregion