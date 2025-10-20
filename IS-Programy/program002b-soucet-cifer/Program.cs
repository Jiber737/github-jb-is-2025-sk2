string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** SOucet cislic ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jiří Bertl *******************");
    Console.WriteLine("************** 20.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte svoje číslo, kde chcete provést ciferný součet (celé číslo): ");
    int first;
    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

    //first = int.Parse(Console.ReadLine());
    string cislicko =  first.ToString(); //převedení čísla na řetězec v podobě string
    int sum = 0; //tady se bude přičítat
    foreach (char c in cislicko)
    {
        sum += int.Parse(c.ToString()); //každý ynak se převede zpýtkz na číslo a potom se přičte k sum
    }
    Console.WriteLine("ciferný součet čísla {0} je {1}", first, sum);   






    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


