namespace CommandPattern.Commands
{
    internal class ChangeProductNameCommand : AbstractCommand
    {
        public string ActualName { get; set; }
        public string PrevName { get; set; }

        public ProductClass Product { get; set; }

        //public string Execute()
        //{
        //    Product.Name = ActualName;
        //    return $"New Value is {ActualName}$";
        //}

        //public void Undo()
        //{
        //    Product.Name = PrevName;
        //}

        public override void Execute()
        {
            PrevName= ActualName;
            _reciever.ExecuteCommand(this);
        }

        public override void Undo()
        {
            Product.Name = PrevName;
        }

        public override void Redo()
        {
            Product.Name = ActualName;
        }

        public ChangeProductNameCommand(Invoker invoker, Reciever reciever, ProductClass product, string newValue) : base(invoker, reciever)
        {
            Product = product;
            ActualName = newValue;
            PrevName = product.Name;
        }
    }
}
