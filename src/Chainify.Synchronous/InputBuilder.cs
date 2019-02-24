using System;
using System.Collections.Generic;
using System.Linq;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Generic;
using Chainify.Synchronous.Input;

namespace Chainify.Synchronous
{
    public class InputBuilder<TInput> : Proxy, IOutputGOutput<TInput>, IInputGInputIoGIo<TInput>
    {
        public Type OneInput { get; set; }

        public Type OneOutput { get; set; }

        public IOutputGOutput<TInput> Chain(IVoid other)
        {
            return this;
        }

        public IOutputGOutput<TInput> Chain(IGenericVoid other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput> Chain<TOtherOutput>(IOutput<TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput> Chain(IGenericOutput other)
        {
            return this;
        }

        public IOutputGOutput<TInput> Chain<TOtherInput>(IInput<TOtherInput> other)
        {
            return this;
        }

        public IOutputGOutput<TInput> Chain(IGenericInput other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput> Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo<TInput> Chain(IGenericInputOutput other)
        {
            return this;
        }
        
        public void Execute(TInput input)
        {
            object oneResult = Engine.WithInput(input).WithInstance(One).Execute();
            Engine.WithInput(oneResult).WithInstance(Other).Execute();
        }
    }
}
