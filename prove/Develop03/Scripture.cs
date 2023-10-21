using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(List<string> verses, Reference reference)
    {
        foreach (string verse in verses)
        {
            string[] words = verse.Split(' ');
            foreach (string word in words)
            {
                _words.Add(new Word(word));
            }
        }
        _reference = reference;
    }

    public void HideNextWords(int count)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while (hiddenCount < count)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void Display()
    {
        Console.WriteLine(_reference.DisplayReference());
        foreach (Word word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }
}
