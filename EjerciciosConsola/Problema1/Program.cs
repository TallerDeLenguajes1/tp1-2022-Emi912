// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero para calcular su cuadrado");
int num;
try
{
    num = Convert.ToInt32(Console.ReadLine());
    int cuadrado = CalcularCuadrado(num);
    Console.WriteLine("El cuadrado del numero ingresado es: " + cuadrado);
}
catch (System.Exception ex)
{
    Console.WriteLine("Error: " +  ex.Message);
}



int CalcularCuadrado(int num)
{
    return num * num;
}