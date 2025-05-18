using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;



public class Journal{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }

    }

    public void SaveToFile(string _filename)
{
    try
    {
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"Date: {entry._date}");
                writer.WriteLine($"Prompt: {entry.__promptText}");
                writer.WriteLine($"Entry Text: {entry._entryText}");
                writer.WriteLine(); // Add blank line between entries
            }
        }
        Console.WriteLine($"Journal saved to {_filename}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving journal: {ex.Message}");
    }
}



    public void LoadFromFile(string _filename)
    {
        
        try
        {
            using (StreamReader reader = new StreamReader(_filename))
            {
                _entries.Clear();
                Entry currentEntry = null;
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    if (line.StartsWith("Date: "))
                    {
                        currentEntry = new Entry();
                        currentEntry._date = line.Substring("Date: ".Length);
                    }
                    else if (line.StartsWith("Prompt: "))
                    {
                        currentEntry.__promptText = line.Substring("Prompt: ".Length);
                    }

                    else if (line.StartsWith("Entry Text: "))
                        {
                            currentEntry._entryText = line.Substring("Entry Text: ".Length);
                            _entries.Add(currentEntry);
                        }
                    }
                }
                Console.WriteLine("Journal Loaded Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }


        }

    }
