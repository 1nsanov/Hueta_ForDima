using System;
using System.Collections.Generic;

namespace ConsoleAppHuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            var users = new List<User>();
            for (int i = 1; i < 3; i++)
            {
                Console.Write("Введите имя: ");
                var name = InputString();
                Console.Write("Введите возраст: ");
                var age = IntParse();
                Console.Write("Введите пол: ");
                var gender = InputString();

                var user = new User(name, age, gender);                
                users.Add(user);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        static private string InputString()
        {
            while (true)
            {
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Строка не может быть пустой.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    return name; 
                }
            }            
        }

        static private int IntParse()
        {
            while (true)
            {
                var age = Console.ReadLine();
                if (int.TryParse(age, out int a))
                {
                    return a;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода.");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }           
        }
        
    }
}
