internal class NewBaseType
{
    static void Main(string[] args)
    {
        int num = 0;
        int suma = 0;

        do
        {
            Console.WriteLine("ingresar un numero:");
            num = int.Parse(Console.ReadLine());
            suma = suma + num;
        } while (num != 0);
        Console.WriteLine("la suma es:" + suma);
        Console.ReadKey();
    }
}

class Program : NewBaseType
{
}
