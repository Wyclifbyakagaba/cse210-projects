using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        // Add an entry to the journal
        public void AddEntry(Entry newEntry)
        {
            if (newEntry != null)
                _entries.Add(newEntry);
        }

        // Display all entries
        public void DisplayAll()
        {
            foreach (Entry e in _entries)
            {
                Console.WriteLine(e.Display());
            }
        }

        // Save journal to file
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry e in _entries)
                {
                    writer.WriteLine($"{e.Date}|{e.Prompt}|{e.Text}");
                }
            }
        }

        // Load journal from file
        public void LoadFromFile(string filename)
        {
            if (!File.Exists(filename))
                return;

            _entries.Clear();
            foreach (string line in File.ReadAllLines(filename))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string text = parts[2];

                    Entry e = new Entry(prompt, text);
                    e.Date = date;
                    _entries.Add(e);
                }
            }
        }

        // Random prompt generator
        public string GetRandomPrompt()
        {
            string[] prompts = new string[]
            {
                "What made you happy today?",
                "What did you learn today?",
                "Who did you appreciate today?",
                "What challenge did you face?"
            };

            Random rnd = new Random();
            return prompts[rnd.Next(prompts.Length)];
        }
    }
}