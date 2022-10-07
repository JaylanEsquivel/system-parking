using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_parking.Models
{
    public class Estacionamento
    {
        /// <summary>
        ///     Classe de controle do estacionamento
        /// </summary>
        /// <param name="precoEntrada"></param>
        /// <param name="precoHora"></param>
        /// <param name="numeroVagas"></param>
        public Estacionamento(decimal precoEntrada, decimal precoHora,int numeroVagas) 
        {
            string[] carros = new string[numeroVagas];
            this.PrecoEntrada = precoEntrada;
            this.PrecoHora = precoHora;
            this.NumeroVagas = numeroVagas;
            this.Carros = carros;
        }
        public decimal PrecoEntrada { get; set; }
        public decimal PrecoHora { get; set; }
        public int NumeroVagas { get; set; }

        public string[] Carros { get; set; }

        // METODOS DO SISTEMA

        public void AdicionarCarro() { 

                Console.WriteLine("Qual a Placa do Carro?");
                string placaCarro = Console.ReadLine();

                string[] carros = this.Carros;
                bool adicionado = false;
                for(int i = 0; i < carros.Length; i++){
                    if(carros[i] == "" || string.IsNullOrWhiteSpace(carros[i]) && adicionado == false){
                        this.Carros[i] = placaCarro;
                        adicionado = true;
                    }
                }

                if (adicionado == false) {
                    Console.WriteLine("Desculpe mais o estacionamento está Lotado!");
                }

                this.Carros = carros;
        }

        public void RemoverCarro() { 

               string[] carros = this.Carros;
                string listCarros = "";

                for(int i = 0; i < carros.Length; i++){
                    if(carros[i] != "" || !string.IsNullOrWhiteSpace(carros[i])){
                        listCarros += carros[i]+" | ";
                    }
                }
            
                Console.WriteLine(listCarros);
                Console.WriteLine("Qual a Placa do Carro que deseja Remover?");
                string placaCarro = Console.ReadLine();

                bool removido = false;
                for(int i = 0; i < carros.Length; i++){
                    if(removido == false && placaCarro == this.Carros[i]){
                        this.Carros[i] = "";
                        removido = true;
                    }
                }

                if (removido == false) {
                    Console.WriteLine("Desculpe a Placa não foi Localizada.");
                }else {
                    Console.WriteLine("Quantas horas o carro ficou no estacionamento?");
                    int horasNoEstacionamento = int.Parse(Console.ReadLine());
                    decimal valorFinal = this.CalcularValorFinal(horasNoEstacionamento);
                    Console.WriteLine($"O Carro: {placaCarro} ficou {horasNoEstacionamento} hr, Valor a ser pago: R$ {valorFinal}");
                }

            this.Carros = carros;
        }

        public void ListarCarrosEstacionado() {
            string[] carros = this.Carros;

              for(int i = 0; i < carros.Length; i++){
                 Console.WriteLine($"Posição n° {i+1} - {carros[i]}");
              }
        }

        public decimal CalcularValorFinal(int horasEstacionado) {

            decimal total = this.PrecoEntrada + (this.PrecoHora * horasEstacionado);

            return total;
        }

        public void ExibirConfiguracoes() {
            Console.WriteLine($"VALOR FIXO DE: R$ {this.PrecoEntrada} | VALOR DA HORA: R$ {this.PrecoHora} | NÚMERO DE VAGAS: {this.NumeroVagas}");
        }

    }
}