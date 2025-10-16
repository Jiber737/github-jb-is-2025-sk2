
string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**************** Číslice *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Jiří bertl *******************");
    Console.WriteLine("************** 2.10.2025 *******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    int number;
    Console.WriteLine("ahoj, ahoj, zadej mi tvé číslo a já ti spočítám součet jeho cifer");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
     Console.WriteLine("to se ti moc nepodarilo, zkus to zadat znovu");
    }

    int suma = 0;

    int numberbackup = number; // záloha původního čísla
    int digit; // proměnná pro jednotlivé cifry¨


    if (number < 0)
    {
        number = -number; // z čísla uděláme kladné
    }

    while(number >= 10)
        {
        digit = number % 10; // získání poslední cifry, zbytek po dělení 10
        number = (number - digit) / 10; // odstranění poslední cifry z čísla)
        Console.WriteLine("hodnota zbytku je {0}", digit);
        suma = suma + digit; // přičtení cifry k součtu
        }

    Console.WriteLine("poslední zbytek je {0}", number);
    suma = suma + number; // přičtení poslední cifry k součtu

    Console.WriteLine("ciferný součet čísla {0} je {1}", numberbackup, suma);

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
