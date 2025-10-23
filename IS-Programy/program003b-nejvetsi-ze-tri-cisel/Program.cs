//více na algoritmy.net
string again = "a";
while (again == "a")
{ 
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Největší ze tří ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Jiří Bertl ******************");
    Console.WriteLine("************** 23.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte první číslo (celé číslo): ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo  znovu: ");
    }

    Console.Write("Zadejte druhé číslo (celé číslo): ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte druhé číslo  znovu: ");
    }

    Console.Write("Zadejte třetí číslo (celé číslo): ");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte třetí číslo  znovu: ");
    }


    if (a > b) //rozhodnutí a vs b
    {
        if (a > c)
        {
            Console.WriteLine("Největší číslo je a: {0}", a);
        }
        else
        {
            Console.WriteLine("Největší číslo je c: {0}", c);
        }

    }
    else
    {
        if (b > c)
        {
            Console.WriteLine("Největší číslo je a: {0}", b);
        }
        else
        {
            Console.WriteLine("Největší číslo je c: {0}", c);
        }
    }   
     



        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


