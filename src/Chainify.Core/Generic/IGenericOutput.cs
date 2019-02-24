namespace Chainify.Core.Generic
{
    public interface IGenericOutput
    {
        TOutput Execute<TOutput>();
    }
}
