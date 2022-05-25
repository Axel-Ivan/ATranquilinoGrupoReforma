//Inicia programa de matrices
int[,] arreglo1 = new int[3, 3];
arreglo1[0, 0] = 1;
arreglo1[0, 1] = 2;
arreglo1[0, 2] = 3;
arreglo1[1, 0] = 4;
arreglo1[1, 1] = 5;
arreglo1[1, 2] = 6;
arreglo1[2, 0] = 7;
arreglo1[2, 1] = 8;
arreglo1[2, 2] = 9;

int[,] arreglo2 = new int[3, 3];
arreglo2[0, 0] = 1;
arreglo2[0, 1] = 1;
arreglo2[0, 2] = 1;
arreglo2[1, 0] = 5;
arreglo2[1, 1] = 6;
arreglo2[1, 2] = 1;
arreglo2[2, 0] = 7;
arreglo2[2, 1] = 8;
arreglo2[2, 2] = 1;

Console.WriteLine(" |" + arreglo1[0, 0] + "   " + arreglo1[0, 1] + "   " + arreglo1[0, 2] + "|" + "     " + "|" + arreglo2[0, 0] + "   " + arreglo2[0, 1] + "   " + arreglo2[0, 2] + "|" + "     " + "|" + (arreglo1[0, 0] + arreglo2[0, 0]) + "   " + (arreglo1[0, 1] + arreglo2[0, 1]) + "    " + (arreglo1[0, 2] + arreglo2[0, 2]) + "|");
Console.WriteLine(" |" + arreglo1[1, 0] + "   " + arreglo1[1, 1] + "   " + arreglo1[1, 2] + "|" + "  +  " + "|" + arreglo2[1, 0] + "   " + arreglo2[1, 1] + "   " + arreglo2[1, 2] + "|" + "  =  " + "|" + (arreglo1[1, 0] + arreglo2[1, 0]) + "   " + (arreglo1[1, 1] + arreglo2[1, 1]) + "   " + (arreglo1[1, 2] + arreglo2[1, 2]) + "|");
Console.WriteLine(" |" + arreglo1[2, 0] + "   " + arreglo1[2, 1] + "   " + arreglo1[2, 2] + "|" + "     " + "|" + arreglo2[2, 0] + "   " + arreglo2[2, 1] + "   " + arreglo2[2, 2] + "|" + "     " + "|" + (arreglo1[2, 0] + arreglo2[2, 0]) + "  " + (arreglo1[2, 1] + arreglo2[2, 1]) + "  " + (arreglo1[2, 2] + arreglo2[2, 2]) + "|");
Console.ReadLine();

//Inicia programa de factorial
Console.WriteLine("Ingrese el número del que desea obtener el factorial: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El resultado del factorial es: " + SumaMatrices.Factorial.getFactorial(numero));