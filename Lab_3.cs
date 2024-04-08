using System;

class Lab_3
{
    public static void Main(string[] args)
    {
        Student student1 = new Student("Купцова Н.М.", 2117, new []{ 5, 4, 5, 4, 5 });
        Student student2 = new Student("Шорников И.Д.", 2121, new[] { 2, 2, 3, 5, 5 });
        Student student3 = new Student("Прокопенко А.А.", 2117, new[] { 5, 4, 4, 4, 5 });
        Student student4 = new Student("Цыка А.А.", 2117, new[] { 5, 5, 4, 4, 5 });
        Student student5 = new Student("Чекушин Н.С.", 2121, new[] { 2, 2, 3, 2, 5 });
        Student student6 = new Student("Титов И.А.", 2121, new[] { 2, 2, 3, 2, 4 });
        Student student7 = new Student("Шевионкова А.П.", 2117, new[] { 5, 5, 4, 4, 5 });

        Student[] students = { student1, student2, student3, student4, student5, student6, student7 };

        Array.Sort(students, (x, y) => x.AverageGrade().CompareTo(y.AverageGrade()));

        foreach (Student student in students)
        {
            student.Info();
        }
    }

}
struct Student
{
    string fio;
    int numGroup;
    int[] grade;

    public Student(string fio, int numGroup, int[] grade)
    {
        this.fio = fio;
        this.numGroup = numGroup;
        this.grade = grade;
    }

    public void Info()
    {
        for (int i = 0; i < grade.Length - 1; i++)
        {
            for (int j = 0; j < grade.Length - i - 1; j++)
            {
                if (grade[j] > grade[j + 1])
                {
                    int temp = grade[j];
                    grade[j] = grade[j + 1];
                    grade[j + 1] = temp;
                }
            }
        }

        int sum = 0;
        foreach (int mark in grade)
        {
            sum += mark;
        }
        double average = (double)sum / grade.Length;

        Console.WriteLine($"Инициалы: {fio}  Группа: {numGroup} Оценки: {string.Join(", ", grade)} Среднее арифметическое: {average} ");
    }
    public double AverageGrade()
    {
        int sum = 0;
        foreach (int mark in grade)
        {
            sum += mark;
        }
        return (double)sum / grade.Length;
    }
}