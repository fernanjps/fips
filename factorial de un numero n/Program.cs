class Program
{
    public static void Main(string[] args)
    {
        int n, cont , fact;
        Console.WriteLine("digite el valor de n!: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("el factorial de {0} es 1" , n);
        }
        else
        {
            fact = n;
            for (cont = n; cont > 1; cont--)
            {
                fact = fact * (cont -1);
            }
            Console.WriteLine("el factorial de {0} es: {1}" , n , fact );
        }
        Console.ReadKey();
    }
}