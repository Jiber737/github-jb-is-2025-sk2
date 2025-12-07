string again = "a";
Random rnd = new Random();

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
        Console.Write("Nezadali jste celé číslo. Zadejte maximalni cislo znovu: ");
    }

    int suda = 0;
    int licha = 0;
    int nulova = 0;

    int[] pole = new int[i];

    for (int j = 0; j < pole.Length; j++)
    {
        pole[j] = rnd.Next(min, max + 1);

        if (pole[j] == 0)
            nulova++;
        else if (pole[j] % 2 == 1)
            licha++;
        else
            suda++;
    }

    for (int j = 0; j < pole.Length; j++)
    {
        Console.WriteLine("Číslo na pozici {0} je {1}", j + 1, pole[j]);
    }

    Console.WriteLine("počet nulových čísel je: {0}, počet lichých čísel je: {1}, počet sudých čísel je: {2}",nulova, licha, suda);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
