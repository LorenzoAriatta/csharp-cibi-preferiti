// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// create array
string[] food = { "pizza", "tiramisù", "fried chicken", "pasta", "focaccia" }; 

//array length
Console.WriteLine($"How many foods are: {food.Length}");

for (int i = 0; i < food.Length; i++)
{
    Console.WriteLine("Pos N: " + (i+1) + " " + food[i]);

}

//my favorite food
Console.WriteLine($"My favourite food: {food[0]}");

//my favourite but not too much
Console.WriteLine($"My favourite, but not too much: {(food[food.Length - 1])}");