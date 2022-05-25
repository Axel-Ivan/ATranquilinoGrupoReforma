Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

int palabraLength = palabra.Length;
palabraLength = palabraLength - 1;
bool palindromo = true;

for (int i = 0; palabraLength >= 0; i++)
{
    if (palabra[i] == palabra[palabraLength])
    {
        palabraLength--;
        palindromo = true;
    }
    else
    {
        palindromo = false;
        break;
    }
}

if (palindromo == true)
{
    Console.WriteLine("La palabra " + palabra + " es un palíndromo");
}
else
{
    Console.WriteLine("La palabra " + palabra + " no es un palíndromo");
}

Console.WriteLine("######################################## \n");

Console.WriteLine("Ingrese la longitud de su serie: ");
int longitud = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El resultado de la serie es: \n");

Practica.Fibonacci.serieFibonacci(longitud);

Console.WriteLine("######################################## \n");

Console.WriteLine("Ingrese el factorial que desea saber: ");
int factorial = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("El resultado del factorial es: " + Practica.Factorial.getFactorial(factorial));

Console.WriteLine("######################################## \n");

Console.WriteLine("Ingrese la cantidad de numeros a ingresar: ");
int longitudArray = Convert.ToInt32(Console.ReadLine());
int[] arreglo = new int[longitudArray];

for(int i = 0; i < longitudArray; i++)
{
    Console.WriteLine("Ingrese el numero " + i + ": ");
    arreglo[i] = Convert.ToInt32(Console.ReadLine());
}

Practica.BurbujaSort.Burbuja(arreglo);
