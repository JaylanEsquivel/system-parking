using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace system_parking.Models
{
    public class Estacionamento
    {
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

        }

        public void RemoverCarro() { 

        }

        public void ListarCarrosEstacionado() {
            string[] carros = this.Carros;

            for(int i = 0; i < carros.Length; i++){
                 Console.WriteLine($"Posição n° {i+1} - {carros[i]}");
              }
                 Console.WriteLine("Obrigado!");
        }

        public decimal CalcularValorFinal() {
            decimal total = 20;

            return total;
        }
    }
}