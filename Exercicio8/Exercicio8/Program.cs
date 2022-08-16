int tipo = 0;

int candidatoChaves = 0;
int candidatoChiquinha = 0;
int candidatoQuico = 0;
int votosNulo = 0;
int votosBranco = 0;

do
{
    Console.WriteLine("Selecione uma opção: ");
    Console.WriteLine();
    Console.WriteLine("1. Candidato Chaves");
    Console.WriteLine("2. Candidata Chiquinha");
    Console.WriteLine("3. Candidato Quico");
    Console.WriteLine("4. Nulo");
    Console.WriteLine("5. Branco");
    Console.WriteLine("6. Encerrar a Votação");
    Console.Write("Entre com o seu voto: ");

    tipo = int.Parse(Console.ReadLine());
    switch (tipo)
    {
        case 1:
            candidatoChaves++;
            break;
        case 2:
            candidatoChiquinha++;
            break;
        case 3:
            candidatoQuico++;
            break;
        case 4:
            votosNulo++;
            break;
        case 5:
            votosBranco++;
            break;
        case 6:
            Console.WriteLine("----------------------------");
            Console.WriteLine("Número de votos de cada candidato: ");
            Console.WriteLine("Candidato Chaves: " + candidatoChaves);
            Console.WriteLine("Candidata Chiquinha: " + candidatoChiquinha);
            Console.WriteLine("Candidato Quico: " + candidatoQuico);
            Console.WriteLine("Votos Nulo: " + votosNulo);
            Console.WriteLine("Votos Branco: " + votosBranco);

            int votosTotal = candidatoChaves + candidatoChiquinha + candidatoQuico + votosNulo + votosBranco;

            double percNulo = (votosNulo * 100) / votosTotal;
            double percBranco = (votosBranco * 100) / votosTotal;

            Console.WriteLine("Porcentagem de votos em Nulo: " + percNulo + "%");
            Console.WriteLine("Porcentagem de votos em Branco: " + percBranco + "%");

            if (candidatoChaves > candidatoChiquinha && candidatoChaves > candidatoQuico)
            {
                Console.WriteLine("O candidato vencedor foi o Candidato Chaves!");
            }

            else if (candidatoChiquinha > candidatoChaves && candidatoChiquinha > candidatoQuico)
            {
                Console.WriteLine("A candidata vencedora foi a Candidata Chiquinha!");
            }

            else if (candidatoQuico > candidatoChiquinha && candidatoQuico > candidatoChaves)
            {
                Console.WriteLine("O candidato vencedor foi o Candidato Quico!");
            }

            break;
        default:
            Console.WriteLine("Opção inválida, selecione um novo código");
            break;
    }
} while (tipo != 6);