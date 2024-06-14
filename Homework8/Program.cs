void BobbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) // цикл для перечисление елементов массива
    {
       for (int j = 0; j < arr.Length - i - 1;j++) // цикл для проверки и сравнения елементов массива
       {
            if (arr[j] > arr[j + 1]) // сравниваем прежднее число и текущее
            {
                int temp = arr[j]; // сохраняем первое значение
                arr[j] = arr[j + 1]; // меняем первое значение на следующее
                arr[j + 1] = temp;  // меня второе значение на предыдущие
            }
       }
    }
}

void InsertionSort(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) // цикл для перечисление елементов массива
    {
        int key = arr[i]; // текущее значение
        bool skip = false;
        for (int j = i-1; j >= 0 && skip == false;) // цикл для проверки и сравнения елементов массива
        {
            if (key < arr[j]) // проверка текущего числа 
            {
                arr[j + 1] = arr[j]; // замена
                j--;
                arr[j + 1] = key; // замена
            }
            else
                skip = true;
        }
    }
}
int[] GetRandomArr(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    int start = 10;
    int end = 1000;

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(start,end);
    }
    return arr;
}

void printarr(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write(item.ToString()+"\t");
    }
}

int[] newarr = GetRandomArr(30);
printarr(newarr);

Console.WriteLine("\n");

BobbleSort(newarr);
printarr(newarr);

Console.WriteLine("\n");

newarr = GetRandomArr(30);
printarr(newarr);

Console.WriteLine("\n");

InsertionSort(newarr);
printarr(newarr);