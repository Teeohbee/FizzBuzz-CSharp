using NUnit.Framework;

[TestFixture]
public class CeeBuzzTests
{
	[Test]
	public void TranslateOne()
	{
		string result = Translator.Translate (1);
		Assert.AreEqual ("1", result);
	}
	[Test]
	public void TranslateTwo()
	{
		string result = Translator.Translate (2);
		Assert.AreEqual ("2", result);
	}
	[TestCase(1, "1")]
	[TestCase(2, "2")]
	[TestCase(3, "Fizz")]
	[TestCase(6, "Fizz")]
	[TestCase(5, "Buzz")]
	[TestCase(10, "Buzz")]
	[TestCase(15, "FizzBuzz")]
	public void Translate(int input, string expected)
	{
		string result = Translator.Translate (input);
		Assert.That (result, Is.EqualTo (expected));
	}
}
