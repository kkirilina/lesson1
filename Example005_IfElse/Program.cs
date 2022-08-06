using System;

namespace Example005_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя");
            string username = Console.ReadLine();

        if (username.ToLower() == "маша")
            {
                Console.WriteLine("Ура, это же Маша"); 
            }
        else
        {
            Console.Write("Привет, ");
            Console.Write(username);
        }
        }
    }
}
