namespace func;

public class baseFunc {
	// Считывание ввода
	public static string get(string message = "Введите строку") {
		echo(message, false, "get");
		return Console.ReadLine() ?? "";
	}
	
	// Вывод сообщения
	public static void echo(string message, bool ln = true, string color = "echo") {
		switch (color) {
			case "get":
				Console.ForegroundColor = ConsoleColor.Blue;
				message = $"{message}: ";
				break;
			case "echo":
				Console.ForegroundColor = ConsoleColor.Yellow;
				break;
		}
		
		if (ln == true) Console.WriteLine(message);
		else Console.Write(message);
		Console.ResetColor();
	}
	
	// Вывод ошибок
	public static void error(string type, string message) {
		Console.BackgroundColor = ConsoleColor.Red;
		Console.Write($" {type} ");
		Console.BackgroundColor = ConsoleColor.Gray;
		Console.WriteLine($" {message} ");
		Console.ResetColor();
	}
}