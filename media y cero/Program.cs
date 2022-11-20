class Program
{
    static void Main(string[] args)
    {
        int num = 0;
        int suma = 0;
        int media;
    

        do
        {
            Console.WriteLine("ingresar un numero:");
            num = int.Parse(Console.ReadLine());
            
            suma= suma+ num;
            media= suma /10;
            
        } while (num != 0);
        
        Console.WriteLine($"la media aritmetica: {media} " + suma );
        Console.ReadKey();
    }
}

