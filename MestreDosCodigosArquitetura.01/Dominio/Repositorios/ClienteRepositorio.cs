using System;
using System.Collections.Generic;
using MestreDosCodigosArquitetura._01.Dominio.Implementacoes;

namespace MestreDosCodigosArquitetura._01.Dominio.Repositorios
{
    public static class ClienteRepositorio
    {
        private static readonly IDictionary<ulong, ICliente> _clientes = new Dictionary<ulong, ICliente>
        {
            [1] = new Cliente(
                1,
                new DateTime(1987, 6, 5),
                new DateTime(2000, 1, 1),
                1000,
                20)
        };

        public static ICliente Obter(ulong id) =>
            _clientes[id];
    }
}