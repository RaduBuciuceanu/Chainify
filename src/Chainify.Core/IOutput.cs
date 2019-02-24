namespace Chainify.Core
{
    public interface IOutput<out TOutput>
    {
        TOutput Execute();
    }
}
