using System;
using students;
using readers;


class Lab_4
{
    public static void Main(string[] args)
    {

        students.Student[] students = new students.Student[]
       {
            new students.Student("Иванов И.И.", 101, 20),
            new students.Student("Петров П.П.", 102, 21),
            new students.Student("Сидоров С.С.", 103, 19)
       };

        readers.Reader[] readers = new readers.Reader[]
        {
            new readers.Reader("Иванов И.И.", 1001, "Факультет 1", ("22.02.2003"), 89297946428),
            new readers.Reader("Петров П.П.", 1002, "Факультет 2",  ("24.07.2001"), 89273416615),
            new readers.Reader("Сидоров С.С.", 1003, "Факультет 3",  ("06.06.2008"), 89995100310)
        };

        Console.WriteLine("Информация о студентах:");
        foreach (var student in students)
        {
            student.PrintInfo();
        }

        Console.WriteLine("\nИнформация о читателях:");
        foreach (var reader in readers)
        {
            reader.PrintInfo();
        }

        readers[0].TakeBook(3);
        readers[0].TakeBook("Приключения", "Словарь", "Энциклопедия");
        

        readers[1].ReturnBook(2);
        readers[1].ReturnBook("Роман", "Детектив");

        readers[2].ReturnBook(2);
        readers[2].ReturnBook("Повести", "Сборник стихов");

    }
}

namespace students
{
    class Student
    {
        string fio;
        int numGroup;
        private int age;
        public Student(string fio, int numGroup, int age){
            this.fio = fio;
            this.numGroup = numGroup;
            this.age = age;
            }
        public void PrintInfo() => Console.WriteLine($"ФИО: {fio} Группа: {numGroup} Возраст: {age}\n");
    }
}
namespace readers
{
    class Reader
    {
        private string FIO;
        int numTicket;
        string facultet;
        private string birthday;
        long number;
        public Reader( string FIO, int numTicket, string facultet, string birthday, long number) {
            this.FIO = FIO; 
            this.numTicket = numTicket;
            this.facultet = facultet;
            this.birthday = birthday;
            this.number = number;
        }

        public void PrintInfo() =>
        
            Console.WriteLine($"Читатель: {FIO}, Номер читательского билета: {numTicket}, Факультет: {facultet}, Дата рождения: {birthday}, Телефон: {number}\n");
        

        public void TakeBook(int count)
        {
            Console.WriteLine($"{FIO} взял {count} книги\n");
        }

        public void TakeBook(params string[] bookTitles)
        {
            Console.WriteLine($"{FIO} взял книги: {string.Join(", ", bookTitles)}\n");
        }

        public void ReturnBook(int count)
        {
            Console.WriteLine($"{FIO} вернул {count} книги\n");
        }

        public void ReturnBook(params string[] bookTitles)
        {
            Console.WriteLine($"{FIO} вернул книги: {string.Join(", ", bookTitles)}\n");
        }
    }
}