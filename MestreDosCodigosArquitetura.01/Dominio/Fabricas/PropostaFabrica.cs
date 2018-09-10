using MestreDosCodigosArquitetura._01.Dominio.Implementacoes;

namespace MestreDosCodigosArquitetura._01.Dominio.Fabricas
{
    public class PropostaFabrica
    {
        private static PropostaFabrica _instancia = null;

        public static PropostaFabrica Instancia => _instancia ?? (_instancia = new PropostaFabrica());

        public IProposta Criar(ICliente cliente, ulong id, decimal valor, ulong parcelas) =>
            new Proposta(cliente.Id, id, valor, parcelas);
    }
}