namespace MestreDosCodigosArquitetura._01.Dominio.Implementacoes
{
    public class Supervisor : IAnalistaCredito
    {
        private readonly IAnalistaCredito _superior;

        public Supervisor(IAnalistaCredito superior) =>
            _superior = superior;
        
        bool IAnalistaCredito.Aprovar(IProposta proposta) =>
            proposta.Valor <= 5000m && proposta.Parcelas <= 24ul
            || proposta.Valor <= 10000m && proposta.Parcelas <= 36ul
                ? true
                : _superior.Aprovar(proposta);
    }
}