using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankovniPrikladPatek
{
    public class BankingException : Exception
    {
        public BankingException()
        {
        }

        public BankingException(string message) : base(message)
        {
        }

        public BankingException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BankingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
