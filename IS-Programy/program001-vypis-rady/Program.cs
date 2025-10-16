string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("****************Výpis řady*****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine("****************2.10.2025******************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    //vstup do programu tadz muyu psat literallz cokoliv a nema to nejmensi efekt na tenhle prográmek
    //Console.WriteLine("yadej prvni cislo rady");

    //int first = int.Parse(Console.ReadLine());

    Console.WriteLine("zadej první  čislo");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("to se ti moc nepodarilo, zkus to zadat znovu");
    }

    //Console.WriteLine("pro opakování programu stiskni klávesu a");
    //again = Console.ReadLine();
    Console.WriteLine("zadej posledni  čislo");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("to se ti moc nepodarilo, zkus to zadat znovu");
    }

    Console.WriteLine("zadej step  čislo");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step))
    {
        Console.WriteLine("to se ti moc nepodarilo, zkus to zadat znovu");
    }


    Console.WriteLine("===================================");
    Console.WriteLine("zadali jste tyto hodnoty: ");
    Console.WriteLine("první číslo: {0}", first);
    Console.WriteLine("poslední číslo: {0}", last);
    Console.WriteLine("step číslo: {0}", step);
    Console.WriteLine("první hodnota je: {0}, poslední hodnota je: {1}, krok je: {2}", first, last, step);
    Console.WriteLine("===================================");





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}