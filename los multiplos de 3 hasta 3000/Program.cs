int i = 1; int c = 0;
Console.Write("ingresar un numero: ");
int n = int.Parse(Console.ReadLine());
while(i <= n)
{
    if(i % 3 == 0)
    {
        c = c + 1;
    }
    i = i + 1;
}
Console.Write($"la cantidad de numeros multiplos de 3 son: {c} " );
Console.ReadKey();