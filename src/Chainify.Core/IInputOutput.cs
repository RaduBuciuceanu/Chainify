namespace Chainify.Core
{
    public interface IInputOutput<in TInput, out TOutput>
    {
        TOutput Execute(TInput input);
    }
}
