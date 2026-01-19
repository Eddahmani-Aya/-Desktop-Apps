class Program
{
    static void Main()
    {
        /*
        //exercice 1 :
        int date_naissance;
        int age;
        Console.WriteLine("Entrez votre date naissance: ");
        date_naissance = int.Parse(Console.ReadLine());
        age = 2025 - date_naissance;
        Console.Write("votre age est " + age + "ans");
        
        //exercice 2 :
        int l, L, P, S;
        Console.WriteLine("Enter la largeur : ");
        l = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter la Longeur : ");
        L = int.Parse(Console.ReadLine());
        S = L * l;
        P = (L + l) * 2;
        Console.Write("le perimetre est " + P + "et la surface est " + S);
        
        //exercice 3 :
        float A, B, sum, P , sus, D;
        Console.WriteLine("Enter le premier nombre : ");
        A = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter le deuxieme nombre: ");
        B = float.Parse(Console.ReadLine());
        sum = A + B;
        P = A * B;
        sus = A - B;
        D = A / B;
        Console.WriteLine(A + " + " + B + " = " +sum);
        Console.WriteLine(A + " * " + B + " = " + P);
        Console.WriteLine(A + " - " + B + " = " + sus);
        Console.WriteLine(A + " / " + B + " = " + D);
        //exercice 4 :
        int A, B , tmp ;
        Console.WriteLine("Enter la valeur de A : ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter la valeur de B: ");
        B = int.Parse(Console.ReadLine());
        tmp = 0;
        tmp = A;
        A = B;
        B = tmp;
        Console.Write("A = " + A + " et B = " + B);
        */
        //exercice 4 :
        float n1, n2, n3, n4, n5, sum, moy;
        Console.WriteLine("Enter la premier note : ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter la deuxieme note: ");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter la troisieme note : ");
        n3 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter la Quatreieme note: ");
        n4 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter la cinqueieme note: ");
        n5 = float.Parse(Console.ReadLine());
        sum = n1 + n2 + n3 + n4 + n5;
        moy = sum / 5;

    }
}


