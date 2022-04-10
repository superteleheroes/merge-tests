int GetTemperature(){
    return 12;
}

Console.WriteLine("What's your name");
string name = Console.ReadLine();
Console.WriteLine("Where's you live?");
string city = Console.ReadLine();
DateTime now = DateTime.Now;
string day = now.DayOfWeek;
string time = now.ToString("HH:mm");
string temperature = GetTemperature();
Console.WriteLine($"Hello {name}. It's {day} and hour {time}.\n Temperature outside in {city} is {temperature}");