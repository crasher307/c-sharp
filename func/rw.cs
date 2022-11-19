namespace func;

public class rw : baseFunc {
	public static string messageGet = "Ожидается ввод";

	// Вывод
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
	public static void echoObject(string message, object obj, bool ln = true) {
		Console.ForegroundColor = ConsoleColor.Yellow;
		
		if (ln == true) Console.WriteLine(message, obj);
		else Console.Write(message, obj);

		Console.ResetColor();
	}

	// Ввод
	// (int, float, double) option - только положительные числа
	public static bool get<T>(out T variable, string? message = null, bool option = false) {
		string type = typeof(T).Name;
		string read = String.Empty;
		bool isConvert = false;

		message = $"({type}) " + (message ?? messageGet);
		variable = default(T) ?? (T) Convert.ChangeType("null", typeof(T));

		while (!isConvert) {
			echo(message, false, "get");
			read = Console.ReadLine() ?? "null";

			try {
				variable = (T) Convert.ChangeType(read, typeof(T));
				isConvert = !option ? true : getOption(ref variable);
			} catch {
				error("Error type", $"Ожидается тип {type}");
			}
		}
		return isConvert;
	}
	public static bool getOption<T>(ref T variable) {
		string? errorMessage = null;
		switch (typeof(T).Name) {
			case "Int16":
			case "Int32": // int
			case "Single": // float
			case "Double": // double
				double valueNumber = variable == null ? 0 : (double) Convert.ChangeType(variable, typeof(double));
				if (valueNumber <= 0) errorMessage = "Ожидается положительное число";
				break;
		}
		if (errorMessage != null) rw.error(errorMessage);
		return errorMessage == null;
	}

	// TODO delete
	public static string getStr(string message = "Введите строку") { // TODO обратная совместимость
		get(out string parse, message);
		return parse;
	}
	public static int getInt(string message = "Введите число", bool onlyPositive = false) { // TODO обратная совместимость
		get(out int parse, message, onlyPositive);
		return parse;
	}
	public static float getFloat(string message = "Введите число", bool onlyPositive = false) { // TODO обратная совместимость
		get(out float parse, message, onlyPositive);
		return parse;
	}
	public static bool getBool(string message = "Введите да/нет") { // TODO обратная совместимость
		get(out bool parse, message);
		return parse;
	}
}