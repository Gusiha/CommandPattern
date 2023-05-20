using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal abstract class AbstractCommand
    {
        protected Invoker _invoker;
        protected Reciever _reciever;

        public abstract void Execute();

        public abstract void Undo();
        public abstract void Redo();


        public AbstractCommand(Invoker invoker, Reciever reciever)
        {
            _invoker = invoker;
            _reciever = reciever;

        }

    }
}
