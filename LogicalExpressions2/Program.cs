Console.WriteLine("please enter your number 1,2,3,4,5,6,7:");
int nameOfday = int.Parse(Console.ReadLine());
string input = string.Empty; //""

if (nameOfday <= 7 && nameOfday > 0)
{
    if (nameOfday == 1)
    {
        input = "Sunday";
    }
    else if (nameOfday == 2)
    {
        input = "Monday";
    }
    else if (nameOfday == 3)
    {
        input = "Thesday";
    }
    else if (nameOfday == 4)
    {
        input = "Wednesday";
    }
    else if (nameOfday == 5)
    {
        input = "Thursday";
    }
    else if (nameOfday == 6)
    {
        input = "Friday";
    }
    else if (nameOfday == 7)
    {
        input = "Saturday";
    }
    Console.WriteLine("your selected day is:" + input);
}
else
{
    Console.WriteLine("You did not provide a valid week day number");
}

Console.WriteLine(nameOfday);
