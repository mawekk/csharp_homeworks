namespace Task2Test;

using NUnit.Framework;
using Task2;

public class Tests
{
    private static object[] TestCases =
    {
        new object[] { "", "", 0 },
        new object[] { "imtired", "erdtiim", 2 },
        new object[] { "bebrochka", "kaeobchrb", 1 },
        new object[] { "blinblinsky", "ynllsbbiink", 0 },
    };

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void TransformTest(string text, string result, int endPosition)
    {
        Assert.That(Bwt.Transform(text), Is.EqualTo((result, endPosition)));
    }

    [Test]
    [TestCaseSource(nameof(TestCases))]
    public void RetransformTest(string result, string text, int endPosition)
    {
        Assert.That(Bwt.Retransform(text, endPosition), Is.EqualTo(result));
    }

}