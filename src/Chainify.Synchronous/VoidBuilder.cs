using System;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous.Void;

namespace Chainify.Synchronous
{
    public class VoidBuilder : Proxy, IInputGInputIoGIo, IOutputGOutput
    {
        public Type OneInput { get; set; }

        public Type OneOutput { get; set; }

        public IInputGInputIoGIo Chain<TOtherOutput>(IOutput<TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo Chain(IGenericOutput other)
        {
            return this;
        }
        
        public void Execute()
        {
            object oneResult = Engine.WithInstance(One).Execute();
            Engine.WithInput(oneResult).WithInstance(Other).Execute();
        }

        public IOutputGOutput Chain(IVoid other)
        {
            return this;
        }

        public IOutputGOutput Chain(IGenericVoid other)
        {
            return this;
        }

        public IOutputGOutput Chain<TOtherInput>(IInput<TOtherInput> other)
        {
            return this;
        }

        public IOutputGOutput Chain(IGenericInput other)
        {
            return this;
        }

        public IInputGInputIoGIo Chain<TOtherInput, TOtherOutput>(IInputOutput<TOtherInput, TOtherOutput> other)
        {
            return this;
        }

        public IInputGInputIoGIo Chain(IGenericInputOutput other)
        {
            return this;
        }
    }
}
