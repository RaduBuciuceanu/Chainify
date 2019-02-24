namespace Chainify.Core
{
    public interface IInputOutput<in TInput, out TOutput> : IOperation
    {
        TOutput Execute(TInput input);
    }
}
