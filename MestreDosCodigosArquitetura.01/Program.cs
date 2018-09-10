using System;
using MestreDosCodigosArquitetura._01.Dominio.Fabricas;
using MestreDosCodigosArquitetura._01.Dominio.Repositorios;

namespace MestreDosCodigosArquitetura._01
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente1 = ClienteRepositorio
                .Obter(1);

            var propostaCliente1_1 = PropostaFabrica
                .Instancia
                .Criar(cliente1,
                    1,
                    3000,
                    24);

            var propostaCliente1_2 = PropostaFabrica
                .Instancia
                .Criar(cliente1,
                    2,
                    3000,
                    12);

            var propostas = new [] {
                propostaCliente1_1,
                propostaCliente1_2
            };

            foreach (var proposta in propostas)
            {  
                var aprovada = AnalistaCreditoRepositorio
                    .Obter()
                    .Aprovar(proposta);

                Console.WriteLine($"A proposta {proposta.Id} do Cliente {proposta.ClienteId} foi {(aprovada ? "Aprovada" : "Reprovada")}"); 
            }
        }
    }
}
