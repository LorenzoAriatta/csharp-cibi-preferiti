// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// create array
string[] food = { "pizza", "tiramisù", "fried chicken", "pasta", "meringa", "focaccia" }; 

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

//middle foods
if (food.Length % 2 == 0)
{
    Console.WriteLine($"Middle zone: {food[food.Length / 2 - 1]}, {food[food.Length / 2]}");

} else
{
    Console.WriteLine($"Middle zone: {food[food.Length / 2]}");
}

