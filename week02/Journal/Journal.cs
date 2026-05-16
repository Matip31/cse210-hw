using System.IO;
public class Journal
{
    public List<Entry> _entries=new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach(Entry ent in _entries)
        {
            ent.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using(StreamWriter outputFile=new StreamWriter(filename))
        {
            foreach(Entry ent in _entries)
            {
                outputFile.WriteLine($"{ent._date}*{ent._promptText}*{ent._entryText}");
            }
        }
    }
    public void LoadFile(string filename)
    {
        string[] lines=System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {
            string[] parts=line.Split('*');
            Entry ent =new Entry();

            ent._date= parts[0];
            ent._promptText= parts[1];
            ent._entryText= parts[2];
            _entries.Add(ent);
        }
    }
}