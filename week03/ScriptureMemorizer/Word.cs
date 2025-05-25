public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;

    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        // the ? adds a conditional statement [if condition do this, else do this]
        // _isHidden is the condition, and the colin separates the results of true and false
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}