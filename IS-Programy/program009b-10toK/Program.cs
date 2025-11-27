string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********* Jakakoliv soustava <10 ***********");
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
    uint cislo;
    while (!uint.TryParse(Console.ReadLine(), out cislo))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte prosíííím číslo znovu: ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    Console.Write("Zadejte číslo, jež odkazuje na číslo soustavy (3 trojková, 4 - čtyřková): ");
    uint soustava;
    while (!uint.TryParse(Console.ReadLine(), out soustava))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé číslo. Zadejte prosíííím číslo znovu: ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    uint zbytek = cislo;
    string prirustek = "";
    Console.WriteLine();
    uint mod;
    do {
        mod = zbytek % soustava;
        prirustek += mod.ToString();
        zbytek /= soustava;
        cislo /= soustava;
    } while (cislo != 0);

    Console.WriteLine("tvoje číslo v {0}kové soustavě je: ", soustava);
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = prirustek.Length - 1; i >= 0; i--)
    {
        Console.Write(prirustek[i]);
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();



  


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


