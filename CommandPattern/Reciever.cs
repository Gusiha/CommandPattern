using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class Reciever
    {
        private Stack<AbstractCommand> undoHistory;
        private Stack<AbstractCommand> redoHistory;


        public Reciever()
        {
            undoHistory = new Stack<AbstractCommand>();
            redoHistory= new Stack<AbstractCommand>();
        }

        public void ExecuteCommand(AbstractCommand command)
        {
            if (redoHistory.Any())
                redoHistory.Clear();
            undoHistory.Push(command);
        }
        
        public void Undo()
        {
            AbstractCommand command = undoHistory.Pop();
            command.Undo();
            redoHistory.Push(command);
        }

        public void Redo()
        {
            AbstractCommand command = redoHistory.Pop();
            command.Redo();
            undoHistory.Push(command);
        }
    }
}
