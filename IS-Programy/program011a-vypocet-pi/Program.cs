string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Jiří Bertl ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte číslo na kolik desetinných míst např 0,00001 (reálné číslo): ");
    double presnost;
    while (!double.TryParse(Console.ReadLine(), out presnost))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte prosíííím číslo znovu: ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    double piCtvrt = 1.0;
    double znamenko = 1.0;
    int i = 1;

    while ((1/i) >= presnost)
    {
        i=+2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko * (1/i);
    }


    Console.WriteLine();
    Console.WriteLine("Hodnota čísla pí je: " + 4 *piCtvrt);






    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


