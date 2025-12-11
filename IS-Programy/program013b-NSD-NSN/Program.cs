string again = "a";
while (again == "a")
{
    Console.Clear();

    razitko ();

    ulong a = nactiCislo("Zadejte číslo a: ");
    ulong b = nactiCislo("Zadejte číslo b: ");

    ulong nsd = vypocitatNSD(a, b);
    ulong nsn = vypocitatNSN(a, b, nsd);

    //zobrazitVysledky(a, b, nsd);
    zobrazitVysledky(a, b, nsd, nsn);
    

    /*Console.WriteLine("NSD čísel {0} a {1} je: {2}", a, b, nsd);
    Console.WriteLine("NSN čísel {0} a {1} je: {2}", a, b, nsn);*/


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


static void razitko() //static znamená, že metoda patří třídě a ne instanci třídy
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("********** 1. metoda wowoowoow ************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("************** Jiří Bertl *****************");
    Console.WriteLine("************** 2.10.2025 ******************");
    Console.WriteLine("*******************************************\n");
}

static ulong nactiCislo(string vyzva) //datovy typ v zavorce se shoduje s datovym typem který je v závorce nahoře
{
    Console.Write(vyzva);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste přirozené číslo. Zadejte prosíím číslo znovu: ");
        Console.ResetColor();
    }
    return cislo; //jakakoliv metoda která není void musí mít return
}


static ulong vypocitatNSD(ulong a, ulong b) // "a" neni totozna promennna jako 'a' tam nahore v kodu, tahle se pouziva v tehle metode
{
    while (a!=b)
    if (a>b)
        a -= b;
    else
        b -= a;

    return a;
}

static void zobrazitVysledky(ulong a, ulong b, ulong nsd, ulong nsn)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\nVýpočet byl úspěšně dokončen!");
    Console.WriteLine("------------------------------");
    Console.WriteLine("NSD čísel {0} a {1} je: {2}", a, b, nsd);
    Console.WriteLine("------------------------------");
    Console.WriteLine("NSN čísel {0} a {1} je: {2}", a, b, nsn);

    Console.ResetColor();
}

static ulong vypocitatNSN(ulong a, ulong b, ulong nsd)
{
    return (a * b) / nsd;
}
