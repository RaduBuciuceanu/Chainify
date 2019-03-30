using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Chainify.Core;

namespace Chainify.Synchronous
{
    internal class OperationExecutor
    {
        private object _instance;
        private object _current;

        public OperationExecutor WithInstance(object instance)
        {
            _instance = instance;
            return this;
        }

        public OperationExecutor WithInput(object input)
        {
            _current = input;
            return this;
        }

        public object Execute()
        {
            MethodInfo method = _instance.GetType().GetMethod(Constants.MethodName);
            IEnumerable<Action> actions = BuildActions(method);
            actions.Any(Safe);

            return _current;
        }

        private Action[] BuildActions(MethodInfo method)
        {
            return new Action[]
            {
                () =>
                {
                    var genericMethod = method.MakeGenericMethod(_current.GetType());
                    _current = genericMethod.Invoke(_instance, new[] { _current });
                },
                () =>
                {
                    var genericMethod = method.MakeGenericMethod(_current.GetType());
                    _current = genericMethod.Invoke(_instance, new object[] { });
                },
                () =>
                {
                    var genericMethod = method.MakeGenericMethod(_current.GetType());
                    genericMethod.Invoke(_instance, new object[] { });
                },
                () => _current = method.Invoke(_instance, new[] { _current }),
                () => _current = method.Invoke(_instance, new object[] { }),
                () => method.Invoke(_instance, new[] { _current }),
                () => method.Invoke(_instance, new object[] { }),
            };
        }

        private static bool Safe(Action predicate)
        {
            try
            {
                predicate();
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
    }
}
