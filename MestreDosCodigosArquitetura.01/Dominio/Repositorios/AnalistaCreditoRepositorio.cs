using MestreDosCodigosArquitetura._01.Dominio.Implementacoes;

namespace MestreDosCodigosArquitetura._01.Dominio.Repositorios
{
    public static class AnalistaCreditoRepositorio
    {
        public static IAnalistaCredito Obter() =>
            new Gerente(new Supervisor(new Diretor(new AnalistaFake())));
    }
}