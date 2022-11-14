
// string[,] table = new string[2, 5]; // двухмерный массив(table - имя массива)(string - тип данных) 
// // String.Empty - инициализация строк
// // table[0,0]  table[0,1]  table[0,2]  table[0,3]  table[0,4] - столбцы(индекс)
// // table[1,0]  table[1,1]  table[1,2]  table[1,3]  table[1,4] - строки(индекc)

// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++) // rows - Индекс строки
// {
//     for (int columns = 0; columns < 5; columns++) // columns - Индекс столбца
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }
// // 1_______________________________________________



// int[,] matrix = new int[2, 5];

// for (int i = 0; i < 2; i++) //   i - Индекс строки
// {
//     for (int j = 0; j < 5; j++) // j - Индекс столбца
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine(); // переход на новую строку
// }
//________________________________________

// // тоже но уже с конcтрукцией matrix.GetLength()
// //   matrix.GetLength -(0)(1)
// int[,] matrix = new int[2, 5];

// for (int i = 0; i < matrix.GetLength(0); i++) // (0) - Индекс строки
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // ((1) - Индекс столбца
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine(); // переход на новую строку
// }
// ______________________________________________

// // тоже но уже  методом void  
// void PrintArray(int[,] matr) //  matr сокращенно matrix
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // (0) - Индекс строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // (1) - Индекс столбца
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine(); // переход на новую строку
//     }
// }
// int[,] matrix = new int[2, 5]; //- инициализация массива
// PrintArray(matrix);
////______________________________________

//// тоже но уже  c заполнением случайными числами FillArray() 
// void PrintArray(int[,] matr) //  matr сокращенно matrix
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // (0) - Индекс строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // (1) - Индекс столбца
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine(); // переход на новую строку
//     }
// }
// void FillArray(int[,] matr) //  matr сокращенно matrix
// {
//     for (int i = 0; i < matr.GetLength(0); i++) // (0) - Индекс строки
//     {
//         for (int j = 0; j < matr.GetLength(1); j++) // (1) - Индекс столбца
//         {
//             matr[i, j] = new Random().Next(1, 10); // полуинтервал от 1 до 10 заполнения случайными числами
//         }
//     }
// }

// int[,] matrix = new int[2, 5];   //- инициализация массива
// PrintArray(matrix);
// FillArray(matrix); //- инициализация массива заполнененного случайными числами FillArray() 
// Console.WriteLine(); // переход на новую строку
// PrintArray(matrix);
// // ______________________________________



// // закрашивание картинки путем замены символов с использованием РЕКУРСИИ
// int[,] pic = new int[,] //- инициализация массива
// {
//     {0, 0, 1, 0, 0 },
//     {0, 1, 0, 1, 0 },
//     {1, 0, 0, 0, 1 },
//     {0, 1, 0, 1, 0 },
//     {0, 0, 1, 0, 0 },
// };
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++) // (0) - Индекс строки
//     {
//         for (int j = 0; j < image.GetLength(1); j++) // (1) - Индекс столбца
//         {
//             //Console.Write($"{matr[i, j]} ");
//             if (image[i, j] == 0) Console.Write($" "); //выводит пробелы 
//             else Console.Write($"&"); //выводит &
//         }
//         Console.WriteLine(); // переход на новую строку
//     }
// }
// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col); // РЕКУРСИЯ(метод когда функция вызывает сама себя)
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }
// PrintImage(pic);  // выводит пробел и $ на экран
// FillImage(2, 2);  // точка старта заполнения фигуры знаком $ (старт внутри фигуры обязателен)
// PrintImage(pic);  // выводит пробел и заполненую фигуру знаком $
// _____________________________________________________



// //   Факториал поиск кодом
// double Factorial(int n)
// {
//     // 1! = 1        один факториал равен единице
//     // 0! = 1        ноль факториал тоже равен единице
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {

//     Console.WriteLine($"{i}! = {Factorial(i)}");
// } 
// // _____________________________________________



// // Число ФИБОНАЧЧИ(следующее число задается через предыдущее) поиск кодом
// // f(1) = 1
// // f(2) = 1
// // f(n) = f(n-1) + f(n-2)

// double Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Fibonacci(i)}");
// }











