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
        case ConsoleKey.E:
            //Opción de Valor Abs, Cuadrado, Seno... 
            Console.Clear();
            Console.WriteLine("Ingresa el numero");
            num1 = float.Parse(Console.ReadLine());
            OperacionesVariadas(num1);

            Console.ReadKey();
            break;

        case ConsoleKey.F:
            //Opción de Máximo entre dos números 
            Console.Clear();
            Console.WriteLine("Ingresa el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            num2 = float.Parse(Console.ReadLine());

            MaximoDosNumeros(num1, num2);

            Console.ReadKey();
            break;
        case ConsoleKey.G:
            //Opción de Máximo entre dos números 
            Console.Clear();
            Console.WriteLine("Ingresa el primer número");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo número");
            num2 = float.Parse(Console.ReadLine());

            MinimoDosNumeros(num1, num2);

            Console.ReadKey();
            break;

    }
} while (op.Key != ConsoleKey.H);


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

void OperacionesVariadas(float num1)
{
    Console.WriteLine($"El valor absoluto de {num1} = {Math.Abs(num1)}");
    Console.WriteLine($"El cuadrado de {num1} = {Math.Pow(num1, 2)}");

    if (num1 > 0)
        Console.WriteLine($"La raiz cuadrada de {num1} = {Math.Sqrt(num1)}");
    else
        Console.WriteLine("No podemos conocer la raiz cuadrada");

    Console.WriteLine($"El seno de {num1} = {Math.Sin(num1)}");
    Console.WriteLine($"El Coseno de {num1} = {Math.Cos(num1)}");
    Console.WriteLine($"La parte entera de {num1} es = {Math.Truncate(num1)}");
}

void MaximoDosNumeros(float num1, float num2)
{
    if (num1 > num2)
        Console.WriteLine($"El mayor número entre {num1} y {num2} es = {num1}");
    else if (num1 == num2)
        Console.WriteLine($"{num1} y {num2} son iguales");
    else
        Console.WriteLine($"El mayor número entre {num1} y {num2} es = {num2}");
}

void MinimoDosNumeros(float num1, float num2)
{
    if (num1 > num2)
        Console.WriteLine($"El menor número entre {num1} y {num2} es = {num2}");
    else if (num1 == num2)
        Console.WriteLine($"{num1} y {num2} son iguales");
    else
        Console.WriteLine($"El menor número entre {num1} y {num2} es = {num1}");

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
        Console.WriteLine("E- Valor Abs, Cuadrado, Seno...\n");
        Console.WriteLine("F- Máximo entre dos números\n");
        Console.WriteLine("G- Mínimo entre dos números\n");
        Console.WriteLine("H- Salir\n");
        Console.WriteLine("*************************");

    }
    #endregion
}
#endregion