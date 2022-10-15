namespace Task2;

public static class Bwt
{
    public static (string result, int endPosition) Transform(string text)
    {
        var suffixArray = ConstructSuffixArray(text).ToArray();
        var result = "";
        var endPosition = 0;

        for (var i = 0; i < text.Length; i++)
        {
            if (suffixArray[i] == 0)
            {
                result += text.Last();
                endPosition = i;
            }
            else
            {
                result += text[suffixArray[i] - 1];
            }
            
            Console.WriteLine(suffixArray[i]);
        }
        return (result, endPosition);
    }

    private static IEnumerable<int> ConstructSuffixArray(string text)
    {
        var suffixArray = new List<int>();

        for (var i = 0; i < text.Length; i++)
        {
            suffixArray.Add(i);
        }

        suffixArray.Sort(((i, j) =>
            string.Compare(text[i..], text[j..], StringComparison.Ordinal)));

        return suffixArray;
    }
}