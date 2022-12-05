
class Program
{
    static void Main(string[] args)
    {
        bebidacomponent cafe=new cafesolo();
        cafe = new leche(cafe);
        cafe = new azucar(cafe);

        Console.WriteLine($"producto: {cafe.descripcion} tiene un costo de : ${cafe.costo}");
        Console.ReadKey();

    }
}
