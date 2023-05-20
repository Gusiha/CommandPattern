using CommandPattern;
using System.Data;

Invoker invoker = new();
Reciever reciever = new();

Client client = new();

client.PrintData();
client.UpdateCost(invoker, reciever, "Boots", 200);
client.PrintData();
client.UpdateCost(invoker, reciever, "Boots", 5000);
client.PrintData();
client.Undo(reciever);
client.Undo(reciever);
client.Redo(reciever);

client.ChangeName(invoker, reciever, "Boots", "NewBoots");
client.Redo(reciever);

client.PrintData();

