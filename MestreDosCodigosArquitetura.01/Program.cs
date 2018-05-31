using System;

namespace MestreDosCodigosArquitetura._01
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente1 = new Cliente(
                1,
                new DateTime(1987, 6, 5),
                new DateTime(2000, 1, 1),
                1000,
                20);

            var propostaCliente1_1 = PropostaFabrica
                .Instancia
                .Criar(cliente1,
                    1,
                    3000,
                    36);

            var propostaCliente1_2 = PropostaFabrica
                .Instancia
                .Criar(cliente1,
                    2,
                    3000,
                    24);

            var propostas = new [] {
                propostaCliente1_1,
                propostaCliente1_2
            };

            foreach (var proposta in propostas)
            {  
                var aprovada = GerenteRepositorio
                    .Obter()
                    .Aprovar(proposta);

                Console.WriteLine($"A proposta {proposta.Id} do Cliente {proposta.ClienteId} foi {(aprovada ? "Aprovada" : "Reprovada")}"); 
            }
        }
    }
}
