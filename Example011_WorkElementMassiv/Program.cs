//  войд-метод не возвращения.
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,10);
        // index = index +1; - замена сокращенным значением
        index++; 
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        // без Line выводит горизонтально
        Console.WriteLine(col[position]);
        position++; 
    }
}

int[] array = new int[10];
// заполняет массив произвольными
FillArray(array);
// вывод результата
PrintArray(array);