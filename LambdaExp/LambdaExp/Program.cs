using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> listPersonsInCity = new List<Person>();
            AddRecords(listPersonsInCity);
            foreach(Person persons in listPersonsInCity)
            {
                Console.WriteLine(persons.Name+" "+persons.Address+" "+persons.Age+" "+persons.SSN);
            }
            Console.WriteLine("===============================");
            RetrievingTopTwoRecordsForAgeIsLessThanSixty(listPersonsInCity);
            Console.WriteLine("===============================");
            CheckingForTeenagerPerson(listPersonsInCity);
            Console.WriteLine("===============================");
            RetrieveAverageAge(listPersonsInCity);
            Console.WriteLine("===============================");
        }
        public static void AddRecords(List<Person> listPersonsInCity)
        {
    listPersonsInCity.Add(new Person("234345456", "Balla", "H.No. 9-99/9,Sardar Road,Houston", 15));
    listPersonsInCity.Add(new Person("245342234", "Rahul", "H.No. 8-11/9,Subhash Road,Houston", 26));
    listPersonsInCity.Add(new Person("457653456", "Sachin", "H.No. 2-9,BhagathSingh Road,Houston", 13));
    listPersonsInCity.Add(new Person("905689878", "Virendar", "H.No. 1/9,Udham Road,Houston", 67));
    listPersonsInCity.Add(new Person("342121234", "Sourabh", "H.No. 3/9-1,Alluri Road,Houston", 74));
    listPersonsInCity.Add(new Person("789098765", "VVS", "H.No. 12/2-1,Komaram Bhim Road,Houston", 61));
    listPersonsInCity.Add(new Person("642725421", "Yuvaraj", "H.No. 123/2,Shoppers Road,Houston", 26));
        }
        public static void RetrievingTopTwoRecordsForAgeIsLessThanSixty(List<Person> listPersonsInCity)
        {
        foreach (Person person in listPersonsInCity.FindAll(e=>(e.Age>=60)).Take(2).ToList())
            {
            Console.WriteLine("Name "+person.Name+" \t\tAge: "+person.Age);
            }
        }
        public static void CheckingForTeenagerPerson(List<Person> listPersonsInCity)
        {
            if(listPersonsInCity.Any(e=>(e.Age<=19&&e.Age>=13)))
            {
                Console.WriteLine("Yes, We have some teenagers in the list");
            }
            else
            {
                Console.WriteLine("We Do not have teenagers in the list");
            }
        }
        public static void RetrieveAverageAge(List<Person> list)
        {
            double average = list.Average(p => p.Age);
            Console.WriteLine(average);
        }

    }
}