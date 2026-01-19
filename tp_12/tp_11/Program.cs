class Program
{
    static void Main()
    {
        //exercice 1:
        for (int i=1;i<=10; i++)
        {
            Console.WriteLine(i);
        }
        //exercice 2:
        for (int i = 1; i <= 100; i=i+3)
        {
            Console.Write(" "+i);
        }
        Console.WriteLine();
        //exercice 3:
        Console.WriteLine("entrez le nombre de départ");
        int n = int.Parse(Console.ReadLine());
        for (int i = n+1; i <= n+10; i++)
        {
            Console.Write(" " + i);
        }
        //exercice 4:
        Console.WriteLine("entrez un nombre ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " * " +i+ " = " +n*i );
        }
        //exercice 6:
        int F = 1;
        Console.WriteLine("entrez un nombre strictement supérieur à 0 de départ:");
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
        {
            F = F * i;
        }
        Console.WriteLine("le factorielle de ce nombre est: " + F);
        //exercice 7:
        Console.WriteLine("entrez un nombre strictement supérieur à 0 de départ:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Les diviseurs de {n} sont :");
        for (int i = 1; i <= n; i++)
        {
            if(n % i == 0)
            {
                Console.WriteLine(" " + i);
            }
        }
        
    }
}