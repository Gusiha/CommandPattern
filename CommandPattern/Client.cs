using CommandPattern.Commands;

namespace CommandPattern
{
    internal class Client
    {
        public List<ProductClass> Products { get; set; }

        public void UpdateCost(Invoker invoker, Reciever reciever, string name, int newValue)
        {
            ProductClass product;
            product = Products.Find(x => x.Name == name);
            AbstractCommand command = new ChangeProductCostCommand(invoker, reciever, product, newValue);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }

        public void ChangeName(Invoker invoker, Reciever reciever, string name, string newName)
        {
            ProductClass product;
            product = Products.Find(x => x.Name == name);
            AbstractCommand command = new ChangeProductNameCommand(invoker, reciever, product, newName);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }

        public void Undo(Reciever reciever)
        {
            reciever.Undo();
        }

        public void Redo(Reciever reciever)
        {
            reciever.Redo();
        }

        public void PrintData()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"{item.Name} : {item.Value}\n");
            }
        }

        public Client()
        {
            Products = new List<ProductClass>() { new ProductClass(400, "Jacket"), new ProductClass(300, "Boots"), new ProductClass(50, "Socks") };
        }

    }
}
