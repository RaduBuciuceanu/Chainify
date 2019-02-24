namespace Chainify.Core.Generic
{
    public interface IGenericOutput : IChainable
    {
        TOutput Execute<TOutput>();
    }
}
