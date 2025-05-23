using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        int wordsToHide = 3;
        List<Word> visibleWords = _words.FindAll(w => !w.IsHidden());

        if (visibleWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string verse = string.Join(" ", _words.ConvertAll(w => w.GetDisplayText()));
        return _reference.GetDisplayText() + " " + verse;
    }

    public bool AllWordsHidden()
    {
        return _words.TrueForAll(w => w.IsHidden());
    }
}
