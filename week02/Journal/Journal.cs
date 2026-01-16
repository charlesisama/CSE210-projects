public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    
    //Method to add new entry to a list of entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll ()
    {
        foreach(Entry en in _entries)
        {
            Console.WriteLine(en);
        }
    }

    public void SaveToFile (string filename)
    {
        using(StreamWriter outPutFile = new StreamWriter(filename))
        {
            outPutFile.WriteLine(_entries);
        }
    }

    public void LoadFromFile (string filename)
    {
        string [] lines = System.IO.File.ReadAllLines(filename);
    }
}