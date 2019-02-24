namespace Chainify.Core.Generic
{
    public interface IGenericInputOutput : IOperation
    {
        TOutput Execute<TInput, TOutput>(TInput input);
    }
}
