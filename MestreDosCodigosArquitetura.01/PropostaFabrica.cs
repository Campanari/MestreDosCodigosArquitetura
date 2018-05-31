namespace MestreDosCodigosArquitetura._01
{
    public class PropostaFabrica
    {
        private PropostaFabrica()
        {

        }

        private static PropostaFabrica _instancia = null;

        public static PropostaFabrica Instancia => _instancia ?? (_instancia = new PropostaFabrica());

        public IProposta Criar(Cliente cliente, ulong id, decimal valor, ulong parcelas)
        {
            return default(IProposta);
        }
    }
}