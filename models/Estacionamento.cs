using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_fundamentos_desafio.models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
            Console.WriteLine(precoPorHora);
        }
        private List<string> veiculos = new List<string>();

        public void adicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar: ");
            string nomeVeiculo = Console.ReadLine();
            veiculos.Add(nomeVeiculo);
        }

        public void removerVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            string nomeVeiculo = Console.ReadLine();
            if (veiculos.Any(x => x == nomeVeiculo))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado: ");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = (horas * precoPorHora) + precoInicial;
                Console.WriteLine($"O veiculo {nomeVeiculo} foi removido. O preco total é de R$ {valorTotal}.");
                veiculos.Remove(nomeVeiculo);
            }
            else{
                Console.WriteLine("Nao existe veiculo com esta placa estacionado! ");
            }
        }

        public void listarVeiculo()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("--- Veiculos Estacionados ----");
                veiculos.ForEach(veiculo => Console.WriteLine(veiculo));
                Console.WriteLine("-----------------------------");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}