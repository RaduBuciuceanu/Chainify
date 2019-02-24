namespace Chainify.Core.Generic
{
    public interface IGenericInputOutput : IChainable
    {
        TOutput Execute<TInput, TOutput>(TInput input);
    }
}
