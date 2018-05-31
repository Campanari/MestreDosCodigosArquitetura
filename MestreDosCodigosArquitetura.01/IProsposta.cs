namespace MestreDosCodigosArquitetura._01
{
    public interface IProposta
    {
        ulong ClienteId { get; }
        ulong Id { get; }
        decimal Valor { get; }
        ulong Parcelas { get; }
    }
}