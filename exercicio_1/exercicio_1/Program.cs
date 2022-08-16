Console.WriteLine("Informe o valor A:");
int valorA = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor B:");
int valorB = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o valor C:");
int valorC = int.Parse(Console.ReadLine());

Console.WriteLine($"A área do triângulo retângulo é: {valorA * valorC / 2}");
Console.WriteLine($"A área do circulo é: {3.14 * valorC * valorC}");
Console.WriteLine($"A área do trapézio é: {(valorA + valorB) * valorC / 2}");
Console.WriteLine($"A área do quadrado é: {valorB * valorB}");
Console.WriteLine($"A área do retângulo é: {valorA * valorB}");