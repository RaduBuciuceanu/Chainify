using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous;
using Chainify.Synchronous.Generic.Input.GOutputOutput;
using Chainify.Synchronous.Linq;
using Chainify.Synchronous.Linq.Generic;

namespace Chainify.Console
{
    public static class Program
    {
        private static IVoid @void = new Void();
        private static IGenericVoid genericVoid = new GenericVoid();
        private static IInput<object> input = new Input();
        private static IGenericInput genericInput = new GenericInput();
        private static IOutput<object> output = new Output();
        private static IGenericOutput genericOutput = new GenericOutput();
        private static IInputOutput<object, object> inputOutput = new InputOutput();
        private static IGenericInputOutput genericInputOutput = new GenericInputOutput();
        
        public static void Main(string[] args)
        {
        }
    }

    public class Void : IVoid
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericVoid : IGenericVoid
    {
        public void Execute<TInput, TOutput>()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Input : IInput<object>
    {
        public void Execute(object input)
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericInput : IGenericInput
    {
        public void Execute<TInput>(TInput input)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Output : IOutput<object>
    {
        public object Execute()
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericOutput : IGenericOutput
    {
        public TOutput Execute<TOutput>()
        {
            throw new System.NotImplementedException();
        }
    }

    public class InputOutput : IInputOutput<object, object>
    {
        public object Execute(object input)
        {
            throw new System.NotImplementedException();
        }
    }

    public class GenericInputOutput : IGenericInputOutput
    {
        public TOutput Execute<TInput, TOutput>(TInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}
