/* nombre: fernanjps3A       */
class Program
{
    static void Main(string[] args)
    {
        double n1, n2, n3;
        Console.WriteLine("primer lado:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("segundo lado:");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("tercer lado:");
        n3 = Convert.ToDouble(Console.ReadLine());
        if (n1 == n2 && n1==n3)
            Console.WriteLine("es equilatero");
        else    
        {
            if (n1== n2 ||n1 ==n3 || n3==n2)
                Console.WriteLine("es isosceles");
            else
            {
                if (n1 != n2 || n2!=n3 || n3 != n1)
                    Console.WriteLine("es escaleno");
            }    
        }
        Console.Read();

    }
}