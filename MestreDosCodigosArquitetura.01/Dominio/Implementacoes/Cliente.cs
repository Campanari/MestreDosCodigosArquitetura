using System;

namespace MestreDosCodigosArquitetura._01.Dominio.Implementacoes
{
    public class Cliente : ICliente
    {
        public Cliente(ulong id, DateTime dataNascimento, DateTime dataAberturaConta, decimal salario, decimal saldo)
        {
            Id = id;
            DataNascimento = dataNascimento;
            DataAberturaConta = dataAberturaConta;
            Salario = salario;
            Saldo = saldo;
        }

        public ulong Id { get; }
        public DateTime DataNascimento { get; }
        public DateTime DataAberturaConta { get; }
        public decimal Salario { get; }
        public decimal Saldo { get; }
    }
}