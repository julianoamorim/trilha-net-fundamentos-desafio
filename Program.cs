using trilha_net_fundamentos_desafio.models;


Console.WriteLine("Sistema de Estacionamento!");
Console.WriteLine("Digite o valor inicial para estacionar o carro:");
decimal valorInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Digite o valor da hora do estacionamento:");
decimal precoPorHora = Convert.ToDecimal(Console.ReadLine());
Estacionamento estacionar = new Estacionamento(valorInicial, precoPorHora);



bool exibirMenu = true;
while(exibirMenu){
    Console.WriteLine("Digite sua opcao: ");
    Console.WriteLine("1 - Cadastrar veiculo");
    Console.WriteLine("2 - Remover veiculo");
    Console.WriteLine("3 - Listar veiculo");
    Console.WriteLine("4 - Encerrar");

    string opcao = Console.ReadLine();
    switch(opcao){
        case "1":
            estacionar.adicionarVeiculo();
            break;
            
        case "2":
            estacionar.removerVeiculo();
            break;

        case "3":
            estacionar.listarVeiculo();
            break;

        case "4":
            exibirMenu = false;
            Console.WriteLine("Encerrando o Sistema!");
            break;
        
        default:
            Console.WriteLine("Opcao Invalida.");
            break;

    }
}
