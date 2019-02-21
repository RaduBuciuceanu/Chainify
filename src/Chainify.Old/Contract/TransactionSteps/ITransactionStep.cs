namespace Chainify.Old.Contract.TransactionSteps
{
    public interface ITransactionStep : ITransactionEntity, IBeforeExecution, IExecute, IAfterExecution, IRollback
    {
    }
}