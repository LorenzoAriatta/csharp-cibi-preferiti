// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] food = { "pizza", "tiramisù", "focaccia", "pasta", "pollo fritto" };

Console.WriteLine(food.Length);

for(int i = 0; i < food.Length; i++)
{
    Console.WriteLine((i+1) + " " + food[i]);
}
