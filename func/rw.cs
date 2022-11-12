namespace func;

public class rw : baseFunc {
	// Ввод строки
	public static string getStr(string message = "Введите строку") {
		message += " (string)";

		string parse = get(message);
		echo("--- --- --- --- ---");

		return parse;
	}
	
	// Ввод числа
	public static int getInt(string message = "Введите число", bool onlyPositive = false) {
		message += " (int)";

		int parse;
		bool result;
		bool positive = !onlyPositive;
		
		while (!(result = int.TryParse(get(message), out parse)) || !(positive = parse > 0 || !onlyPositive)) {
			if (!result) error("Error type", "Требуется тип int");
			else if (!positive) error("Error number", "Требуется положительное число");
		}
		echo("--- --- --- --- ---");

		return parse;
	}

	// Ввод числа с плав. точкой
	public static float getFloat(string message = "Введите число") {
		message += " (float)";

		float parse;
		bool result;

		while (!(result = float.TryParse(get(message), out parse))) {
			if (!result) error("Error type", "Требуется тип float");
		}
		echo("--- --- --- --- ---");
		
		return parse;
	}

	// Ввод true/false
	public static bool getBool(string message = "Введите да/нет") {
		message += " (y/n)";

		bool parse = false;
		bool result = false;
		string value;

		string[] yes = {"y", "yes", "д", "да"};
		string[] no = {"n", "no", "н", "нет"};
		
		while (!result) {
			value = get(message).ToLower();
			if (yes.Contains(value)) value = "true";
			if (no.Contains(value)) value = "false";
			if (!(result = bool.TryParse(value, out parse))) error("Error type", "Требуется тип bool");
		}
		echo("--- --- --- --- ---");
		
		return parse;
	}
}