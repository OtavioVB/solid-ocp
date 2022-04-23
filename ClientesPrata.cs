using System;

namespace SOLID_OCP
{
    internal class ClientesPrata : Clientes
    {
        internal override int ValorDeResgate(int Valor)
        {
            return 100;
        }
    }
}
