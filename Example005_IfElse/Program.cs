Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "наташа")
{
    Console.WriteLine("Ура, это же Наташа!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}