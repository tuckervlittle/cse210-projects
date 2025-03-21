using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    public void DisplayAllEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries.");
            return;
        }
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date}~{entry._promptText}~{entry._inputText}");
            }
        }
        Console.WriteLine($"Journal saved to {file}.txt.");
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            using (StreamReader reader = new StreamReader(file))
            {
                _entries.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("~");
                    string date = parts[0];
                    string promptText = parts[1];
                    string inputText = parts[2];
                    _entries.Add(new Entry(date, promptText, inputText));
                }
            }
            Console.WriteLine($"Journal loaded from {file}.txt.");
        }
        else
        {
            Console.WriteLine($"{file}.txt not found.");
        }
    }

}