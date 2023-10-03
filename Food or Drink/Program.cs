string pr = Console.ReadLine();

if (pr == "curry" || pr == "noodels" || pr == "sushi" || pr == "spagetti" || pr == "bread")
{
    Console.WriteLine("Food");
}
else if (pr == "tea" || pr == "water" || pr == "coffe" || pr == "juice")
{
    Console.WriteLine("Drink");
}
else
    Console.WriteLine("unknown");