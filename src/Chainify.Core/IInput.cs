namespace Chainify.Core
{
    public interface IInput<in TInput> : IOperation
    {
        void Execute(TInput input);
    }
}
