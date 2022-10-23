using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
    public class OrderProcessor
    {
        // public delegate bool OrderInitialized(Order order);
        // public delegate void ProcessCompleted(Order order);

        public Func<Order, bool> OnOrderInitialized { get; set; }

        private void Initialize(Order order)
        {
            ArgumentNullException.ThrowIfNull(order);

            if(OnOrderInitialized?.Invoke(order) == false)
            {
                throw new Exception($"Couldn't initialize order {order.OrderNumber}");
            }
        }

        public void Process(Order order, Action<Order> onComplete = default)
        {
            // Run some code..

            Initialize(order);

            // How do I produce a shipping label?
            onComplete?.Invoke(order);
        }
    }
}