namespace Chainify.Core.Generic
{
    public interface IGenericInput
    {
        void Execute<TInput>(TInput input);
    }
}
