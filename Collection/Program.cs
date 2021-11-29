using System;
using System.Collections.Generic;

namespace ColleCollectionsPr
{
    class NegativeNumsException : Exception
    {
        public NegativeNumsException() : base() { }
        public NegativeNumsException(string str) : base(str) { }
        public NegativeNumsException(string str, Exception inner) : base(str, inner) { }
        public NegativeNumsException(System.Runtime.Serialization.SerializationInfo si,
            System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }
    }
    class Person
    {
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
                        
            List<Person> people = new List<Person>(3);
            people.Add(new Person() { Name = "Том" });
            people.Add(new Person() { Name = "Билл" });
            
            foreach (Person p in people)
                Console.WriteLine(p.Name);
            

            for (int i = 0; i < people.Count; i++)
                Console.WriteLine(people[i].Name);

            int j = 0;

            while(j < people.Count)
            {
                Console.WriteLine(people[j].Name);
                j++;
            }

            Console.WriteLine();
            Console.WriteLine();

            List<int> positivNums = new List<int>() { 2, 3, 7, 0 };

            Console.WriteLine( SumPositiveNums(positivNums));

            positivNums.Add(-5);

            try
            {
                Console.WriteLine (SumPositiveNums(positivNums));
            }
            catch(NegativeNumsException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static int SumPositiveNums(List<int> nums)
        {
            int sum = 0;

            for(int i = 0; i< nums.Count; i++)
            {
                if (nums[i] < 0)
                    throw new NegativeNumsException("Параметр метода содержит отрицательное значение");

                sum += nums[i];
            }

            return sum;

        } 
    }
}
