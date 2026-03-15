using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{do
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries available.\n");
            return;
        }

        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry e in _entries)
                {
                    writer.WriteLine($"{e._date}{Separator}{e._promptText}{Separator}{e._entryText}");
                }
            }
            Console.WriteLine($"Saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error while saving file.");
            Console.WriteLine(ex.Message);
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            _entries.Clear();

            foreach (string line in lines)
            {
                string[] parts = line.Split(Separator);
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        _date = parts[0],
                        _promptText = parts[1],
                        _entryText = parts[2]
                    };
                    _entries.Add(entry);
                }
            }
            Console.WriteLine("Loaded journal entries.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading file.");
            Console.WriteLine(ex.Message);
        }
    }
}