namespace Chainify.Core.Generic
{
    public interface IGenericInputOutput
    {
        TOutput Execute<TInput, TOutput>(TInput input);
    }
}
