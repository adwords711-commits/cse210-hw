public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry e)
    {
        _entries.Add(e);
    }
    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Dissplay();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter OutputFile = new StreamWriter(filename))
            foreach (Entry e in _entries)
            {
                string line = e._date + " | " + e._prompt + " | " + e._response;
                OutputFile.WriteLine(line);
        }
    }
    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(" | ");
            Entry e = new Entry(parts[0], parts[1], parts[2]);
            _entries.Add(e);
        }
    }
    
}