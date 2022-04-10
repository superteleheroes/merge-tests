Console.WriteLine("What's your name");
string name = Console.ReadLine();
DateTime now = DateTime.Now;
string day = now.DayOfWeek;
Console.WriteLine($"Hello {name}. It's {day}");