Console.Clear();
Console.WriteLine("-------------------------------------------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("************ Šifrovací program *************");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine();
Console.WriteLine("Zadejte text pro šifrování:");
string input = Console.ReadLine() ?? "";
input = input.ToLower(); // převedení na malá písmena a = 97, z = 122
string output = "";

Console.WriteLine("Zadejte posun pro šifrování:");
int change = int.TryParse(Console.ReadLine(), out int result) ? result : 0;

foreach (char c in input)
{
    if ((c + 97) <= 123)
    {
        
        char p = (char)(c-26 + change); // posun o x znaky v tabulce ASCII
        output += p;
    }
    else
    {
        char p = (char)(c + change); // posun o x znaky v tabulce ASCII
        output += p;
    }
}

Console.WriteLine("Šifrovaný text: {0}", output);
Console.ReadLine();