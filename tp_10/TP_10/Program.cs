class Program
{   
    static void Main()
    {
        //exercice 1:
        int age;
        Console.WriteLine("entrez votre age (Nombre positif non null)");
        age = int.Parse(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine("Eligible");
        }
        else
        {
            Console.WriteLine("N'est pas Eligible");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 2:
        float note;
        Console.WriteLine("Entrez une note");
        note = float.Parse(Console.ReadLine());
        if (note >= 10)
        {
            Console.WriteLine("Vous avez réussi ");
        }
        else
        {
            Console.WriteLine("Vous avez echoue");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 3:
        Console.WriteLine("Entrez le type du compte (Visiteur, Premium, VIP ):");
        string type_compte = Console.ReadLine();
        if (type_compte == "Visiteur") 
        {
            Console.WriteLine("Gratuit");
        }
        else if (type_compte == "Premium") 
        {
            Console.WriteLine("100 DH");
        }
        else if (type_compte == "VIP") 
        {
            Console.WriteLine("300 DH");
        } 
        else
        {
            Console.WriteLine("Type de compte invalide.");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 4:
        float Note;
        Console.WriteLine("Entrez une note");
        Note = float.Parse(Console.ReadLine());
        if (Note<10)
        {
            Console.WriteLine("Insuffisant");
        }
        else if (Note <=13 )
        {
            Console.WriteLine("Moyen");
        }
        else if (Note <=16 )
        {
            Console.WriteLine("Bien");
        }
        else
        {
            Console.WriteLine("Excellent");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 5:
        Console.WriteLine("Entrez  la catégorie premier voyageur :");
        string V1 = Console.ReadLine();
        Console.WriteLine("Entrez  la catégorie deuxieme voyageur :");
        string V2 = Console.ReadLine();
        if (V1 == "Enfant" && V2== "Adulte")
        {
            Console.WriteLine("Réduction de 30%");
        }
        else if (V1 == "Adulte" && V2 == "Adulte")
        {
            Console.WriteLine("Pas de réduction");
        }
        else
        {
            Console.WriteLine(" Informations incorrectes ");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 6:
        Console.WriteLine("Entrer votre pays (Maroc, Algérie, France, Italie):");
        string pays = Console.ReadLine();
        if (pays == "Maroc" || pays == "Algérie")
        {
            Console.WriteLine("Afrique");
        }
        else if (pays == "France" || pays == "Italie")
        {
            Console.WriteLine("Europe");
        }
        else
        {
            Console.WriteLine(" Informations incorrectes ");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 7:
        Console.WriteLine("Entrer votre genre (Homme (H), Femme (F)):");
        string genre = Console.ReadLine();
        int Age;
        Console.WriteLine("entrez votre age (Nombre positif non null)");
        Age = int.Parse(Console.ReadLine());
        if (genre == "Femme" && Age>=36)
        {
            Console.WriteLine("Vous avez une réduction de 40%");
        }
        else if (genre == "Femme" && Age >= 26)
        {
            Console.WriteLine("Vous avez une réduction de 50%");
        }
        else if (genre == "Femme" && Age >= 18)
        {
            Console.WriteLine("Vous avez une réduction de 60%");
        }
        if (genre == "Homme" && Age >= 38)
        {
            Console.WriteLine("Vous avez une réduction de 10%");
        }
        else if (genre == "Homme" && Age >= 29)
        {
            Console.WriteLine("Vous avez une réduction de ¨20%");
        }
        else if (genre == "Homme" && Age >= 10)
        {
            Console.WriteLine("Vous avez une réduction de 30%");
        }
        else
        {
            Console.WriteLine("Informations incorrectes");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 8:
        string correctUsername = "admin"; 
        string correctPassword = "1234";
        Console.Write("Entrez votre nom d'utilisateur : ");
        string username = Console.ReadLine();
        Console.Write("Entrez votre mot de passe : ");
        string password = Console.ReadLine();
        if (username == correctUsername && password == correctPassword)
        {
            Console.WriteLine("Bienvenue");
        }
        else
        {
            Console.WriteLine("Username ou Password Incorrectes");
        }
        Console.WriteLine();
        Console.WriteLine();
        //exercice 9:
        int a;
        int b;
        Console.WriteLine("Entrez le premier Nombre :");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Entrez le deuxiem Nombre :");
        b = int.Parse(Console.ReadLine());
        if(a*b>0)
        {
            Console.WriteLine("Ils ont le même signe");
        }
        else
        {
            Console.WriteLine("Ils ont des signes different");
        }
        //exercice 10:
        Console.Write("Entrez un nombre entier : ");
        int nombre = int.Parse(Console.ReadLine());

        if (nombre % 2 == 0)
        {
            Console.WriteLine("Le nombre est pair.");
        }
        else
        {
            Console.WriteLine("Le nombre est impair.");
        }
        //exercice 11:
            Console.Write("Entrez un montant en dirhams (Dh) : ");
            double montantDh = double.Parse(Console.ReadLine());
            Console.Write("Choisissez la devise (Dollar ou Euro) : ");
            string devise = Console.ReadLine();
            if (devise == "euro")
            {
                double montantEuro = montantDh * 0.092;
                Console.WriteLine( "le montant en Euro est :" +montantEuro);
            }
            else if (devise == "dollar")
            {
                double montantDollar = montantDh * 0.099;
                Console.WriteLine("le montant en Dollar est :" +montantDollar);
            }
            else
            {
                Console.WriteLine("Devise non reconnue. Veuillez choisir 'Dollar' ou 'Euro'.");
            }
        //exercice 12:
        // Demander le premier nombre
        Console.Write("Entrez le premier nombre : ");
        double nombre1 = double.Parse(Console.ReadLine());

        // Demander le deuxième nombre
        Console.Write("Entrez le deuxième nombre : ");
        double nombre2 = double.Parse(Console.ReadLine());

        // Demander l'opérateur
        Console.Write("Choisissez une opération (+, -, *, /) : ");
        char operateur = char.Parse(Console.ReadLine());

        // Effectuer le calcul selon l'opérateur
        switch (operateur)
        {
            case '+':
                Console.WriteLine($"Résultat : {nombre1 + nombre2}");
                break;
            case '-':
                Console.WriteLine($"Résultat : {nombre1 - nombre2}");
                break;
            case '*':
                Console.WriteLine($"Résultat : {nombre1 * nombre2}");
                break;
            case '/':
                if (nombre2 != 0)
                {
                    Console.WriteLine($"Résultat : {nombre1 / nombre2}");
                }
                else
                {
                    Console.WriteLine("Erreur : Division par zéro !");
                }
                break;
            default:
                Console.WriteLine("Opérateur non valide.");
                break;
        }
        //exercice 13:
        // Saisie des 3 nombres
        Console.Write("Saisir A : ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Saisir B : ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Saisir C : ");
        int C = int.Parse(Console.ReadLine());

        // Tri des nombres (ordre décroissant)
        int max, milieu, min;

        if (A >= B && A >= C)
        {
            max = A;
            if (B >= C)
            {
                milieu = B;
                min = C;
            }
            else
            {
                milieu = C;
                min = B;
            }
        }
        else if (B >= A && B >= C)
        {
            max = B;
            if (A >= C)
            {
                milieu = A;
                min = C;
            }
            else
            {
                milieu = C;
                min = A;
            }
        }
        else
        {
            max = C;
            if (A >= B)
            {
                milieu = A;
                min = B;
            }
            else
            {
                milieu = B;
                min = A;
            }
        }

        // Affichage
        Console.WriteLine($"{max}>{milieu}>{min}");
    }
}
