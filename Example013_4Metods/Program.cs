// // Вид 1  не возвращает:
// void Method1()
// {
//     Console.WriteLine("Автор имя... ");
// }
// Method1();




// // Вид 2  не возвращает:
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "текст сообщения");

// // образец:
// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// // Method21(msg: "текст", count: 4); // сколько раз поворить выводимый текст для заданного аргумента (msg:)
// Method21(count: 4, msg: "новый текст");// сколько раз поворить выводимый текст для заданного аргумента (msg:)




// // Вид 3  возвращает:
// int Method3() 
// {
//     return DateTime.Now.Year; // Вызов текущей даты
// }

// int year = Method3(); // положен результат вызова
// Console.WriteLine(year); // вывод результата




// // Вид 4 принимает возвращает(преобладающая в использовании):
// string Method4(int count, string text) 
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;      
// }
// string res = Method4(4, "hervam))),"); // положен результат с количеством раз вывода 
// Console.WriteLine(res); // вывод результата




// // Примениение цикла (for):
// string Method4(int count, string text) 
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++) //применение (for)
//     {
//         result = result + text;
//     }
//     return result;      
// }
// string res = Method4(4, "hervam))),"); // положен результат с количеством раз вывода 
// Console.WriteLine(res); // вывод результата




// // пример решения задачи(вывод таблицы уможения на экран):
// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j}={i * j}");
//     }
//     Console.WriteLine();// создает разрыв между циклами при выводе
// }




// // пример решения задачи(РАБОТА С ТЕКСТОМ).
// // Дан текст. В тексте нужно все пробелы заменить черточками,
// // маленькие буквы "к" заменить большими буквами "К",
// // а большие "С" заменить маленькими "с".
// string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде, "
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю? ";
// //string s = "q w e r t y"
// //   0 1 2 3 4 5
// //s[4] это t

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";  //если текущий символ текста 
//         //совпал с символом который требуется заменить, заменяем
//         else result = result + $"{text[i]}"; //если нет совпадений то добавляем текущий символ
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|'); //замена элементов теста на новые элементы
// Console.WriteLine(newText); //вывод отформатированного текста
// Console.WriteLine(); //для отступа между выводами вариантов формата
// newText = Replace(newText, 'к', 'К'); //замена элементов теста на новые элементы
// Console.WriteLine(newText); //вывод отформатированного текста
// Console.WriteLine(); //для отступа между выводами вариантов формата
// newText = Replace(newText, 'С', 'с'); //замена элементов теста на новые элементы
// Console.WriteLine(newText); //вывод отформатированного текста




// // АЛГОРИТМ СОРТИРОВКИ - МЕТОДОМ ВЫБОРА.
// // 1. Найти позицию минимального элемента в 
// //    неотсортированной части массива
// // 2. Произвести обмен этого значения со значением первой
// //    неотсортированной позиции
// // 3. Повторять пока есть не отсортированные элемены в массиве

// int[] arr = { 2, 7, 5, 3, 8, 4, 1, 6, 5, 2 };

// void PrintArray(int[] array)
// {
//     int count = arr.Length;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// Console.WriteLine(); 
// }
// PrintArray(arr); //вывод заданного массива 
// void SelectionSort(int[] array) // упорядочивание массива
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j; // блок ищет максимальный элемент
//         }
//         int temporary = array[i]; // блок замены большего элемента на меньший 
//         array[i] = array[minPosition]; // блок замены большего элемента на меньший 
//         array[minPosition] = temporary; // блок замены большего элемента на меньший 
//     }

// }
// SelectionSort(arr); // упорядочивание массива
// PrintArray(arr); // вывод упорядоченного  массива

// // ТЕПЕРЬ ЗАДАЧА ОБРАТНАЯ ПРЕДЫДУЩЕЙ:
// // 1. Найти позицию максимального элемента в 
// //    неотсортированной части массива
// // 2. Произвести обмен этого значения со значением первой
// //    неотсортированной позиции
// // 3. Повторять пока есть не отсортированные элемены в массиве

// int[] arr = { 2, 7, 5, 3, 8, 4, 1, 6, 5, 2 };

// void PrintArray(int[] array)
// {
//     int count = arr.Length;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// Console.WriteLine(); 
// }
// PrintArray(arr);//вывод заданного массива 
// void SelectionSort(int[] array) // упорядочивание массива
// {
//     for (int i = 0; i < array.Length ; i++)// (- 1) 
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] > array[maxPosition]) maxPosition = j; // блок ищет минимальный элемент
//         }
//         int temporary = array[i]; // блок замены меньшего элемента на больший
//         array[i] = array[maxPosition]; // блок замены меньшего элемента на больший
//         array[maxPosition] = temporary; // блок замены меньшего элемента на больший
//     }

// }
// SelectionSort(arr); // упорядочивание массива
// PrintArray(arr); // вывод упорядоченного  массива


