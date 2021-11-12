using System;
using System.Collections;

namespace EssentialLesson11Task1
{

    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //В коллекцию ArrayList, через вызов метода Add добавьте элементы структурного и ссылочного типа, переберите данную коллекцию с помощью, цикла for. С какой проблемой вы столкнулись?
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("test");
            list.Add(1);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine((string)list[i]);
            }
        }
    }
}


/*  1) Упаковка и распаковка в класс объект - ресурсозатраные операции
 *  2) Не могу использовать конкретные свойства и методы, принадлежащие конкретным классам без каста к конкретным классам, или структурам- Console.WriteLine((string)list[i]); (выдаст ошибку).
 *  3) Безопасное использование только методов класса объект
 */