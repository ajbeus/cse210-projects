public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        foreach (var word in text.Split(' '))
            _words.Add(new Word(word));
    }

    public string GetDisplayScripture()
    {
        return $"{_reference.GetDisplayContent()} {this}";
        
    }
    public void HideRandomWords(int count)
    {
        var visibleWords = _words.FindAll(w => !w.IsHidden);
        var random = new Random();
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            var word = visibleWords[random.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
        }
    }

    public bool AllHidden() => _words.TrueForAll(w => w.IsHidden);
    public override string ToString() => string.Join(" ", _words);
}