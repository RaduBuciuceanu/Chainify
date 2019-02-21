namespace Chainify.Old.Exceptions
{
    public class WrongSuccessionException : TransactionException
    {
        public WrongSuccessionException()
        {
        }

        public WrongSuccessionException(string message) : base(message)
        {
        }
    }
}