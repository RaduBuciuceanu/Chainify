namespace Chainify.Old.Transactions.Generic.Builders
{
    public static class InputTransaction
    {
        public static InputTransaction<TInput> Create<TInput>()
        {
            return new InputTransaction<TInput>();
        }
    }
}