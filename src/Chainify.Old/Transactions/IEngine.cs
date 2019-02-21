namespace Chainify.Old.Transactions
{
    public interface IEngine
    {
        object Current { get; set; }
        void Execute();
    }
}