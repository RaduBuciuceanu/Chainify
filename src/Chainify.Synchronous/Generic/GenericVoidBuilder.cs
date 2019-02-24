using System;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic.Void;

namespace Chainify.Synchronous.Generic
{
    public class GenericVoidBuilder : Proxy, IGOutputOutput, IGInputInputGIoIo
    {
        public Type OneInput { get; set; }
        
        public Type OneOutput { get; set; }
        
        public Type OtherInput { get; set; }

        public Type OtherOutput { get; set; }

        public void Execute<TExecuteInput, TExecuteOutput>()
        {
            object oneResult = Engine.WithInstance(One).Execute();
            Engine.WithInput(oneResult).WithInstance(Other).Execute();
        }

        public IGOutputOutput Chain(IGenericVoid other)
        {
            return this;
        }

        public IGOutputOutput Chain(IVoid other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain(IGenericOutput other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain<TOtherOutput>(IOutput<TOtherOutput> other)
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

        public IGInputInputGIoIo Chain(IGenericInputOutput other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return this;
        }
    }
}
