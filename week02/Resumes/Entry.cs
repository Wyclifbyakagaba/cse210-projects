using System;

namespace JournalApp
{
    class Entry
    {
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Text { get; set; }

        public Entry(string prompt, string text)
        {
            Date = DateTime.Now;
            Prompt = prompt;
            Text = text;
        }

        public string Display()
        {
            return $"{Date.ToShortDateString()} - {Prompt}\n{Text}\n";
        }
    }
}