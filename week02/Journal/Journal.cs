using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entryList;

    public Journal()
    {
        _entryList = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void ShowJournal()
    {
        if (_entryList.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
            return;
        }

        foreach (Entry e in _entryList)
        {
            e.Display();
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Entry e in _entryList)
            {
                writer.WriteLine($"{e.Date}~|~{e.Prompt}~|~{e.Text}~|~{e.Mood}");
            }
        }
    }
    public void Load(string fileName)
    {
        _entryList.Clear();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            string[] parts = line.Split("~|~");

            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2], "");
                _entryList.Add(entry);
            }

            else if (parts.Length == 4)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2], parts[3]);
                _entryList.Add(entry);
            }
        }
    }
}