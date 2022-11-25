using func;

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

// -------------------------------------------------------------------

Dictionary<string, int> countValues<T>(T[] data) {
	var result = new Dictionary<string, int>();
	string key;

	for (int i = 0; i < data.Length; i++) {
		key = (string) $"{data[i]}";
		if (result.ContainsKey(key)) result[key]++;
		else result.Add(key, 1);
	}

	return result;
}

var data = new int[rw.getInt("Введите кол-во элементов")];
ar.init(data, 0, 9);

ar.echoArray(data);
foreach (var item in countValues(data).OrderBy(x => x.Key)) {
	rw.echo($"\"{item.Key}\" встречается {item.Value} раз(а)");
}

// -------------------------------------------------------------------

/* Первая реализация
void countValues<T>(T[] data) {
	var names = new List<T>();
	var count = new List<int>();

	for (int i = 0, idx = 0; i < data.Length; i++) {
		if (names.Contains(data[i])) {
			idx = names.IndexOf(data[i]);
			count[idx]++;
		} else {
			idx = names.Count;
			names.Add(data[i]);
			count.Add(1);
		}
	}
	
	for (int i = 0; i < names.Count; i++) {
		rw.echo($"\"{names[i]}\" встречается {count[i]} раз(а)");
	}
}

var data = new int[rw.getInt("Введите кол-во элементов")];
ar.init(data, 0, 9);

var names = new List<int>();
var count = new List<int>();

ar.echoArray(data);
countValues(data);
*/

// -------------------------------------------------------------------

/*
// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Набор данных
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

(List <int>, List <int>) CalculateNumbers(int[,] inArray)
{
    int flag = 0;
    List <int> elements = new List <int>();
    List <int> numberOfElements = new List <int>();
    
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++) {
            for (int k = 0; k < elements.Count(); k++) {
                if (elements[k] == inArray[i, j]) {
                    numberOfElements[k] += 1;
                    flag = 1;
                }
            }
            if (flag != 1) {
                elements.Add(inArray[i,j]);
                numberOfElements.Add(1);
                flag = 0;
            }
            flag = 0;
        }
    }
    return (elements, numberOfElements);
}

void PrintList(List <int> inList) {
    for (int k = 0; k < inList.Count(); k++) {
        Console.Write($"{inList[k]} ");
    }
    Console.WriteLine();
}

int[,] inArray = InitArray(3, 3);

(List <int> elements, List <int> numberOfElements) = CalculateNumbers(inArray);

PrintArray(inArray);

PrintList(elements);

PrintList(numberOfElements);
*/

/* Реализация препода
int[,] InitMatrix(int n, int m)
{
    Random rnd = new Random();
    int[,] matrix  = new int[n,m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i,j] = rnd.Next(1,20);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
}

Dictionary<int, int> GetDictionaryFromMatrix(int[,] matrix)
{
    Dictionary<int,int> resultDic = new Dictionary<int, int>();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(resultDic.ContainsKey(matrix[i,j]))
                resultDic[matrix[i,j]] += 1; 
            else
                resultDic.Add(matrix[i,j], 1);
        }
    }

    return resultDic;
}


int[,] matrix = InitMatrix(4,4);
PrintMatrix(matrix);
Dictionary<int,int> dic = GetDictionaryFromMatrix(matrix);

foreach(var item in dic.OrderBy(x=>x.Key))
{
    Console.WriteLine($"{item.Key} встречается {item.Value} раза ");
}
*/