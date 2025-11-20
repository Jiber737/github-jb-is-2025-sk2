using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** Generátor pseudonáhodných čísel *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("*************** Jiří Bertl ****************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    
    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0}; ", myRandNumbs[i]);
    }

    Console.WriteLine();
    Stopwatch myStopwatch = new Stopwatch();

    int change = 0;
    int compare = 0;

    myStopwatch.Start();

    for (int i = 0; i < n-1; i++)
    { //musí zajistit porovnávání dvou sousedních hodnot
        for (int j = 0; j < n-1-i; j++)
         // porovnání aktuálního a následujícího prvku
        {
            if (myRandNumbs[j] < myRandNumbs[j+1])
            {
                //prohození hodnot
                int temp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j+1];
                myRandNumbs[j+1] = temp;
                change++;
            }
            compare++;

        }

    }
    myStopwatch.Stop();

    int secondMax = myRandNumbs[0];
    int uppr = 0;
    do
    {
        secondMax = myRandNumbs[uppr];
        uppr++;
    }
    while (secondMax == myRandNumbs[0]);
    Console.WriteLine();

    //obrayec obdelniku ktery je prazdny uvnitr
    for (int i = 0; i < secondMax; i++)
    {
        for (int j = 0; j < secondMax; j++)
        {
            if (i <= 1 || i >= secondMax-2)
            {
                Console.Write("* ");
            }
            else if (j == 0 || j == secondMax -1)
            {
                Console.Write("* ");
            }
            else
            {
                Console.Write("  ");
            }
        }
        Console.WriteLine();

    }
    Console.WriteLine();


    Console.WriteLine();
    Console.WriteLine("=============================================");
    Console.WriteLine("seřazená čísla jsou: ");
    for (int i = 0; i < n ; i++)
    {
            Console.Write("{0}; ", myRandNumbs[i]);

    }
    Console.WriteLine();
    Console.WriteLine("=============================================");

    Console.WriteLine();
    Console.WriteLine("počet porovnání: {0}", compare);
    Console.WriteLine("počet prohození: {0}", change);
    Console.WriteLine("čas na seřazení: {0}", myStopwatch.Elapsed);
    Console.WriteLine();

    Console.WriteLine("=============================================");
    Console.WriteLine();
    Console.WriteLine("největší číslo je: {0}", myRandNumbs[0]);
    Console.WriteLine("druhé největší číslo je: {0}", secondMax);
    Console.WriteLine();


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}