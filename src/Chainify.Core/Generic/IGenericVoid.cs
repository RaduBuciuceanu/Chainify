namespace Chainify.Core.Generic
{
    public interface IGenericVoid : IChainable
    {
        void Execute<TInput, TOutput>();
    }
}
