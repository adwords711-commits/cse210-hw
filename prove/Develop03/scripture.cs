using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>();
        
        _reference = reference;
        string[] wordsArray = text.Split(' ');
        foreach (string w in wordsArray)
        {
            Word wordObj = new Word(w);
            _words.Add(wordObj);
        } 
        
    }
    public void HideRandomWords()
    {
        Random r = new Random();
        for (int i = 0; i < 3; i++ )
        {
        int index = r.Next(0, _words.Count);
        Word selectWord = _words[index];
        selectWord.Hide();
        }
    }
    public string GetText()
    {
        string scriptureText = "";
        foreach (Word w in _words)
        {
            scriptureText += w.GetText() + " ";         
        }
        return scriptureText;
    }
    public bool AllWordsHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.isHidden())
            return false;    
        }
        return true;
    }

}