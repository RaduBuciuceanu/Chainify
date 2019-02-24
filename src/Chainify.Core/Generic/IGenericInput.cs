namespace Chainify.Core.Generic
{
    public interface IGenericInput : IChainable
    {
        void Execute<TInput>(TInput input);
    }
}
