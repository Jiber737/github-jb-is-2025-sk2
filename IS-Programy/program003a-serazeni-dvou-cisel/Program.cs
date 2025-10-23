//více na algoritmy.net
string again = "a";
while (again == "a")
{ 
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********** Porovnání dvou hodnot ***********");
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

    
      if (a > b)
         {
             Console.WriteLine("číslo a ({0}) je větší než číslo b ({1})", a, b);
         }
         else if (a == b)
         {
             Console.WriteLine("číslo a ({0}) je rovno číslu b ({1})", a, b);
         }
         else
         {
             Console.WriteLine("číslo b ({0}) je větší než číslo a ({1})", b, a);
         }
         
        /*int pom;
        if (a > b)
        {
            pom = a;
            a = b;
            b = pom;
        }

        Console.WriteLine("čísla seřazena od nejmenšího po největší: a = {0}, b = {1}", a, b);
        Console.WriteLine($"Seřazená čísla: a = {a}, b = {b}");*/



        Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


