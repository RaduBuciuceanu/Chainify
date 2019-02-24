namespace Chainify.Core
{
    public interface IInput<in TInput>
    {
        void Execute(TInput input);
    }
}
