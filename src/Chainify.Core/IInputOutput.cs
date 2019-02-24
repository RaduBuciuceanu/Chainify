namespace Chainify.Core
{
    public interface IInputOutput<in TInput, out TOutput> : IChainable
    {
        TOutput Execute(TInput input);
    }
}
