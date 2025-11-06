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

    Console.WriteLine();
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, min, max);

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("Pseudonáhodná čísla:");

    int kladna = 0;
    int zaporna = 0;
    int nulova = 0;

    int licha = 0;
    int suda = 0;
    int megasoucet = 0;

    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(min, max + 1);
        megasoucet += myRandNumbs[i];
        Console.Write("{0}; ", myRandNumbs[i]);
        if (myRandNumbs[i] > 0)
            kladna++;
        else if (myRandNumbs[i] < 0)
            zaporna++;
        else
            nulova++;

        if (myRandNumbs[i] % 2 == 0)
            suda++;
        else
            licha++;
    }
    Console.WriteLine();
    Console.WriteLine("Počet kladných čísel: {0}, počet záporných čísel: {1}, počet nulových čísel: {2}", kladna, zaporna, nulova);

    Console.WriteLine("průměr vygenerovaných čísel je: {0}", (double)megasoucet / n);
    Console.WriteLine("počet sudých čísel je: {0}, počet lichých čísel je: {1}", suda, licha);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}