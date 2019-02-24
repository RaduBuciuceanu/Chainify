namespace Chainify.Old.Transactions.Generic.Builders
{
    public static class OutputTransaction
    {
        public static OutputTransaction<TOutput> Create<TOutput>()
        {
            return new OutputTransaction<TOutput>();
        }
    }
}