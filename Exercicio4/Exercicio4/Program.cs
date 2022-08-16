Console.WriteLine("Insira sua nota: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aluno aprovado!");
}
else if (nota < 7 && nota >= 4)
{
    Console.WriteLine("Aluno em recuperação!");
}
else
{
    Console.WriteLine("Aluno reprovado!");
}
