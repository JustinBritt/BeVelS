namespace BeVelS.Common.Threading.Windows.Extensions.Tasks
{
    using System.Threading.Tasks;
    using System.Windows.Threading;

    public static class TaskExtensions
    {
        public static DispatcherOperation<Task> DispatcherInvokeAsync(
            this Task task,
            Dispatcher dispatcher)
        {
            return dispatcher.InvokeAsync(
                async () => await task);
        }
    }
}