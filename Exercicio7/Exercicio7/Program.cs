Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());
for (int l = 1; l <= n; l++)
{
    int linha = l;
    int quadrado = l * l;
    int cubo = l * l * l;
    Console.WriteLine($"{linha} {quadrado} {cubo}");
}
