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
    Console.Write("Zadejte číslo, jež nutně potřebujete převést do binární soustavy (celé číslo): ");
    int cislo;
    while (!int.TryParse(Console.ReadLine(), out cislo))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte prosíííím číslo znovu: ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    int zbytek = cislo;
    string binarni = "";
    Console.WriteLine();
    
    do {
        if (zbytek % 2 == 0)
        {
            binarni += "0";
        }
        else
        {
            binarni += "1";
        }
        zbytek /= 2;
        cislo /= 2;
    } while (cislo != 0);

    Console.WriteLine("tvoje binární číslo je: ");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = binarni.Length - 1; i >= 0; i--)
    {
        Console.Write(binarni[i]);
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();



  


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


