using System;

public class Word
{
    private string original;
    private string translation;

	public Word(string original, string translation)
	{
        this.Original = original;
        this.Translation = translation;
	}

    public string Original { get => original; set => original = value; }
    public string Translation { get => translation; set => translation = value; }

    public override bool Equals(object obj)
    {
        var word = obj as Word;
        return word != null &&
               Original == word.Original &&
               Translation == word.Translation;
    }

    public override int GetHashCode() => HashCode.Combine(Original, Translation);

    public Word Swap() => new Word(Translation, Original);
}

public class WordList
{

}