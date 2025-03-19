using System;
using System.Diagnostics.Tracing;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string today = DateTime.Now.ToString("MM/dd/yyyy");

        string prompt = new PromptGenerator();
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
                    _entries.Add(new Entry{_date = date, _promptText = promptText, _inputText = inputText});
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