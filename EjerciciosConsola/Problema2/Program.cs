// See https://aka.ms/new-console-template for more information
int num1;
int num2;
int cociente;

try
{
    Console.WriteLine("Esta calculadora solo devuelve resultados enteros");
    Console.WriteLine("Ingrese el dividendo");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el divisor");
    num2 = Convert.ToInt32(Console.ReadLine());
    cociente = Division(num1, num2);
    Console.WriteLine("El resultado de la operacion es " + cociente);
}
catch(System.DivideByZeroException ex){
    Console.WriteLine("No se puede dividir por cero " + ex.Message);
}
catch(System.FormatException ex){
    Console.WriteLine("Error de formato " + ex.Message);
}
catch(System.OverflowException ex){
    Console.WriteLine("Error de desbordamiento  " + ex.Message);
}
catch (System.Exception ex)
{
    Console.WriteLine("Error: " + ex.Message);
}


int Division(int num1, int num2)
{
    int resultado = num1 / num2;
    return resultado;
}