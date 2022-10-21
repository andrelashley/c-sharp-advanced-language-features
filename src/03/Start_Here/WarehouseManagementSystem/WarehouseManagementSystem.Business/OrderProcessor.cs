using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
    public class OrderProcessor
    {
        public delegate void OrderInitialized();
        public delegate void ProcessCompleted();

        public OrderInitialized OnOrderInitialized { get; set; }

        private void Initialize(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            OnOrderInitialized?.Invoke();
        }

        public void Process(Order order, ProcessCompleted onComplete = default)
        {
            // Run some code..

            Initialize(order);

            // How do I produce a shipping label?
            onComplete?.Invoke();
        }
    }
}