namespace MestreDosCodigosArquitetura._01.Dominio.Implementacoes
{
    public class Diretor : IAnalistaCredito
    {
        private readonly IAnalistaCredito _superior;

        public Diretor(IAnalistaCredito superior) =>
            _superior = superior;
        
        bool IAnalistaCredito.Aprovar(IProposta proposta) =>
            proposta.Valor > 100000m
                ? _superior.Aprovar(proposta)
                : true;
    }
}