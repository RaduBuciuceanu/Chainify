namespace Chainify.Core
{
    public interface IOutput<out TOutput> : IChainable
    {
        TOutput Execute();
    }
}
