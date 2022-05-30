using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10); // 큰 수를 반환

            /*
                        List<int> list = new List<int>();
                        list.Add(1);
                        list.Add(2);
                        list.Add(4);
                        list.Add(8);*/

            List<int> list = new List<int>() { 1, 2, 4, 8 };
            list.Remove(2);
            list.RemoveAt(1);

            foreach (var item in list)
            {
                Console.WriteLine("Count : " + list.Count + "\t" + item);
            }



            Console.WriteLine(Math.Abs(-52323));
            Console.WriteLine(Math.Ceiling(52.323));
            Console.WriteLine(Math.Floor(52.323));
            Console.WriteLine(Math.Round(52.323));
            Console.WriteLine(Math.Round(52.323, 2)); // 소수점 둘 째자리에서 반올림
            Console.WriteLine(Math.Max(52, 323));
            Console.WriteLine(Math.Min(52, 323));
            Console.WriteLine(Math.PI);

            Product product = new Product();
        }
    }

    internal class Product
    {
        public Product()
        {
        }
    }
}
