namespace Chainify.Core.Generic
{
    public interface IGenericOutput : IOperation
    {
        TOutput Execute<TOutput>();
    }
}
