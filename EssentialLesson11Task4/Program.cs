using System;

namespace EssentialLesson11Task4
{

    //    Задание 4
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс ArrayList. Реализуйте в простейшем приближении возможность использования его экземпляра аналогично экземпляру класса ArrayList из пространства имен System.Collections.
    class Program
    {
        static void Main(string[] args)
        {
            MyArrayList list = new MyArrayList();
            list.Add(1);
            list.Add("Dog");
            list.Add(true);

            list.AllElToConsole();
            Console.WriteLine(new string('-', 20));
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
