using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bergs.ProvacSharp
{
    public class ExceptionPersonalizada : Exception
    {

        public ExceptionPersonalizada()
        { }

        public ExceptionPersonalizada(string message)
        : base(message)
        { }

        public ExceptionPersonalizada(string message, Exception inner)
        : base(message, inner)
        {
        }

        public ExceptionPersonalizada(decimal saque, decimal saldo)
    : base($"\nException: Valor do saque {saque} é superior ao saldo {saldo}")
        { }
    }
}
