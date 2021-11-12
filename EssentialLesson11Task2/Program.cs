using System;

namespace EssentialLesson11Task2
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс CarCollection<T>. Реализуйте в простейшем приближении возможность использования его экземпляра для создания парка машин. Минимально требуемый интерфейс 
    //    взаимодействия с экземпляром, должен включать метод добавления машин с названием машины и года ее выпуска, индексатор для получения значения элемента по указанному индексу и 
    //    свойство только для чтения для получения общего количества элементов.
    //Создайте метод удаления всех машин автопарка.

    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> cars = new CarCollection<Car>();

            cars.Add(new Car(1997, "BMW"));
            cars.Add(new Car(1998, "Skoda"));
            cars.Add(new Car(1999, "Lada"));

            Console.WriteLine($"Count of cars: {cars.Count}");
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(cars[1]);
            Console.WriteLine(new string('-', 30));
            foreach (Car item in cars)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 30));
            cars.Clear();

            Console.WriteLine($"Count of cars: {cars.Count}");
        }
    }
}
