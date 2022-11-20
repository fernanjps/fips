/* nombre: fernanjps3A*/
internal class NewBaseType
{
    static void Main(string[] args)
    {
        double n1;
        double n2;
        Console.WriteLine("numero uno;");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("numero dos:");
        n2 = Convert.ToDouble(Console.ReadLine());

        if (n1 > n2)
        {
            Console.WriteLine("el numero" + n1 + "es el mayor");
        }
        else if (n1 < n2)
        {
            Console.WriteLine("el numeros " + n2 + "es el mayor");
        }
        else
        {
            Console.WriteLine("los numeros son iguales.");
        }
        Console.ReadLine();
    }
}

class Program : NewBaseType
{
}