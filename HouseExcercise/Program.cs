using System;

namespace HouseExercise
{
    class House
    {
        private int _yearBuilt;
        private double _size;

        public int YearBuilt
        {
            get { return _yearBuilt; }
            set { _yearBuilt = value; }
        }

        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public House(int yearBuilt, double size)
        {
            _yearBuilt = yearBuilt;
            _size = size;
        }

        private int HowOld()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - _yearBuilt;
        }

        public bool CanBeSold()
        {
            return HowOld() > 15;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== House Details Input ===");
            Console.Write("Enter the year the house was built: ");
            int yearBuilt = int.Parse(Console.ReadLine());

            Console.Write("Enter the size of the house: ");
            double size = double.Parse(Console.ReadLine());

            House myHouse = new House(yearBuilt, size);

            Console.WriteLine("\n=== House Information ===");
            Console.WriteLine($"Year Built: {myHouse.YearBuilt}");
            Console.WriteLine($"Size: {myHouse.Size} sq. units");
            Console.WriteLine($"Can be sold: {myHouse.CanBeSold()}");
        }
    }
}
