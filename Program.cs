// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// create array
string[] food = { "pizza", "tiramisù", "fried chicken", "pasta", "meringa", "focaccia" }; 


//array length
Console.WriteLine($"How many foods are: {food.Length}");


//set user choice
Console.WriteLine("Type your favourite food: ");
string userFood = Console.ReadLine();

//RNG pc choice
int randomNumber = new Random().Next(0, food.Length);
//Console.WriteLine(randomNumber);


while (!Array.Exists(food, element => element == userFood))
    {
        Console.WriteLine("Type your favourite food: ");
        userFood = Console.ReadLine();
    }
for (int i = 0; i < food.Length; i++)
{
    
    if (userFood == food[i] && randomNumber == i)
    {
        Console.WriteLine($"Pos N: {(i + 1)} {food[i]} --> We have the same tastes!");
    }
    else if (randomNumber == i)
    {
        Console.WriteLine($"Pos N: {(i + 1)} {food[i]} --> Computer taste!");
    }
    else if ((userFood == food[i]))
    {
        Console.WriteLine($"Pos N: {(i + 1)} {food[i]} --> User taste!"); ;
    }
    else
    {
        Console.WriteLine($"Pos N: {(i + 1)} {food[i]}");
    }    
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

