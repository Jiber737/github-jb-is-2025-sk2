using System;

class Program
{
    static void Main()
    {
        Uvod(); //hlavni menicko ktere uvede hrace do hry
        while (again == "a")
        {
            Console.CursorVisible = false; 
            ZakladniNastaveni();
           
            while (running)
            {
                Console.Clear();
                VykresliMapu();
                OvladejHrace();
                PohniNepritelem();
                ZkontrolujStav();
            }

            KonecHry();
            OpakovaniHry();
        }
    }

    
    static char[,] originalMapa =
{
    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
    { '#',' ',' ',' ',' ','#',' ',' ',' ',' ','*',' ',' ','#' },
    { '#',' ','#','#',' ','#',' ','#','#','#','#','#',' ','#' },
    { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#' },
    { '#','#',' ','#','#','#','#','#',' ','#',' ','#',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#' },
    { '#',' ','#','#','#','#',' ','#',' ','#','#','#',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','E','#' },
    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
};

    
    /*static char[,] mapa =
{
    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#' },
    { '#','@',' ',' ',' ','#',' ',' ',' ',' ','*',' ',' ','#' },
    { '#',' ','#','#',' ','#',' ','#','#','#','#','#',' ','#' },
    { '#',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#' },
    { '#',' ',' ',' ',' ','X',' ','#',' ','#',' ',' ',' ','#' },
    { '#','#',' ','#','#','#','#','#',' ','#',' ','#',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ','#',' ','#',' ',' ',' ','#' },
    { '#',' ','#','#','#','#',' ','#',' ','#','#','#',' ','#' },
    { '#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','E','#' },
    { '#','#','#','#','#','#','#','#','#','#','#','#','#','#' }
};*/
    static char[,] mapa;


    static void ZakladniNastaveni()
    {
        mapa = (char[,])originalMapa.Clone();

        hracX = 1; //static promenna funguje globalne takze je pristupna ve vsech metodach
        hracY = 1;
        podHracem = ' '; // uklada co je pod hracem na mape
        mapa[hracY, hracX] = '@';

        enemyX = 5;
        enemyY = 4;
        podNepritelem = ' ';
        mapa[enemyY, enemyX] = 'X';


        vyhra = false;
        prohra = false;
        running = true; //dokud je true program pobezi
        maPoklad = false;
        hracZije = true;
    }
    static int hracX = 1; //static promenna funguje globalne takze je pristupna ve vsech metodach
    static int hracY = 1;

    static char podHracem = ' '; // uklada co je pod hracem na mape
    static char podNepritelem = ' ';

    static bool vyhra = false;
    static bool prohra = false;


    static bool running = true; //dokud je true program pobezi
    static bool maPoklad = false;

    static int enemyX = 5;
    static int enemyY = 4;
    static bool hracZije = true;
    static Random rnd = new Random();

    static string again = "a";
    

    static void Uvod()
{
    Console.Clear();
    Console.WriteLine("=== ASCII DUNGEON ===\n");
    Console.WriteLine("Jsi dobrodruh uvězněný v dungeonu.");
    Console.WriteLine("Tvoje postava je (@).\n");
    Console.WriteLine("Tvým cílem je najít poklad (*)");
    Console.WriteLine("a poté dojít k východu (E).\n");

    Console.WriteLine("Pozor na nepřítele (X)!");
    Console.WriteLine("Pokud tě dostihne, zemřeš.\n");

    Console.WriteLine("Ovládání:");
    Console.WriteLine("W A S D - pohyb");
    Console.WriteLine("Q - ukončit hru\n");

    Console.WriteLine("Stiskni libovolnou klávesu pro start...");
    Console.ReadKey(true);
}


    static void VykresliMapu()
    {
        for (int y = 0; y < mapa.GetLength(0); y++) 
        {
            for (int x = 0; x < mapa.GetLength(1); x++)
            {
               VypisSymbol(mapa[y, x]);

            }
            Console.WriteLine();
        }

        Console.WriteLine("\nWASD = pohyb | Q = konec");
        Console.WriteLine(maPoklad ? "Poklad: ANO" : "Poklad: NE");
    }


    static void VypisSymbol(char symbol)
{
    switch (symbol)
    {
        case '@':
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case '#':
            Console.ForegroundColor = ConsoleColor.DarkGray;
            break;
        case '*':
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;
        case 'E':
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        default:
            Console.ForegroundColor = ConsoleColor.White;
            break;
    }

    Console.Write(symbol);
    Console.ResetColor();
}


    static void OvladejHrace()
    {
        ConsoleKey key = Console.ReadKey(true).Key;

        int newX = hracX;
        int newY = hracY;

        switch (key)
        {
            case ConsoleKey.W: newY--; break;
            case ConsoleKey.S: newY++; break;
            case ConsoleKey.A: newX--; break;
            case ConsoleKey.D: newX++; break;
            case ConsoleKey.Q: running = false; break;
        }

        if (mapa[newY, newX] != '#')
        {
            PresunHrace(newX, newY);
        }
    }

static void PresunHrace(int newX, int newY)
{
    // vrátíme původní znak
    mapa[hracY, hracX] = podHracem;

    // zjištění, na co vstupujeme
    if (mapa[newY, newX] == '*')
    {
        maPoklad = true;
        podHracem = ' '; // poklad zmizí
    }
    else
    {
        podHracem = mapa[newY, newX];
    }

    hracX = newX;
    hracY = newY;

    mapa[hracY, hracX] = '@';
}

static void PohniNepritelem()
{
    int smer = rnd.Next(4);

    int newX = enemyX;
    int newY = enemyY;

    switch (smer)
    {
        case 0: newY--; break;
        case 1: newY++; break;
        case 2: newX--; break;
        case 3: newX++; break;
    }

    if (mapa[newY, newX] != '#')
    {
        // vrátíme znak pod nepřítelem
        mapa[enemyY, enemyX] = podNepritelem;

        // uložíme, na co vstupuje
        podNepritelem = mapa[newY, newX];

        enemyX = newX;
        enemyY = newY;

        mapa[enemyY, enemyX] = 'X';
    }
}



   static void ZkontrolujStav()
{
    if (podHracem == 'E')
    {
        if (maPoklad)
            vyhra = true;
        else
            prohra = true;

        running = false;
    }
    if (hracX == enemyX && hracY == enemyY)
    {
        hracZije = false;
        running = false;
    }

}


    static void KonecHry()
{
    Console.Clear();

    if (vyhra)
    {
        Console.WriteLine("🎉 VYHRÁL JSI!");
        Console.WriteLine("Našel jsi poklad a utekl z dungeonů.");
    }
    else if (prohra)
    {
        Console.WriteLine("💀 PROHRÁL JSI!");
        Console.WriteLine("Bez pokladu nemůžeš odejít.");
    }
    else if (!hracZije)
    {
        Console.WriteLine("💀 ZEMŘEL JSI!");
        Console.WriteLine("Nepřítel tě dostihl.");
    }

    else
    {
        Console.WriteLine("Hra ukončena.");
    }

    //Console.ReadKey();
}

    static void OpakovaniHry()
    {
        Console.WriteLine("\nChceš-li hrát znovu, tak stiskni klávesu 'a' ");
        again = Console.ReadLine();
        /*if (again == "a")
            ZakladniNastaveni();*/
    }

    

}
