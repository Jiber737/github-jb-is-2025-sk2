string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Tvorba obdelniku **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jiří Bertl *******************");
    Console.WriteLine("************** 23.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte šířku (celé číslo): ");
    int width;
    while (!int.TryParse(Console.ReadLine(), out width))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo  znovu: ");
    }

    Console.Write("Zadejte výšku (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první druhé  znovu: ");
    }

    // Vypisování obdelníku
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("*");
            if (i % 2 == 1)
            {
                Console.Write("*");
            }
else if 
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    







    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


