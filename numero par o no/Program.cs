/* nombre: fernanjps3A  */

class Program
{
    static void Main(string[] args)
    {
        //determinar si un numero es par 
        Console.Write("introducir el primer numero: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        if(numero % 2 == 0)
        {
            Console.Write("el numero" + numero + "es par.");
        }
        else
        {
            Console.Write("el numero " + numero + " es impar.");
        }
        Console.ReadLine();
    }
}
