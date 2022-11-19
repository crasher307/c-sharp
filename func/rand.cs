namespace func;

public class rand : baseFunc {
	// Задать рандомное число (int, double)
	public static T init<T>(int min, int max) {
		max++;
		T random = default(T) ?? (T) Convert.ChangeType("null", typeof(T));
		switch (typeof(T).Name) {
			case "Int16":
			case "Int32":
				random = (T) Convert.ChangeType(rnd.Next(min, max), typeof(T));
				break;
			case "Double":
				double num = rnd.Next(min, max);
				if (num < 0) num += rnd.NextDouble();
				if (num > 0) num -= rnd.NextDouble();
				random = (T) Convert.ChangeType(Math.Round(num, 2), typeof(T));
				break;
		}
		return random;
	}
}