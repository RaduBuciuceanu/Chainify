using System;
using System.Linq;
using System.Reflection;

namespace Chainify.Synchronous
{
    public abstract class Proxy
    {
        protected Engine Engine { get; }
        
        protected object One { get; set; }
        
        protected object Other { get; set; }

        protected Proxy()
        {
            Engine = new Engine();
        }

        protected object ExecuteOnce(object command, object input = null)
        {
            object current = input;
            MethodInfo method = command.GetType().GetMethod("Execute");

            var actions = new Action[]
            {
                () =>
                {
                    var genericMethod = method.MakeGenericMethod(current.GetType());
                    current = genericMethod.Invoke(command, new[] { current });
                },
                () =>
                {
                    var genericMethod = method.MakeGenericMethod(current.GetType());
                    current = genericMethod.Invoke(command, new object[] { });
                },
                () =>
                {
                    var genericMethod = method.MakeGenericMethod(current.GetType());
                    genericMethod.Invoke(command, new object[] { });
                },
                () => current = method.Invoke(command, new[] { current }),
                () => current = method.Invoke(command, new object[] { }),
                () => method.Invoke(command, new[] { current }),
                () => method.Invoke(command, new object[] { }),
            };

            actions.Any(Safe);

            return current;
        }
        
        private static bool Safe(Action predicate)
        {
            try
            {
                predicate();
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }
    }
}
