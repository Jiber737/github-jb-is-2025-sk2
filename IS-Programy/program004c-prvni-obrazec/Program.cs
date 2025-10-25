string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Tvorba obrazce N **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jiří Bertl *******************");
    Console.WriteLine("************** 25.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte délku výšku písmene N (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    /* Console.Write("Zadejte délku základny (celé číslo): ");
    int down;
    while (!int.TryParse(Console.ReadLine(), out down))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první druhé  znovu: ");
    }
    */

    // Vypisování trojuhelniku
    for (int i = 0; i < height; i++)
    {
        Console.Write("* ");
        for (int j = 0; j < height; j++)
        {
            if (j == i)
            {
                Console.Write("* ");
            }
            else
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }
    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


