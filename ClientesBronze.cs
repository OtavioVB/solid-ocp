using System;

namespace SOLID_OCP
{
    internal class ClientesBronze : Clientes
    {
        internal override int ValorDeResgate(int Valor)
        {
            return 50;
        }
    }
}
