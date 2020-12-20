using System;
using System.Collections;
using System.Collections.Generic;

namespace csTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Garage g = new Garage();
            //foreach (Car c in g)
            //{
            //    Console.WriteLine("Name : {0}\n",c.Name);
            //}
            //IEnumerator ie = g.GetEnumerator();
            //ie.MoveNext();
            //Car c1 = (Car)ie.Current;
            //Console.WriteLine(c1.Name);
            //ie.MoveNext();
            //ie.MoveNext();
            //Car c2 = (Car)ie.Current;
            //Console.WriteLine(c2.Name);

            //PersonCollection myPeople = new PersonCollection();

            //myPeople["Homer"] = new Person("Homer", "Simpson", 40);
            //myPeople["Marge"] = new Person("Marge", "Simpson", 38);
            //Person homer = myPeople["Homer"];
            //Console.WriteLine(homer.ToString());
            Console.WriteLine("Test Program");
            Console.WriteLine("Testing");
            Point c = new Point(3, 3);
            Point a = new Point(1, 1);
            Point b = new Point(1, 2);
            if (a > b)
                Console.WriteLine("a greater than b");
            else if (a < b)
                Console.WriteLine("a less than b");
            else
                Console.WriteLine("a is same as b");

        }
    }

    public class PersonCollection : IEnumerable
    {
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>();

        public Person this[string name]
        {
            get => (Person)listPeople[name];
            set => listPeople[name] = value;
        }

        public void ClearPeople()
        {
            listPeople.Clear();
        }

        public int Count => listPeople.Count;

        IEnumerator IEnumerable.GetEnumerator() => listPeople.GetEnumerator();

    }

    public class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point operator ++(Point a) => new Point(a.X + 1, a.Y + 1);
        public static Point operator --(Point a) => new Point(a.X - 1, a.Y - 1);

        public override string ToString()
        {
            return String.Format("X : {0} and Y : {1}", X, Y);
        }

        public override bool Equals(object obj)
        {
            return obj.ToString() == this.ToString();
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public static bool operator ==(Point a, Point b)
        {
            return a.Equals(b);
        }
        
        public static bool operator !=(Point a,  Point b)
        {
            return !a.Equals(b);
        }

        
        public int CompareTo(Point o)
        {
            if (this.X > o.X && this.Y > o.Y)
                return 1;
            else if (this.X < o.X && this.Y < o.Y)
                return -1;
            else
                return 0;
        }

        public static bool operator > (Point p1, Point p2)
        {
            return p1.CompareTo(p2) > 0; 
        }

        public static bool operator < (Point p1, Point p2)
        {
            return p1.CompareTo(p2) < 0;
        }

        public static bool operator >= (Point p1, Point p2)
        {
            return p1.CompareTo(p2) >= 0;
        }

        public static bool operator <= (Point p1, Point p2)
        {
            return p1.CompareTo(p2) <= 0;
        }





    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person()
        {

        }

        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
    }
    class Garage :IEnumerable
    {
        private ArrayList carArray = new ArrayList();


        public Car this[int index]
        {
            get => (Car)carArray[index];
            set => carArray.Insert(index, value);
        }
        public Garage()
        {
            carArray.Add(new Car("Rusty", 30));
            carArray.Add(new Car("Clunker", 55));
            carArray.Add(new Car("Zippy", 30));
            carArray.Add(new Car("Fred", 30));
        }

        public IEnumerator GetEnumerator()
        {
            yield return carArray[0];
            yield return carArray[1];
            yield return carArray[2];
            yield return carArray[3];
        }

    }

    class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int CurrSpeed { get; set; }

        public Car(string name, int maxsp)
        {
            Name = name;
            MaxSpeed = maxsp;
        }

    }
      
}
