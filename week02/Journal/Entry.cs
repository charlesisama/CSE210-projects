public class Entry
{
    public static DateTime currentTime = DateTime.Now;
    
    public string _date = currentTime.ToShortDateString();

    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date}:   {_promptText}");
        Console.WriteLine(_entryText);
    }
}