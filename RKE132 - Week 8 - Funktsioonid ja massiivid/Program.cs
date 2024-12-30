string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo" };
string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };
string[] weapon = { "magic wand", "plastic fork", "banana", "wooden sword", "Lego brick" };


string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} saves the day!");

string villain = GetRandomValueFromArray(villains); 
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} tries to take over the world!");


static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randmomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randmomIndex];
    return randomStringFromArray;
}

