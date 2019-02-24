using System;
using Chainify.Core;
using Chainify.Core.Generic;
using IGOutputOutput = Chainify.Synchronous.Generic.Void.GOutputOutput.IChain;
using IGInputInputGIoIo = Chainify.Synchronous.Generic.Void.GInputInputGIoIo.IChain;

namespace Chainify.Synchronous.Generic
{
    public class GenericVoidBuilder : Proxy, IGInputInputGIoIo, IGOutputOutput 
    {
        public Type OneInput { get; set; }
        
        public Type OneOutput { get; set; }
        
        public Type OtherInput { get; set; }

        public Type OtherOutput { get; set; }

        public IGInputInputGIoIo Chain(IGenericOutput other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain(IGenericInputOutput other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return this;
        }
        
        public IGOutputOutput Chain(IGenericVoid other)
        {
            return this;
        }

        public IGOutputOutput Chain(IVoid other)
        {
            return this;
        }
        
        public IGOutputOutput Chain(IGenericInput other)
        {
            return this;
        }

        public IGOutputOutput Chain<TOtherInput>(IInput<TOtherInput> other)
        {
            return this;
        }
        
        public void Execute<TExecuteInput, TExecuteOutput>()
        {
            object oneResult = Engine.WithInstance(One).Execute();
            Engine.WithInput(oneResult).WithInstance(Other).Execute();
        }
    }
}
