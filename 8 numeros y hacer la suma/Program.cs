internal class NewBaseType
{
    static void Main(string[] args)
    {
        Int32 num;
        Int32 suma = 0;
        int i;
        for (i = 1; i <= 8; i++)
        {
            Console.WriteLine("introduce un numero entero:");
            num = Int32.Parse(Console.ReadLine());
            suma = suma + num;
        }
        Console.WriteLine("la suma es:" + suma);
        Console.ReadKey();

    }
}

class Program : NewBaseType
{
}