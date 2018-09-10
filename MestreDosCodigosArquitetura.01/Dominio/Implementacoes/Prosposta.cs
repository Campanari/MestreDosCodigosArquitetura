namespace MestreDosCodigosArquitetura._01.Dominio.Implementacoes
{
    public class Proposta : IProposta
    {
        public Proposta(ulong clienteId, ulong id, decimal valor, ulong parcelas)
        {
            ClienteId = clienteId;
            Id = id;
            Valor = valor;
            Parcelas = parcelas;
        }

        public ulong ClienteId { get; }
        public ulong Id { get; }
        public decimal Valor { get; }
        public ulong Parcelas { get; }
    }
}