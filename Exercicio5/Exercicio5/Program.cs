Console.WriteLine("Escolha uma opção: ");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine("Bom dia!");
        break;
    case 2:
        Console.WriteLine("Boa tarde!");
        break;
    case 3:
        Console.WriteLine("Boa noite!");
        break;
}