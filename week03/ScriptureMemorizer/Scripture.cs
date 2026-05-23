using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words= new List<Word>();

    public Scripture(Reference reference,string text)
    {
        _reference=reference;
        string[] parts=text.Split(" ");
        foreach(string part in parts)
        {
            Word word=new Word(part);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int number)
    {
        Random random=new Random();
        int hiddenCount=0;
        while(hiddenCount<number)
        {
            int index=random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
            _words[index].Hide();
            hiddenCount++;
            }
        }
    }
    public string GetDisplayText()
    {
        string textToDisplay=_reference.GetDisplayText()+" ";
        foreach(Word w in _words)
        {
            textToDisplay= textToDisplay+w.GetDisplayText()+" ";
        }
        return textToDisplay;
    }
    public bool IsCompletelyHidden()
    {
        bool hidden=true;
        foreach(Word w in _words)
        {
            if (w.IsHidden()==false)
            {
                hidden=false;
            }
        }
        return hidden;
    }
    
}