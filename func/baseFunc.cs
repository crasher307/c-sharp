namespace func;

public class baseFunc {
	protected static Random rnd = new Random();
	
	// Вывод ошибок
	public static void error(string type, string? message = null) {
		if (message == null) (type, message) = ("Error", type);
		Console.BackgroundColor = ConsoleColor.Red;
		Console.Write($" {type} ");
		Console.BackgroundColor = ConsoleColor.Gray;
		Console.WriteLine($" {message} ");
		Console.ResetColor();
	}
}