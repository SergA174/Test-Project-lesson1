int[] array = {17, 84, 46, 5, 37, 32, 58, 73, 5};

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
        // останавливает поиск на первом найденном
        break;
    }
    // index = index +1; - замена сокращенным значением
    index++; 
}