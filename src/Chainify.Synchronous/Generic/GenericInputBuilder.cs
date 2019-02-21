using System;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic.Input;

namespace Chainify.Synchronous.Generic
{
    public class GenericInputBuilder : Proxy, IGInputInputGIoIo, IGOutputOutput
    {
        public Type OneInput { get; set; }

        public Type OneOutput { get; set; }

        public Type OtherInput { get; set; }
        
        public Type OtherOutput { get; set; }

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
        
        public void Execute<TInput>(TInput input)
        {
            object oneResult = Engine.WithInput(input).WithInstance(One).Execute();
            Engine.WithInput(oneResult).WithInstance(Other).Execute();
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
