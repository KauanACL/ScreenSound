//Screen Sound
string mensagemDeBoasVindas = "\nBoas vindas ao Screen Sound";

void ExibirMensagemDeBoasVindas ()
{
Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para mostrar todos os artistas");
    Console.WriteLine("Digite 3 para avaliar um artista");
    Console.WriteLine("Digite 4 para mostrar avaliação de um artista");
    Console.WriteLine("Digite 0 para sair");

    Console.Write("\nDigite sua opçao: ");
    
    string opcaoEscolhida = Console.ReadLine()!;
    
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

        
    switch (opcaoEscolhidaNumerica)
    {
        case 1: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 2: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 3: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4: Console.WriteLine("\nVocê escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 0: Console.WriteLine("\nSaindo...");
            break;
        default: Console.WriteLine("\nOpção invalida.");
            break;
    }   

        




}

ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();
