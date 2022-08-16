Console.WriteLine("Hora Otimista: ");
int horaOtimista = int.Parse(Console.ReadLine());

Console.WriteLine("Hora Pessimista: ");
int horaPessimista = int.Parse(Console.ReadLine());

Console.WriteLine("Hora Provável: ");
int horaProvavel = int.Parse(Console.ReadLine());

double pert = (horaOtimista + horaPessimista + (4 * horaProvavel)) / 6;

Console.WriteLine($"Hora Otimista: {horaOtimista}");
Console.WriteLine($"Hora Pessimista: {horaPessimista}");
Console.WriteLine($"Hora Provável: {horaProvavel}");
Console.WriteLine($"Pert = {pert}");