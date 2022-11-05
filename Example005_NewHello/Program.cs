Console.Write("Ввведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "арина")
{
    Console.WriteLine("Ура, это же Арина! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}