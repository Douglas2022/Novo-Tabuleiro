using System;
using System.Runtime.Serialization;
namespace Tabuleiro
{
    class TabuleiroException : Exception
    {
        public TabuleiroException(string msg) : base(msg)
        {

        }

        public class e : Exception
        {
            public e(string message) : base(message)
            {

            }
        }
    }
}
