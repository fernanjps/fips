internal class NewBaseType
{
    static void Main(string[] args)
    {
        int num = 0;


        do
        {
            Console.WriteLine("ingresar un numero:");
            num = int.Parse(Console.ReadLine());

        } while (num != 0);
        Console.WriteLine("la suma es:" + num);
        Console.ReadKey();
    }
}

class Program : NewBaseType
{
}