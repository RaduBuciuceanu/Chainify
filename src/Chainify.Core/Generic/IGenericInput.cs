namespace Chainify.Core.Generic
{
    public interface IGenericInput : IOperation
    {
        void Execute<TInput>(TInput input);
    }
}
