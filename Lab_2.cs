using System;

class Lab_2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите номер дня недели: \n" +
            "Понедельник = 1\r\n" +
            "Вторник = 2\r\n" +
            "Среда = 3\r\n" +
            "Четверг = 4\r\n" +
            "Пятница = 5\r\n" +
            "Суббота = 6\r\n" +
            "Воскресенье = 7 ");
        int week = Convert.ToInt32(Console.ReadLine());
        int valWeek = DayOfWeek(week);
        if (valWeek == -1)
            return;

        Console.WriteLine("Введите сколько часов: ");
        int timeHour = Convert.ToInt32(Console.ReadLine());
        int valHour = Times(timeHour);
        if (valHour == -1)
            return;

        Console.WriteLine(" ");

        int timesHour = Times(timeHour);
        
        string weeks = Enum.GetName(typeof(DayOfTheWeek), week);
        string timeOfDay = Enum.GetName(typeof(TimeDay), timesHour);

        Console.WriteLine($"Сейчас {weeks}, {timeOfDay}" );

    }
    public static int Times(int time)
    {
        if (time >= 7 && time <= 12)
        {
            return (int)TimeDay.Утро;
        }
        else if (time >= 13 && time <= 18)
        {
            return (int)TimeDay.День;
        }
        else if (time >= 19 && time <= 23)
        {
            return (int)TimeDay.Вечер;
        }
        else if (time >= 0 && time <= 6) 
        {
            return (int)TimeDay.Ночь;
        }
        else
        {
            Console.WriteLine("Ошибка: некорректное значение времени.");
            return -1;
        }
    }

    public static int DayOfWeek(int day)
    {
        if (day >= 1 && day <= 7)
        {
            return day;
        }
        else
        {
            Console.WriteLine("Ошибка: некорректный номер дня недели.");
            return -1;
        }
    }

    enum DayOfTheWeek : int
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    enum TimeDay : int 
    {
        Утро,
        День,
        Вечер,
        Ночь
    }
}

