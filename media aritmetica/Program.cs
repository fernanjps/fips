class Program
{
    static void Main(string[] args)
    {
        Console.Write("digite un numero:");
        float nota1 = float.Parse(Console.ReadLine());
        Console.Write("digite un numero:");
        float nota2 = float.Parse(Console.ReadLine());
        Console.Write("digite un numero:");
        float nota3 = float.Parse(Console.ReadLine());
        Console.Write("digite un numero:");
        float nota4 = float.Parse(Console.ReadLine());

        float media= (nota1+ nota2 + nota3 + nota4) / 4;
        Console.WriteLine($"la media aritmetica es:{media}") ;
        Console.ReadLine();
    }
}