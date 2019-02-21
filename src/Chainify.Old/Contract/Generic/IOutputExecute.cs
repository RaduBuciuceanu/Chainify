namespace Chainify.Old.Contract.Generic
{
    public interface IOutputExecute<out TOutput> : IOutputExecute
    {
        new TOutput Execute();
    }
}