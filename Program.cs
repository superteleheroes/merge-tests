Console.WriteLine("What's your name");
string name = Console.ReadLine();
DateTime now = DateTime.Now;
string day = now.DayOfWeek;
string time = now.ToString("HH:mm");
Console.WriteLine($"Hello {name}. It's {day} and hour {time}");