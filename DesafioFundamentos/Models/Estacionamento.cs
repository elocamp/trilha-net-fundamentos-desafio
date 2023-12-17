namespace DesafioFundamentos.Models
{
    public class Estacionamento {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicialInserido, decimal precoPorHoraInicial) {
            precoInicial = precoInicialInserido;
            precoPorHora = precoPorHoraInicial;
        }

        public void AdicionarVeiculo() {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string Placa = Console.ReadLine().ToUpper();
            veiculos.Add(Placa);
            System.Console.WriteLine($"A placa {Placa} foi adicionada com sucesso.");
        }

        public void RemoverVeiculo() {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string Placa = Console.ReadLine().ToUpper();
            

            if (veiculos.Any(x => x.ToUpper() == Placa.ToUpper())) {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int QuantidadeHoras = Convert.ToInt32(Console.ReadLine());
                decimal ValorTotal = precoInicial + (precoPorHora * QuantidadeHoras); 
                veiculos.Remove(Placa);
                Console.WriteLine($"O veículo {Placa} foi removido e o preço total foi de: R$ {ValorTotal}");
            } else{
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos() {
            if (veiculos.Any()) {
                Console.WriteLine("Os veículos estacionados são:");
                foreach(string veiculo in veiculos) {
                    System.Console.WriteLine(veiculo);
                }
            } else {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
