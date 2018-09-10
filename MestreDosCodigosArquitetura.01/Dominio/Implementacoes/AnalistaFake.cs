namespace MestreDosCodigosArquitetura._01.Dominio.Implementacoes
{
    public class AnalistaFake : IAnalistaCredito
    {
        bool IAnalistaCredito.Aprovar(IProposta proposta) =>
            false;
    }
}