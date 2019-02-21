namespace Chainify.Old.Transactions.Grammar.Transaction
{
    public abstract class ContinueBase
    {
        protected readonly Transactions.Transaction Transaction;

        protected ContinueBase(Transactions.Transaction transaction)
        {
            Transaction = transaction;
        }
    }
}