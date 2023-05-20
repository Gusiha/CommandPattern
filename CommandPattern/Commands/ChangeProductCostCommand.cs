namespace CommandPattern
{
    internal class ChangeProductCostCommand : AbstractCommand
    {
        public int ActualValue { get; set; }
        public int PrevValue { get; set; }

        public ProductClass Product { get; set; }

        public override void Execute()
        {
            Product.Value = ActualValue;
            _reciever.ExecuteCommand(this);
        }

        public override void Undo()
        {
            Product.Value = PrevValue;
        }

        public override void Redo()
        {
            Product.Value = ActualValue;
        }

        public ChangeProductCostCommand(Invoker invoker, Reciever reciever, ProductClass product, int newValue) 
            : base(invoker, reciever)
        {
            Product = product;
            ActualValue = newValue;
            PrevValue = product.Value;
        }

    }
}
