string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************ Generátor čísel ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Jiří Bertl ******************");
    Console.WriteLine("************** 6.11.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadejte velikost pole (celé číslo): ");
    int i;
    while (!int.TryParse(Console.ReadLine(), out i))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte velikost pole znovu: ");
    }

    Console.Write("Zadejte nejmensi cislo (celé číslo): ");
    int min;
    while (!int.TryParse(Console.ReadLine(), out min))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte minimalni cislo znovu: ");
    }
     
     Console.Write("Zadejte nejvetsi cislo (celé číslo): ");
    int max;
     while (!int.TryParse(Console.ReadLine(), out max))
     {
         Console.Write("Nezadali jste celé číslo. Zadejte minimalni cislo znovu: ");
     }

    int[] pole = new int[i];
    for (int j = 0; j < pole.Length; j++)
    {
        pole[j] = new Random().Next(min, max); // generování čísla od min do max
    }
    for (int j = 0; j < pole.Length; j++)
    {
        Console.WriteLine("Číslo na pozici {0} je {1}", j + 1, pole[j]);
    }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}