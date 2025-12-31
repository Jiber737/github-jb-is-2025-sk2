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
    int min;

    while (!int.TryParse(Console.ReadLine(), out min))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int max;

    while (!int.TryParse(Console.ReadLine(), out max) || max <= min)
    {
        Console.Write("Nezadali jste správné číslo. Zadejte znovu horní mez (musí být větší než dolní mez): ");
    }

    Console.WriteLine();
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, min, max);

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();
    int nejvetsiCislo = min;
    int nejmensiCislo = max;
    Console.WriteLine("\nPseudonáhodná čísla:");
    for (int i = 0; i < n ; i++) //generovani čísel do pole
    {
        myRandNumbs[i] = myRandNumb.Next(min, max);
        Console.Write("{0}; ", myRandNumbs[i]);
        
    }

    foreach (int cislo in myRandNumbs) //hledani nejvetsiho a nejmensiho cisla v poli
    {
        if (cislo > nejvetsiCislo)
        {
            nejvetsiCislo = cislo;
        }
        if (cislo < nejmensiCislo)
        {
            nejmensiCislo = cislo;
        }
    }
    Console.WriteLine("\n-------------------------------------");

    Console.WriteLine($"Nejmenší číslo je: {nejmensiCislo}");
    Console.Write("všechhy pozice minima jsou: ");
    for (int i = 0; i < n; i++) // vypis cisel v poli
    {
        if (myRandNumbs[i] == nejmensiCislo)
        {
        Console.Write("{0}; ", i+1);
        }
    }
    Console.WriteLine("\n-------------------------------------");

    Console.WriteLine($"Největší číslo je: {nejvetsiCislo}");
    Console.Write("všechhy pozice maxima jsou: ");
    for (int i = 0; i < n; i++) // vypis cisel v poli
    {
        if (myRandNumbs[i] == nejvetsiCislo)
        {
        Console.Write("{0}; ", i+1);
        }
    }
    Console.WriteLine("\n-------------------------------------\n");

    for (int i = 0; i < n-1; i++) // vypis cisel v poli
    {
        for (int j = 0; j < n-1-i ; j++)
        {
            if (myRandNumbs[j] > myRandNumbs[j+1])
            {
                //prohození hodnot
                int temp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j+1];
                myRandNumbs[j+1] = temp;
            }
        }
    }
    Console.Write("\nSeřazená čísla jsou: ");
    for (int i = 0; i < n/2 ; i++)
    {
        int temp = myRandNumbs[i];
        myRandNumbs[i] = myRandNumbs[n-i-1];
        myRandNumbs[n-i-1] = temp;
    }
    foreach (int cislo in myRandNumbs)
    {
        Console.Write("{0}; ", cislo);
    }

    int secondMax;
    int pocitadlo = 0;
    do
    {
        secondMax = myRandNumbs[pocitadlo];
        pocitadlo++;
    }
    while (secondMax == nejvetsiCislo);
    Console.WriteLine($"\nDruhé největší číslo je: {secondMax}");

    int thirdMax;
    pocitadlo = 0;
    do
    {
        thirdMax = myRandNumbs[pocitadlo];
        pocitadlo++;
    }
    while (thirdMax >= secondMax);
    Console.WriteLine($"Třetí největší číslo je: {thirdMax}");

    int fourthMax;
    pocitadlo = 0;
    do
    {
        fourthMax = myRandNumbs[pocitadlo];
        pocitadlo++;
    }
    while (fourthMax >= thirdMax);
    Console.WriteLine($"Čtvrté největší číslo je: {fourthMax}");
    Console.Write("převedeno do binární soustavy: ");
    
    string binarni = "";
    do
    {
        if (fourthMax % 2 == 0)
        {
            binarni += "0";
        }
        else
        {
            binarni += "1";
        }
        fourthMax /= 2;
    }
    while (fourthMax !=0);
    for (int i = binarni.Length - 1; i >= 0; i--)
    {
        Console.Write(binarni[i]);
    }
    
    int median;
    if (n % 2 == 1)
    {
        median = myRandNumbs[n / 2 + 1];
    }
    else
    {
        median = (myRandNumbs[n / 2] + myRandNumbs[n / 2 - 1])/2;
    }
    Console.WriteLine($"\nMedián je: {median}");

    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}