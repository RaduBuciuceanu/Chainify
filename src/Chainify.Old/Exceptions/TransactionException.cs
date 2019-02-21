using System;

namespace Chainify.Old.Exceptions
{
    public class TransactionException : Exception
    {
        public TransactionException()
        {
        }

        protected TransactionException(string message) : base(message)
        {
        }
    }
}