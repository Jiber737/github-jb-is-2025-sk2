string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Tvorba obrazce N **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jiří Bertl *******************");
    Console.WriteLine("************** 25.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    // Vstup hodnoty do programu, řešený lépe
    Console.Write("Zadejte délku výšku písmene N (celé číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }
    /*int prostredni;
    if (height % 2 == 0)
        prostredni = height / 2;
    else
        prostredni = ((height-1) / 2) + 1;
   for (int i = 0; i < prostredni; i++)
    {
        for (int j = 0; j < height; j++)
        {
            if (i <= prostredni)
            {
                if (j < i)
                    Console.Write("  ");
                else
                    Console.Write("* ");
            }

            System.Threading.Thread.Sleep(100);
            //Console.Write("* ");
        }
        
        Console.WriteLine();
    }*/
 // výška trojúhelníku
for (int i = 0; i < height; i++)
{
    // mezery
    for (int j = 0; j < height - i - 1; j++)
        Console.Write("* ");
    
    // hvězdičky
    for (int j = 0; j < 2 * i + 1; j++)
        Console.Write("  ");
    
    Console.WriteLine();
}

    
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}


