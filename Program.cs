using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB16_KTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            // Створення базових об'єктів класу Person
            Person person1 = new Person("Іван Петров", 30);
            Person person2 = new Person("Олексій Коваленко", 25);

            // Створення об'єктів похідних класів
            Child child = new Child("Марія", 10, "Школа N1");
            Adult adult = new Adult("Коновалов Євгеній", 35, "Програміст");

            // Виведення інформації про двох осіб
            Console.WriteLine("Порівняння віку між людьми:");
            person1.DisplayInfo();
            person2.DisplayInfo();

            int ageDifference = person1.CompareAge(person2);
            if (ageDifference > 0)
                Console.WriteLine($"{person1.Name} старший за {person2.Name} на {ageDifference} років.");
            else if (ageDifference < 0)
                Console.WriteLine($"{person2.Name} старший за {person1.Name} на {-ageDifference} років.");
            else
                Console.WriteLine($"{person1.Name} та {person2.Name} мають однаковий вік.");

            // Вивід розширеної інформації для дитини та дорослої особи
            Console.WriteLine("\nІнформація про дитину:");
            child.DisplayInfo();

            Console.WriteLine("\nІнформація про дорослого:");
            adult.DisplayInfo();

            Console.ReadLine();
        }
    }
}
