// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
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
            break;
            
        case "2":
            break;

        case "3":
            break;

        case "4":
            exibirMenu = false;
            break;
        
        default:
            Console.WriteLine("Opcao Invalida.");
            break;

    }
}
