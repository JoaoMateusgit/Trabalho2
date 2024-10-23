using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    public class CodigoDezException : Exception
    {

        public CodigoDezException()
        { }

        public CodigoDezException(string message)
        : base(message)
        { }

        public CodigoDezException(string message, Exception inner)
        : base(message, inner)
        {
        }

        public CodigoDezException(decimal saque, decimal saldo)
    : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}")
        { }
    }
}
