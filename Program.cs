using elevador;

ElevadorSocial elevador = new ElevadorSocial();

bool concluido = false;
int opcao;
int opcaoValor;

do
{
    Console.WriteLine(@$"
=======================
|   Seja Bem vindo(a) |
|                     |
| O elevador vai:     |
|                     |
| (1) Entrar pessoas  |
| (2) Sair pessoas    |
| (3) Subir andares   |
| (4) Descer andares  |
|                     |
| (0) Fechar programa |
=======================
");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Quantos pessoas vão entrar?");
            opcaoValor = int.Parse(Console.ReadLine());
            elevador.Entrar(opcaoValor);
            Console.ReadLine();
            Console.Clear();
            break;
        case 2:
            Console.WriteLine($"Quantas pessoas vão sair?");
            opcaoValor = int.Parse(Console.ReadLine());
            elevador.Sair(opcaoValor);
            Console.ReadLine();
            Console.Clear();
            break;
        case 3:
            Console.WriteLine($"Para qual andar deseja subir?");
            opcaoValor = int.Parse(Console.ReadLine());
            elevador.Subir(opcaoValor);
            Console.ReadLine();
            Console.Clear();
            break;
        case 4:
            Console.WriteLine($"Para qual andar deseja descer?");
            opcaoValor = int.Parse(Console.ReadLine());
            elevador.Descer(opcaoValor);
            Console.ReadLine();
            Console.Clear();
            break;
        case 0:
            concluido = true;
            break;
        default:
            break;
    }


} while (concluido == false);