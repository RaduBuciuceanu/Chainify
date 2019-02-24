namespace Chainify.Core.Generic
{
    public interface IGenericVoid : IOperation
    {
        void Execute<TInput, TOutput>();
    }
}
