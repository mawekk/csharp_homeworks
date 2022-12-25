using System.Text;

namespace Task2;

public static class Bwt
{
    public static (string result, int endPosition) Transform(string text)
    {
        var suffixArray = ConstructSuffixArray(text).ToArray();
        var result = new StringBuilder(text.Length);
        var endPosition = 0;

        for (var i = 0; i < text.Length; i++)
        {
            if (suffixArray[i] == 0)
            {
                result.Append(text.Last());
                endPosition = i;
            }
            else
            {
                result.Append(text[suffixArray[i] - 1]);
            }
        }
        return (result.ToString(), endPosition);
    }
    
    public static string Retransform(string text, int endPosition)
    {
        var result = new StringBuilder(text.Length);
        var transformationArray =
            text.Select((symbol, index) => (symbol, index)).OrderBy(pair => pair.symbol).ToArray();

        foreach (var _ in text)
        {
            result.Append(text[transformationArray[endPosition].index]);
            endPosition = transformationArray[endPosition].index;
        }
        
        return result.ToString();
    }
    
    private static IEnumerable<int> ConstructSuffixArray(string text)
    {
        var suffixArray = new List<int>(text.Length);

        for (var i = 0; i < text.Length; i++)
        {
            suffixArray.Add(i);
        }

        suffixArray.Sort(((i, j) =>
            string.Compare(text[i..], text[j..], StringComparison.Ordinal)));

        return suffixArray;
    }
}