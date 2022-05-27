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
/*
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
#endregion*/


/*EJERCICIO 4*/

ConsoleKeyInfo op;
Menu miMenu = new Menu();
string cadena = "";
do
{

    miMenu.DibujarMenu();
    op = Console.ReadKey();

    switch (op.Key)
    {
        case ConsoleKey.A:
            //Obtener algunas letras que forman parte de una cadena
            Console.Clear();
            Console.WriteLine("Ingresa la palabra");
            cadena = Console.ReadLine();
            ObtenerLetras(cadena);
            Console.ReadKey();
            break;

        case ConsoleKey.B:
            //Obtener la longitud de la cadena y muestre por pantalla
            Console.Clear();

            Console.WriteLine("Ingresa una cadena");
            cadena = Console.ReadLine();
            ObtenerLongitud(cadena);

            Console.ReadKey();
            break;

        case ConsoleKey.C:
            //Concatenar (Unir) dos cadenas distintas
            Console.Clear();

            UnirDosCadenas();

            Console.ReadKey();
            break;

        case ConsoleKey.D:
            //Extraer una subcadena

            Console.Clear();

            Console.WriteLine("Ingresa una cadena");
            cadena = Console.ReadLine();
            ExtraerUnaSubCadena(cadena);

            Console.ReadKey();
            break;
        case ConsoleKey.E:
            //Recorrer la cadena de texto 
            Console.Clear();

            Console.WriteLine("Ingresa una cadena");
            cadena = Console.ReadLine();
            RecorrerCadena(cadena);

            Console.ReadKey();
            break;

        case ConsoleKey.F:
            //Buscar la ocurrencia de una palabra determinada en la cadena ingresada
            Console.Clear();
            Console.WriteLine("Ingresa una cadena");
            cadena = Console.ReadLine();

            Console.WriteLine("ingresa la palabra buscada");
            string palabra = Console.ReadLine();
            PalabraEnCadena(cadena, palabra);

            Console.ReadKey();
            break;
        case ConsoleKey.G:
            //Convierta la cadena a Mayúsculas y luego minúsculas
            Console.Clear();
            Console.WriteLine("Ingresa una cadena");
            cadena = Console.ReadLine();
            MayusMinusCadena(cadena);
            Console.ReadKey();
            break;

        case ConsoleKey.H:
            //Ingrese una cadena separada por caracteres que usted determine y muestre por
            //pantalla los resultados
            Console.Clear();
            Console.WriteLine("Ingresa una cadena");
            cadena = Console.ReadLine();
            SepararCadena(cadena);
            Console.ReadKey();
            break;

        case ConsoleKey.I:
            //Ingrese una cadena separada por caracteres que usted determine y muestre por
            //pantalla los resultados
            Console.Clear();
            Console.WriteLine("Ingresa una ecuación");
            cadena = Console.ReadLine();
            ResolverEcuacion(cadena);

            Console.ReadKey();
            break;

    }
} while (op.Key != ConsoleKey.J);



void ObtenerLetras(string palabra)
{

}

void ObtenerLongitud(string palabra)
{
    Console.WriteLine("la longitud de la palabra es ", (palabra.Length).ToString());
}

void UnirDosCadenas()
{
    string primeraCadena;
    string segundaCadena;

    Console.WriteLine("Ingresa la primera cadena");
    primeraCadena = Console.ReadLine();
    Console.WriteLine("Ingresa la segunda cadena");
    segundaCadena = Console.ReadLine();

    string cadenaUnida = string.Concat(primeraCadena, segundaCadena);
    Console.WriteLine($"Las cadenas concatenadas = {cadenaUnida}");

}

void ExtraerUnaSubCadena(string frase)
{
    int inicio = 0;
    Console.WriteLine("Ingresa desde donde quieren obtener la cadena");
    inicio = int.Parse(Console.ReadLine());
    string subcadena = frase.Substring(inicio);

    Console.WriteLine($"la cadena obtenida es {subcadena}");
}

void RecorrerCadena(string cadena)
{
    Console.WriteLine($"------Cadena Letra por Letra------");
    foreach (var letra in cadena)
    {
        Console.WriteLine(letra);
    }

    Console.WriteLine($"----------------------------------");
}

void PalabraEnCadena(string cadena, string palabra)
{
    int cantidad = 0;
    var cadenaSeparada = cadena.Split(" ");

    foreach (var word in cadenaSeparada)
    {
        if (palabra == word)
            cantidad++;
    }


    if (cantidad > 0)
        Console.WriteLine($"la palabra se encontro un total de {cantidad} veces");
    else
        Console.WriteLine("La palabra buscada no se encuentra en la cadena");
}

void MayusMinusCadena(string cadena)
{
    Console.WriteLine($"En mayusculas {cadena.ToUpper()}");
    Console.WriteLine($"En mayusculas {cadena.ToLower()}");
}

void SepararCadena(string cadena)
{
    string caracter;
    Console.WriteLine("Escriba el caracter que usará para separa su cadena");
    caracter = Console.ReadLine();

    var cadenaSeparada = cadena.Split(caracter);

    foreach (var word in cadenaSeparada)
    {
        Console.WriteLine(word);
    }
}

void ResolverEcuacion(string cadena)
{
    float resultado = 0;


    if ((cadena.Split("+")).Length > 1)
    {
        var cadenaSepara = cadena.Split("+");

        foreach (var numero in cadenaSepara)
        {
            resultado += float.Parse(numero);
        }
        Console.WriteLine($"el resultado de la suma es = {resultado}");
    }
    else if ((cadena.Split("-")).Length > 1)
    {
        int first = 1;
        var cadenaSepara = cadena.Split("-");
        foreach (var numero in cadenaSepara)
        {
            if (first == 1)
            {
                resultado = float.Parse(numero);
                first = 2;
            }
            else
                resultado -= float.Parse(numero);
            
        }
        Console.WriteLine($"el resultado de la resta es {resultado}");

    }
    else if ((cadena.Split("*")).Length > 1)
    {
        var cadenaSepara = cadena.Split("*");
        resultado = 1;

        foreach (var numero in cadenaSepara)
        {
            resultado *= float.Parse(numero);
        }
        Console.WriteLine($"el resultado de la multiplicación es {resultado}");
    }
    else if ((cadena.Split("/")).Length > 1)
    {
        int first = 1;
        var cadenaSepara = cadena.Split("/");

        foreach (var numero in cadenaSepara)
        {
            if (first == 1)
            {
                resultado = float.Parse(numero);
                first = 2;
            }
            else
            resultado /= float.Parse(numero);
        }
        Console.WriteLine($"el resultado de la división es {resultado}");

    }
}

#region Menu
class Menu
{

    #region Metodos
    public void DibujarMenu()
    {
        Console.Clear();

        Console.WriteLine("*************************");
        Console.WriteLine("A- Obtener algunas letras que forman parte de una cadena\n");
        Console.WriteLine("B- Obtener la longitud de la cadena y muestre por pantalla\n");
        Console.WriteLine("C- Concatenar (Unir) dos cadenas distintas\n");
        Console.WriteLine("D- Extraer una subcadena\n");
        Console.WriteLine("E- Recorrer la cadena de texto\n");
        Console.WriteLine("F- Buscar la ocurrencia de una palabra determinada en la cadena ingresada\n");
        Console.WriteLine("G- Convierte la cadena a Mayúsculas y luego minúsculas\n");
        Console.WriteLine("H- Cadena separada por un caracter\n");
        Console.WriteLine("i- Operación matemática con cadena\n");
        Console.WriteLine("j- Salir\n");
        Console.WriteLine("*************************");

    }
    #endregion
}
#endregion
