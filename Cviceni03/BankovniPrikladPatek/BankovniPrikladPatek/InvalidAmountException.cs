﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BankovniPrikladPatek
{
    public class InvalidAmountException : BankingException
    {
        public InvalidAmountException()
        {
        }

        public InvalidAmountException(string message) : base(message)
        {
        }

        public InvalidAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidAmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
