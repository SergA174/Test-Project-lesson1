// // Собрать строку от А до В, где А меньше либо равно В.

// string NumbersFor(int a, int b)
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++) //for (int i = a; i >= b; i--) - - для убывания чисел
//     {
//         result += $"{i} ";
//     }
//     return result;
// }

// string NumbersRec(int a, int b)// рекурсия
// {
//     if (a <= b) return $"{a} " + NumbersRec(a + 1, b);//if (a <= b) return NumbersRec(a + 1, b) + $"{a} "; - для убывания чисел
//     else return String.Empty;
// }
// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));
// ____________________________________________



// // Сумма чисел от от 1 до n.
// int SumFor(int n)
// {
//     int result = 0;
//     for (int i = 1; i <= n; i++)
//     result = result + i;
//     return result;
// }
// int SumRec(int n) // рекурсия
// {
//     if (n == 0) return 0;
//     else return n + SumRec(n - 1);
// }
// Console.WriteLine(SumFor(10));
// Console.WriteLine(SumRec(10));
//__________________________________



// // Факториал числа
// int FactorialFor(int n)
// {
//     int result =1;
//     for(int i = 1; i <= n; i++) result = result + i;
//     return result;
// }
// int FactorialRec(int n) // рекурсия
// {
//     if (n == 1) return 1;
//     else return n * FactorialRec(n - 1);
// }
// Console.WriteLine(FactorialFor(10));
// Console.WriteLine(FactorialRec(10));
// //___________________________________




// // Вычислить а в степени n
// // int FactorialFor(int n)
// int PowerFor(int a, int n)
// {
//     int result = 1;
//     for (int i = 1; i <= n; i++) result = result * a;
//     return result;
// }
// int PowerRec(int a, int n) // рекурсия
// {   // return n == 0 ? 1: PowerRec(a, n - 1)* a; //- заменяет строку 72,73
//     if (n == 0) return 1;
//     else return PowerRec(a, n - 1) * a;
// }
// int PowerRecMath(int a, int n) // рекурсия
// {
//     if (n == 0) return 1;
//     else if (n % 2 == 0) return PowerRecMath(a * a, n / 2) * a;
//     else return PowerRecMath(a, n - 1) * a;
// }    
// Console.WriteLine(PowerFor(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// Console.WriteLine(PowerRec(2, 10));
// //______________________________________________________________



// // Перебор слов. В некотором машинном алфавите
// // имеются четыре буквы "а, и, с, в". Покажите
// // все слова, состоящие из Т букв, которые можно построить
// // из букв этого алфавита.
// int n = 1;
// void FindWords (string alphabet, char[] world, int length = 0)
// {
//     if(length == world.Length)
//     {
//         Console.WriteLine($"{n++} {new String(world)}"); return;
//     }
//     for (int i = 0; i < alphabet.Length; i++)
//     {
//         world[length] = alphabet[i];
//         FindWords(alphabet, world, length + 1);
//     }
// }
// FindWords("аисв", new char[5]);
// //____________________________________________________



// // Пример работы с деррикториями(алгоритм обхода)
// string path = "указываем путь к папке";// работает только при инициализации всех папок
// DirectoryInfo di = new DirectoryInfo(path);
// System.Console.WriteLine(di.CreationTime);// показать данные создание папки
// FileInfo[] fi = di.GetFiles();// просмотр файлов в папке
// for (int i = 0; i < fi.Length; i++)
// {
//     System.Console.WriteLine(fi[i].Name); //вызов имени файла
// }
// void CatalogInfo(string path, string indent = "") //рекурсия(обзор по папкам 
// // их содержимого), (indent = ""   ----    прием для отступов, чтоб видеть структуру папки )
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);

//     DirectoryInfo[] catalogs = catalog. GetDirectories();// массив файлов
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}"); //просмотр информации о текущем каталоге
//         CatalogInfo(catalogs[i].FullName, indent + " ");//вывод просмотренной информации 
//     }
//     FileInfo[] files = catalog.GetFiles();// список файлов дерриктории

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}"); //вывод файлов дерриктории
//     }
// }
// CatalogInfo(path);
// // ______________________________________________________________________




// // игра в пирамидки"Ханойские башни"
// void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // количество блинов-сount.
//                                                                                   //  on, some, with-шпильки
// {
//     if (count > 1 ) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with} >> {on}");
//     if (count > 1 ) Towers(some, on, with, count - 1);
// }
// Towers();
// //______________________________________________________



// // Рещение арифметического выражения(бинарное дерево):
// // ((4 - 2) * (1 + 3)) / 10
// string emp = String.Empty;
// string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"}; // одномерный массив
// //  индекс             0    1    2     3    4    5    6    7    8    9    10  11
// void InOrderTraversal(int pos = 1)
// {
//     if (pos < tree.Length)
//     {
//         int left = 2 * pos;
//         int right = 2 * pos +1;
//         if (left < tree.Length && !String.IsNullOrEmpty(tree[left]))InOrderTraversal(left);// обход пустой позиции
//         Console.Write(tree[pos]);
//         if (right < tree.Length && !String.IsNullOrEmpty(tree[right]))InOrderTraversal(right); // обход пустой позици
//     }
// }
// InOrderTraversal();
// //____________________________________________________________



// // Cравнение работы рекурсивной функции(занимающей большой обьем вычислений) и итеративной финкции
// decimal fRec = 0;
// decimal fIte = 0;
// decimal FibonacciRecursion(int n)// рекурсивный метод
// {
//     fRec++;
//     return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
// }
// decimal FibonacciIteration(int n)// итеративный метод
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i <= n; i++)
//     {
//         result = f0 + f1;
//         f0 = f1;
//         f1 = result;
//         fIte++;
//     }
//     return result;
// }

// Console.ReadLine(); 

// DateTime dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
//     fIte = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
//     fRec = 0;
// }
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
// Console.ReadLine();
// //___________________________________________________________________

