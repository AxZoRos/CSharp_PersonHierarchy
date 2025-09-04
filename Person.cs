using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB16_KTP
{
    internal class Person
    {
         // Приватні поля
        private string name;
        private int age;
        // Властивість для доступу до name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // Властивість для age з валідацією
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Вік не може бути від'ємним.");
                age = value;
            }
        }
        // Конструктор класу Person
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Метод для порівняння віку з іншою особою
        public int CompareAge(Person other)
        {
            return this.Age - other.Age;
        }
        // Метод для виведення базової інформації про особу
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Ім'я: {Name}, Вік: {Age}");
        }
    }
    // Клас-нащадок Child з додатковою властивістю для школи
    class Child : Person
    {
        public string SchoolName { get; set; }

        public Child(string name, int age, string schoolName)
            : base(name, age)
        {
            SchoolName = schoolName;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Школа: {SchoolName}");
        }
    }
    // Клас-нащадок Adult з додатковою властивістю для посади/роботи
    class Adult : Person
    {
        public string Occupation { get; set; }

        public Adult(string name, int age, string occupation)
            : base(name, age)
        {
            Occupation = occupation;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Робота: {Occupation}");
        }

    }
}
