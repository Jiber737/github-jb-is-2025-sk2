string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** NSD a NSN ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Jiří Bertl ******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte 1. číslo (celé číslo): ");
    ulong cislo1;
    while (!ulong.TryParse(Console.ReadLine(), out cislo1))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte prosíííím číslo znovu: ");
        Console.ResetColor();
    }

    Console.Write("Zadejte 2. číslo (celé číslo): ");
    ulong cislo2;
    while (!ulong.TryParse(Console.ReadLine(), out cislo2))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte prosíííím číslo znovu: ");
        Console.ResetColor();
    }


    if (cislo1 < cislo2)
    {
        ulong temp = cislo1;
        cislo1 = cislo2;
        cislo2 = temp; //cislo 1 je vzdy vetsi
    }
    ulong pCislo1 = cislo1;
    ulong pCislo2 = cislo2;
    ulong NSD = 0;
    ulong zbytek;

    do
    {
        zbytek = pCislo1 % pCislo2;
        if (zbytek == 0)
        {
            NSD = pCislo2;
        }
        else
        {
            pCislo1 = pCislo2;
            pCislo2 = zbytek;
        }
    }
    while (zbytek !=0);

    ulong NSN = (cislo1 * cislo2) / NSD;

    Console.WriteLine($"\nNSD čísel {cislo1} a {cislo2} je {NSD}");
    Console.WriteLine($"\nNSN čísel {cislo1} a {cislo2} je {NSN}");


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


