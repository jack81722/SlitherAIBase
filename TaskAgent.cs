using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TaskAgent
    {
        private event Action CallbackPool;
        private Task _Main;

        public void RegisteredToNetworkTask(Action action)
        {
            CallbackPool += action;
            if (_Main != null) return;
            
            _Main = Task.Run(Function);
            async Task Function()
            {
                while (true)
                {
                    CallbackPool?.Invoke();
                    await Task.Delay(5);
                }
            }
        }

        public void UnRegisteredToNetworkTask(Action action)
        {
            CallbackPool -= action;
        }
    }
}