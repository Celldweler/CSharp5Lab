using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
А) Построить иерархию классов в соответствии с вариантом задания: 
            2. Служащий, персона, рабочий, инженер. 
Б) Разработать поля, методы и свойства для каждого из определяемых классов. Все поля классов должны быть описаны с ключевым словом
private. Реализовать для каждого класса конструкторы по умолчанию и конструкторы с параметрами. Методы по изменению значения полей,
поиска информации из массива данных объектов по определённым критериям. В) Реализовать для иерархии механизм интерфейсов, при этом
один из классов должен реализовывать как минимум 2 интерфейса.  Г) Использовать для проверки всех методов данного класса 
многоадресный делегат. 
*/
namespace CSharp5Lab
{
    interface Interface1
    {
        string Print_info();
    }
    abstract class Person : Interface1
    {
        protected string surname;
        protected string name;
        protected string patronymic;
        protected string sex;
        protected int age;

        public Person(string surname, string name, string patronymic, string sex, int age)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.sex = sex;
            this.age = age;
        }


        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public virtual string Print_info()
        {
            string s = "";
            return s = "Фамилия " + surname + "\n" + " Имя " + name + "\n" + " Отчество " + patronymic + "\n" + "пол " + sex + "\n" + " возраст " + age + "\n";
        }

        public virtual double ZP()
        {
            double z = 1;
            return z;
        }


    }

    class Employee : Person
    {
        int experience;
        public Employee(string surname, string name, string patronymic, string sex, int age, int experience)
            : base(surname, name, patronymic, sex, age)
        {
            this.experience = experience;

        }

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }


        public override string Print_info()
        {
            return base.Print_info() + " Стаж" + experience + "\n";
        }

        public override double ZP()
        {
            double minsalary = 0.0;
            return minsalary * experience;
        }



    }

    class Worker : Employee
    {
        string work_place;

        public Worker(string surname, string name, string patronymic, string sex, int age, int experience, string work_place)
            : base(surname, name, patronymic, sex, age, experience)
        {
            this.work_place = work_place;
        }

        public string Work_Place
        {
            get { return work_place; }
            set { work_place = value; }
        }

        public override string Print_info()
        {
            return base.Print_info() + " место работы" + work_place + "\n";
        }

        public override double ZP()
        {
            return base.ZP();
        }
    }

    class Engineer : Employee
    {
        int kvalification;

        public Engineer(string surname, string name, string patronymic, string sex, int age, int experience, int kvalification)
            : base(surname, name, patronymic, sex, age, experience)
        {
            this.kvalification = kvalification;
        }

        public int Kvalification
        {
            get { return kvalification; }
            set { kvalification = value; }
        }

        public override string Print_info()
        {
            return base.Print_info() + " квалификация" + kvalification + "\n";
        }

        public override double ZP()
        {
            return base.ZP();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
