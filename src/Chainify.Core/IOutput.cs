namespace Chainify.Core
{
    public interface IOutput<out TOutput> : IOperation
    {
        TOutput Execute();
    }
}
