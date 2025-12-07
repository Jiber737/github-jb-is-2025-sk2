using System.Security.Authentication.ExtendedProtection;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Min-max a obrazek **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Jiří Bertl ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.White;


    Console.Write("Zadejte počet čísel (celé číslo): ");
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost pole znovu: ");
    }


    Console.Write("Zadejte nejmensi cislo (celé číslo): ");
    int lowerBound;
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte minimalni cislo znovu: ");
    }
     
     Console.Write("Zadejte nejvetsi cislo (celé číslo): ");
    int upperBound;
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte minimalni cislo znovu: ");
    }
 
    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", i, lowerBound, upperBound);
    Console.WriteLine("================================================");  

    int[] myRandNumbs = new int[i];

    int maximum = myRandNumbs[0];
    int minimum = myRandNumbs[0];
    int minpoz = 0;
    int maxpoz = 0;

    for (int j = 0; j < myRandNumbs.Length; j++)
    {
        myRandNumbs[j] = new Random().Next(lowerBound, upperBound); // generování čísla od min do max
        Console.Write("{0}; ", myRandNumbs[j]);
        
        //if (myRandNumbs[j] == maximum)
        if (myRandNumbs[j] > maximum)
        {  
            maximum = myRandNumbs[j];
            maxpoz = j + 1;
        }
        else if (myRandNumbs[j] < minimum)
        {
            minimum = myRandNumbs[j];
            minpoz = j + 1;
        }
    }
    Console.WriteLine();
    Console.WriteLine("-------------------");
    //Console.WriteLine("minimum je {0}", minimum);
    Console.WriteLine("pozice pro minimum: {0}, hodnota minima: {1}", minpoz, minimum);
    Console.WriteLine("pozice pro maximum: {0}, hodnota maxima: {1}", maxpoz, maximum);

    Console.WriteLine("-------------------");

    if (maximum > 3)
    {
        for (int ob = 0; ob < maximum; ob++) //obrazec presypacich hodin
        {
            int spaces, stars;

            if (ob < maximum / 2)
            {
                spaces = ob;
                stars = maximum - 2 * ob;
                for (int s = 0; s < spaces; s++)
                {
                    Console.Write("  ");
                }
                for (int s = 0; s < stars; s++)
                {
                    Console.Write("* ");
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                spaces = maximum - ob - 1;
                stars = 2 * ob - maximum + 2;
                for (int s = 0; s < spaces; s++)
                {
                    Console.Write("  ");
                }
                for (int s = 0; s < stars; s++)
                {
                    Console.Write("* ");
                }
            }
            Console.WriteLine();
        }
    }
    else
        Console.WriteLine("Obrazec presypacich hodin nelze vykreslit pro maximum {0}:", maximum);

    Console.ForegroundColor = ConsoleColor.White;



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}