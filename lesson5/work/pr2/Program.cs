using func;

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// -------------------------------------------------------------------

int[] replaceNubers(int[] arrayNumbers) {
	int[] arr = new int[arrayNumbers.Length];
	for (int i = 0; i < arr.Length; i++) arr[i] = arrayNumbers[i] * -1;
	return arr;
}

var numbersArray = new int[rw.getInt("Введите кол-во эл-ов", true)];
ar.init(numbersArray, -9, 9);
int[] replaceArray = replaceNubers(numbersArray);

ar.echoArray(numbersArray);
ar.echoArray(replaceArray, "Измененный массив");

// -------------------------------------------------------------------

/*
int[] InitArray(int n)
{
    int[] result = new int[n];
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        result[i] = rnd.Next(-9,10);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Result( int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i]*(-1);
    }
    return result;

}

Console.Write("Введите длину массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = InitArray(n);
Print(array);
int[] result = Result(array);
Print(result);
*/