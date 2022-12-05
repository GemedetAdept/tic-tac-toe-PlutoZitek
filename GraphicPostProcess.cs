public class GraphicPostProcess {

	public static string StripTabs(string inputString) {

		string outputString = inputString.Replace("\t", "");
		return outputString;
	}
}