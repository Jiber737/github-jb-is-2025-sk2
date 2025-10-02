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


    //Console.WriteLine("pro opakování programu stiskni klávesu a");
    //again = Console.ReadLine();
    Console.WriteLine("yadej prvni cislo");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.WriteLine("to se ti moc nepodarilo, ykus to zadat znovu");
    }

}