// // МЕТОДЫ как показать ЧИСЛА ОТ -N до N:
// void Metod(int maximum)
// {
//     int minimum;
//     minimum = -maximum;
//     while (minimum <= maximum)
//     {
//         Console.Write(minimum + " ");
//         minimum++;
//     }
// }
// //_________________________________________
// int[] CreateFrray(int N)
// {
//     int[] arrayA = new int[N * 2 + 1];
//     for (int i = -N; i <= N; i++)
//     {
//         arrayA[i + N] = i;
//     }
//     return arrayA;
// }
// //___________________________________________
// int Ar(int N) // задаем метод
// {
//     int x = -N; // первая цифра -N (задаем цикл)
//     while (x <= N) // до тех пор пока х меньше или равен N 
//     {
//         Console.Write(x); // выцводим консоль "х"
//         x++; // инкремент
//     }
//     return x;
// }
// //___________________________________________
// void Numbers(int n)
// {
//     int length = n + n;
//     for (int i = 0; i < length + 1; i++)
//     {
//         Console.Write(-n + i);

//     }
// }
// //___________________________________________
// string ShowNums(int N)
// {
//     for (int i = -N; i < N; i++)
//     {
//         NumsShow = NumShow + i + " ";
//     }
//     return NumsShow;
// }
// //___________________________________________
// int af = -5;
// int uf = -5;
// Console.WriteLine($"{af}...{uf}");
// //___________________________________________



int a = 12;
Console.Writeline(a.GetType());

