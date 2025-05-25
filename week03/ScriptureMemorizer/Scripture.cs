
using System.Reflection.Metadata.Ecma335;

/// <summary>
/// Represents a scripture with a reference and a collection of words.
/// </summary>
public class Scripture
{
    Reference _reference;
    List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        // Split the text into words and create Word objects for each
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    
 public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList(); // Use IsHidden method
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide(); // Call the Hide method
            visibleWords.Remove(wordToHide);
        }
    }


    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(Word => Word.GetDisplayText()));
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}

