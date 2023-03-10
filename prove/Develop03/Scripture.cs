using System;
// Scripture:
// John 4:14 - But whosoever drinketh of the water that I shall give him shall never thirst
// but the water that I shall give him shall be in him a well of water 
// springing up into everlasting life 
class Scripture 
{
    private List<Verse> _verses = new List<Verse>();
    private bool _hidden = false;
    public Scripture(List<string> verses)
    {
        foreach(string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
    }

    public void Display()
    {
        foreach(Verse verse in _verses)
        {
            verse.Display();
        }
        
    }

    public bool HideWords(int count)
    {
        foreach (Verse verse in _verses)
        {
            if (!(IsAllHidden()))
            {
                return false;
            }
        }
        return true;
    }

    public bool IsAllHidden()
    {
        return false;
    }
}