namespace EssentialLesson11Task2
{
    class Car
    {

        public int Year { get; private set; }
        public string Name { get; private set; }

        public Car(int year, string name)
        {
            Year = year;
            Name = name;
        }

        public override string ToString()
        {
            return $"Car year: {Year}, Car Name: {Name}";
        }
    }
}
