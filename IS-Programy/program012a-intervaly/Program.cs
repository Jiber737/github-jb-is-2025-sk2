string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Tomáš Žižka ***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int min;
    while (!int.TryParse(Console.ReadLine(), out min))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int max;
    while (!int.TryParse(Console.ReadLine(), out max))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.Write("Zadejte ještě do kolika intervalů chcete čísla rozdělit (celé číslo): ");
    int pocetIntervalu;
    while (!int.TryParse(Console.ReadLine(), out pocetIntervalu))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine("\n Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, min, max);

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(min, max);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    int[] intervals = new int[pocetIntervalu];


    Console.WriteLine("\nVznikly následující intervaly: \n" );
    for (int i = 0; i < pocetIntervalu; i++)
    {   
        Console.Write("Do intervalu ");
        int minInterval = min + i * (max - min) / pocetIntervalu;
        int maxInterval = min + (i + 1) * (max - min) / pocetIntervalu;
        Console.Write("<{0}-{1}>", minInterval, maxInterval);
        intervals[i] = 0;
        for (int j = 0; j < n; j++)
        {
            if (myRandNumbs[j] >= minInterval && myRandNumbs[j] < maxInterval)
            {
                intervals[i]++;
            }
        }
        Console.Write(" patří {0} čísel.\n", intervals[i]);
    }

    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}