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

            /*Product product = new Product();
            product.name = "고구마";
            product.price = 6000;*/

            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { price = 6000, name = "고구마" };
            Product productC = new Product() { name = "옥수수" };

            // Console.WriteLine(product.name + ": " + product.price);
            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>()
            {
                new Student() { grade = 100, name = "함기훈"},
                new Student() { name = "가연우", grade = 100},
                new Student() { name = "김유나", grade = 100},
                new Student() { name = "김유진", grade = 99},
                new Student() { name = "김하진", grade = 80},
                new Student() { name = "박수연", grade = 101 },
                new Student() { name = "박혜원", grade = 77 },
                new Student() { name = "심이진", grade = 100 },
                new Student() { name = "유예영", grade = 33 },
                new Student() { name = "윤주희", grade = 22 },
                new Student() { name = "윤채원", grade = 88 }
        };

            /*foreach (var student in students)
            {
                if(student.grade > 60)
                {
                    students.Remove(student);
                }
            }*/

            /*for(int i = 0; i < students.Count; i++)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                    i--;
                }
            }*/

            for (int i = students.Count - 1; i >= 0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }


            foreach (var student in students)
            {
                Console.WriteLine(student);
            }



            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52.3));

            Console.WriteLine(MyMath.Abs(52f));
            Console.WriteLine(MyMath.Abs(52L));


            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);

            Console.WriteLine(productX);
            Console.WriteLine(productY);
            Console.WriteLine(Product.counter + "개가 생성되었습니다");

            SingleTon mySingle = SingleTon.getInstance();

            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");


            Product product = new Product("과자", 1500);
            productA = null;

            // #14
            Box box = new Box(10, 20);
            box.Width = 200;
            box.Height = 100;
            Console.WriteLine(box.Area);

            box.Width = -10;
            Console.WriteLine(box.Area);

            Box box2 = new Box(-10, -20);
            Console.WriteLine(box2.Area);


            //Console.WriteLine(Fibonacci.Get(1));
            //Console.WriteLine(Fibonacci.Get(10));
            //Console.WriteLine(Fibonacci.Get(30));
            Console.WriteLine(Fibonacci.Get(1000));

            Cat c = new Cat();
            Dog d = new Dog();

            List<Animal> Animals = new List<Animal>() {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                if (item is Dog) { ((Dog)item).Bark(); }
                if (item is Cat) { ((Cat)item).Meow(); }
                //item is Animal

                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }

            Child ChildA = new Child();
            Child ChildB = new Child("string");


            // Shadowing
            int number = 20;
            Console.WriteLine(number);

            foreach (var item in Animals)
            {
                item.Eat();
            }
        }
    }
}
