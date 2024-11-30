Console.Clear();
 
int idade;
 
Console.ForegroundColor = ConsoleColor.Green;
Console.Write("Qual é a sua idade:");
Console.ResetColor();
 
idade = Convert.ToInt32(Console.ReadLine());
 
if (idade >= 18 && idade <= 67)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Você pode ser doador de sangue!");
    Console.ResetColor();
}
 
else
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Você não pode ser doador de Sangue");
    Console.ResetColor();
}
