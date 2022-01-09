using System;
using System.Collections.Generic;

namespace FinalProject
{
    // Interfejs
    interface IFirefighter
    {
        int ID { get; set; }
    }

    class Firefighter
    {
        // Właściwości
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }

        // Konstruktory
        public Firefighter()
        {
            ID = 0;
            Name = "Unknown";
            Surname = "Unknown";
            Role = "Not assigned";
        }

        public Firefighter(int id, string name, string surname, string role)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Role = role;
        }

    }

    class OfficeWorker : Firefighter 
    { 
        public string Department { get; set; }

        public OfficeWorker()
        {
            ID = 0;
        }

        public void GetInfo()
        {
            Console.WriteLine("ID = {0}, Name = {1}, Surname = {2}, Role = {3}, Department = {4}", ID, Name, Surname, Role, Department);
        }

    }

    class Program
    {
        static void ClearALittleBit()
        {
            Console.WriteLine("   ");
        }

        static void Main(string[] args)
        {
            // Hello World
            Console.WriteLine("Hello World!");
            ClearALittleBit();

            // Typy danych, konwersja
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int resultDataType);
            Console.WriteLine("Result: {0}", resultDataType);
            ClearALittleBit();

            // Pętle

            // Tablice
            int[] intArray = new int[5] { 1, 2, 3, 4, 5 };
            char[] charArray = new char[3] { 'a', 'b', 'c' };

            try
            {
                foreach(char c in charArray)
                {
                    Console.WriteLine(charArray[c]);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Are you crazy?");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I'm about to do to you what Limp Bizkit did to music in the late '90s.");
            }

            ClearALittleBit();

            // Klasy
            Firefighter f1 = new Firefighter(1, "Carl", "Johnson", "1st Commander");
            Firefighter f2 = new Firefighter(2, "Trevor", "Philips", "2nd Commander");
            Firefighter f3 = new Firefighter(3, "Franklin", "Clinton", "Officer");

            OfficeWorker o1 = new OfficeWorker();
            o1.Name = "Steve";
            o1.Surname = "Jobs";
            o1.Role = "Office";
            o1.Department = "Communications";
            o1.GetInfo();

            ClearALittleBit();

            // List
            List<int> list = new List<int>();
            list.Add(1);

            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int resultList);
            list.Add(resultList);

            Console.WriteLine("Your list: ");

            foreach(int n in list)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(list.Count);
            list.Remove(1);

            // list.Insert(1, 10);
            // list.RemoveAt(1);

            ClearALittleBit();

            // SortedList
            SortedList<int, string> months = new SortedList<int, string>();
            months.Add(12, "December");
            months.Add(1, "January");
            months.Add(5, "May");

            Console.WriteLine("Sorted list of months: ");

            foreach(KeyValuePair<int, string> m in months)
            {
                Console.WriteLine("{0} = {1}", m.Key, m.Value);
            }

            ClearALittleBit();

            // Queue
            Queue<double> coords = new Queue<double>();
            coords.Enqueue(942.0);
            coords.Enqueue(246.3);
            coords.Enqueue(651.8);

            coords.Dequeue(); // dequeue first element
            Console.WriteLine("Next in queue: {0}", coords.Peek());

            ClearALittleBit();

            // Stack
            Stack<string> names = new Stack<string>();
            names.Push("John");
            names.Push("Peter");
            names.Push("Andrew");

            Console.WriteLine("Your stack: ");

            foreach (string n in names)
            {
                Console.WriteLine(n);
            }

            ClearALittleBit();

            // Dictionary
            Dictionary<string, string> codeName = new Dictionary<string, string>();
            codeName.Add("Volvo FL 280", "327[K]68");
            codeName.Add("Peugeot Boxer", "329[K]83");
            codeName.Add("Volvo FL 6", "339[K]42");

            if (codeName.ContainsKey("Volvo FL 280"))
            {
                Console.WriteLine("Volvo FL 280's codename is {0}", codeName["Volvo FL 280"]);
            }

            ClearALittleBit();

            // Struktury

            Square s1;
            s1.a = 4;
            s1.Diagonal();

            ClearALittleBit();

            // Referencje

            int a = 50;

            SetToZero(a);
            Console.WriteLine("Without ref = {0}", a);

            SetToZeroRef(ref a);
            Console.WriteLine("With ref = {0}", a);

            ClearALittleBit();
        }

        struct Square {

            public int a;

            public Square(int x)
            {
                a = x;
            }

            public void Area()
            {
                Console.WriteLine("Square's area is {0}", a * a);
            }

            public void Circuit()
            {
                Console.WriteLine("Square's circuit is {0}", 4 * a);
            }

            public void Diagonal()
            {
                Console.WriteLine("Square's diagonal is {0}", a * Math.Sqrt(2));
            }

        }

        // Bezsensowne metody, ale nie miałem pomysłu na coś z referencjami
        static void SetToZeroRef(ref int z)
        {
            z = 0;
        }

        static void SetToZero(int z)
        {
            z = 0;
        }

    }
}
