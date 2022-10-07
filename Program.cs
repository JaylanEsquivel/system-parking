using system_parking.Models;
// PEGA OS DADOS INICIAIS DO ESTACIONAMENTO
Console.WriteLine("::: SEJA BEM VINDO AO SYSTEM CAR :::");
Console.WriteLine("Qual o Valor fixo de entrada ?");

decimal valorFixo = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual o Valor por hora ?");

decimal valorDaHora = decimal.Parse(Console.ReadLine());

Console.WriteLine("Qual número de vagas disponíveis ?");

int quantidadeVagas = int.Parse(Console.ReadLine());
// PEGA OS DADOS INICIAIS DO ESTACIONAMENTO

Estacionamento myEstacionamento = new Estacionamento(valorFixo,valorDaHora,quantidadeVagas);
Console.Clear();

//myEstacionamento.ListarCarrosEstacionado();
Formatacao formatar = new Formatacao(); // struct para organizar quebra de linhas.

string opcao = "a";
while(opcao != "44"){

    //Console.Clear();
    Console.WriteLine("DIGITE A SUA OPÇÃO:");
    Console.WriteLine("1 - Cadastrar Carro");
    Console.WriteLine("2 - Remover Carro");
    Console.WriteLine("3 - Listar Carros estacionados");
    Console.WriteLine("4 - Ver configurações");
    Console.WriteLine("5 - Encerrar");

    opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                formatar.PularLinha();
                Console.WriteLine("Cadastrar Carro");
                myEstacionamento.AdicionarCarro();
                formatar.QuebraLinha();
                break;
            case "2":
                formatar.PularLinha();
                Console.WriteLine("Remover Carro");
                myEstacionamento.RemoverCarro();
                formatar.QuebraLinha();
                break;
            case "3":
                formatar.PularLinha();
                Console.WriteLine("Listar Carros estacionados:");
                myEstacionamento.ListarCarrosEstacionado();
                formatar.QuebraLinha();
                break;
            case "4":
                formatar.PularLinha();
                myEstacionamento.ExibirConfiguracoes(); 
                formatar.QuebraLinha();
                break;
            case "5":
                Console.WriteLine("Encerrar, Obrigado");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Inválido");
                break;
        }

}

