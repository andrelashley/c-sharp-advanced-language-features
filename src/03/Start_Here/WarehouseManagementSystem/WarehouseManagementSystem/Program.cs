using WarehouseManagementSystem.Business;
using WarehouseManagementSystem.Domain;

var order = new Order
{
    LineItems = new[] {
        new Item { Name = "PS2", Price = 50 },
        new Item { Name = "PS4", Price = 60 },
        new Item { Name = "PS5", Price = 70 },
        new Item { Name = "PS6", Price = 80 },
        }
};

var processor = new OrderProcessor
{
    OnOrderInitialized = SendMessageToWarehouse
};

processor.Process(order, SendConfirmationEmail);

void SendMessageToWarehouse()
{
    Console.WriteLine("Please pack the order");
}

void SendConfirmationEmail()
{
    Console.WriteLine("Order confirmation Email");
}