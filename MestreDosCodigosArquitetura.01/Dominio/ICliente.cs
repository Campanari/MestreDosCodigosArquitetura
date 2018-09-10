using System;

namespace MestreDosCodigosArquitetura._01.Dominio
{
    public interface ICliente
    {
        ulong Id { get; }
         DateTime DataNascimento { get; }
         DateTime DataAberturaConta { get; }
         decimal Salario { get; }
         decimal Saldo { get; }
    }
}