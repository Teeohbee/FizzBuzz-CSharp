public class Translator
{
	public static string Translate(int i)
	{
		string returnString = string.Empty;
		returnString = Fizzy (i, returnString);
		returnString = Buzzy (i, returnString);
		returnString = Other (i, returnString);
		return returnString;
	}

	private static bool ShouldBuzz(int i)
	{
		return i % 5 == 0;
	}

	private static bool ShouldFizz(int i)
	{
		return i % 3 == 0;
	}

	private static string Fizzy(int i, string returnString)
	{
		return returnString + (ShouldFizz (i) ? "Fizz" : string.Empty);
	}

	private static string Buzzy(int i, string returnString)
	{
		return returnString + (ShouldBuzz (i) ? "Buzz" : string.Empty);
	}

	private static string Other(int i, string returnString)
	{
		return string.IsNullOrEmpty (returnString) ? i.ToString () : returnString;
	}
}
