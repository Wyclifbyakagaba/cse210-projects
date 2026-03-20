using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._response = parts[2];

            _entries.Add(entry);
        }
    }
}