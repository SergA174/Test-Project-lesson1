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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    // для указания в выводе не найденного элемента ставим(-1), при отсутсвии искомого элемента будет выведено(-1)
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            // останавливает поиск на первом выпавшем значении
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10];
// заполняет массив произвольными
FillArray(array);
// искусственное добавление элементов в массив
// array[4] = 4;
// array[6] = 4;
// вывод результата
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);