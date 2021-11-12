using System;
using System.Collections.Generic;

namespace EssentialLesson11Task3
{
    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс Dictionary<TKey, TValue>. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса Dictionary из
    //    пространства имен System.Collections.Generic.Минимально требуемый интерфейс взаимодействия с экземпляром, должен включать метод добавления пар элементов, индексатор для получения
    //    значения элемента по указанному индексу и свойство только для чтения для получения общего количества пар элементов.
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> dict = new MyDictionary<int, string>();

            dict.Add(1,"One");
            dict.Add(2,"Two");
            dict.Add(3,"Three");
            dict.Add(4,"Four");
            Console.WriteLine(new string('-',20));
            Console.WriteLine($"Dict count is: {dict.Count}");
            Console.WriteLine(new string('-', 20));
            foreach (KeyValuePair<int, string> item in dict)
            {
                Console.WriteLine(item.ToString());
            }
            dict.Clear();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"Dict count is: {dict.Count}");
        }
    }
}
