namespace Chainify.Core
{
    public interface IInput<in TInput> : IChainable
    {
        void Execute(TInput input);
    }
}
