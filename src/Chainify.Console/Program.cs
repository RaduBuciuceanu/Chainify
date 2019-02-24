using System.Collections.Generic;
using Chainify.Core;
using Chainify.Core.Generic;
using Chainify.Synchronous;

namespace Chainify.Console
{
    public static class Program
    {
        private static readonly IVoid Void = new Void();
        private static readonly IGenericVoid GenericVoid = new GenericVoid();
        private static readonly IInput<object> Input = new Input();
        private static readonly IGenericInput GenericInput = new GenericInput();
        private static readonly IOutput<object> Output = new Output();
        private static readonly IGenericOutput GenericOutput = new GenericOutput();
        private static readonly IInputOutput<object, object> InputOutput = new InputOutput();
        private static readonly IGenericInputOutput GenericInputOutput = new GenericInputOutput();

        private static readonly IEnumerable<IChainable> All = new IChainable[]
        {
            Void,
            GenericVoid,
            Output,
            InputOutput
        };

        public static void Main(string[] args)
        {
            var chain = new Chain(All);
            object current = chain.Execute();
        }
    }

    public class Void : IVoid
    {
        public void Execute()
        {
            System.Console.WriteLine(nameof(Void));
        }
    }

    public class GenericVoid : IGenericVoid
    {
        public void Execute<TInput, TOutput>()
        {
            System.Console.WriteLine(nameof(GenericVoid));
        }
    }

    public class Input : IInput<object>
    {
        public void Execute(object input)
        {
            System.Console.WriteLine(nameof(Input));
        }
    }

    public class GenericInput : IGenericInput
    {
        public void Execute<TInput>(TInput input)
        {
            System.Console.WriteLine(nameof(GenericInput));
        }
    }

    public class Output : IOutput<object>
    {
        public object Execute()
        {
            System.Console.WriteLine(nameof(Output));
            return nameof(Output);
        }
    }

    public class GenericOutput : IGenericOutput
    {
        public TOutput Execute<TOutput>()
        {
            System.Console.WriteLine(nameof(GenericOutput));
            return (TOutput)(object)nameof(GenericOutput);
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
