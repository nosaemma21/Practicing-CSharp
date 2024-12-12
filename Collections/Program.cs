
using System.Collections;

var input = Enumerable.Range(0, 100_000_000).ToArray();

var list = new List<int>();
foreach (var item in input)
{
    list.Add(item);
}


Console.ReadKey();

public class CustomCollection : IEnumerable<string>
{
    public string[] Words { get; }

    public CustomCollection()
    {
        Words = new string[10];
    }

    private int _currentIndex = 0;
    public void Add(string item)
    {
        Words[_currentIndex] = item;
        ++_currentIndex;
    }

    public CustomCollection(string[] words)
    {
        Words = words;
    }

    public string this[int index]
    {
        get => Words[index];
        set => Words[index] = value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public IEnumerator<string> GetEnumerator()
    {
        //return new WordsEnumerator(Words);
        //foreach(var word in Words)
        //{
        //    yield return word;
        //}

        IEnumerable<string> words = Words;
        return words.GetEnumerator();
    }
}

public class WordsEnumerator : IEnumerator<string>
{
    private const int InitialPosition = -1;
    private int _currentPosition = InitialPosition;
    private readonly string[] _words;

    public WordsEnumerator(string[] words)
    {
        _words = words;
    }

    object IEnumerator.Current => Current;

    public string Current
    {
        get
        {
            try
            {
                return _words[_currentPosition];

            }
            catch (IndexOutOfRangeException ex)
            {

                throw new IndexOutOfRangeException($"{nameof(CustomCollection)}'s end reached.", ex);
            }
        }
    }

    public bool MoveNext()
    {
        ++_currentPosition;
        return _currentPosition < _words.Length;
    }

    public void Reset()
    {
        _currentPosition = InitialPosition;
    }

    public void Dispose()
    {

    }
}