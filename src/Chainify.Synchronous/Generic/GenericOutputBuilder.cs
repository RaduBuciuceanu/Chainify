using System;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic.Output;

namespace Chainify.Synchronous.Generic
{
    public class GenericOutputBuilder : Proxy, IGInputInputGIoIo, IGOutputOutput
    {
        public Type OneInput { get; set; }

        public Type OtherOutput { get; set; }

        public TOutput Execute<TOutput>()
        {
            object oneResult = Engine.WithInstance(One).Execute();
            object otherResult = Engine.WithInput(oneResult).WithInstance(Other).Execute();
            return (TOutput)otherResult;
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

        public IGInputInputGIoIo Chain(IGenericInputOutput other)
        {
            return this;
        }

        public IGInputInputGIoIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
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
    }
}
