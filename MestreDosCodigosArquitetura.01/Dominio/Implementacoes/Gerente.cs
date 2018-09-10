namespace MestreDosCodigosArquitetura._01.Dominio.Implementacoes
{
    public class Gerente : IAnalistaCredito
    {
        private readonly IAnalistaCredito _superior;

        public Gerente(IAnalistaCredito superior) =>
            _superior = superior;
        
        bool IAnalistaCredito.Aprovar(IProposta proposta) =>
            proposta.Valor <= 1000m
            || proposta.Valor < 5000m && proposta.Parcelas <= 12ul
                ? true
                : _superior.Aprovar(proposta);
    }
}