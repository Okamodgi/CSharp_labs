using System;
using System.Diagnostics;

class Lab_3
{
    public static void Main(string[] args)
    {
        Train train1 = new Train ("Москва-Сочи", 2215, "10:00");
        Train train2 = new Train("Москва-Лондон", 2215, "17:30");
        Train train3 = new Train("Пенза-Киров", 2135, "06:00");
        Train train4 = new Train("Краснодар-Казань", 7489, "09:20");
        Train train5 = new Train("Пенза-Стамбул", 1256, "15:40");
        Train train6 = new Train("Москва-Сочи", 9947, "21:20");
        Train train7 = new Train("Пенза-Падуя", 3247, "00:28");


        Train[] trains = { train1, train2, train3, train4, train5, train6, train7 };

        Array.Sort(trains, (x, y) => x.train_num.CompareTo(y.train_num));

        Array.Sort(trains, (x, y) =>
        {
            int destinationComparison = x.destination.CompareTo(y.destination);
            if (destinationComparison != 0)
            {
                return destinationComparison;
            }
            else
            {
                return x.departure_time.CompareTo(y.departure_time);
            }
        });

        Console.WriteLine("Поезда упорядочены по номерам:");
        foreach (Train train in trains)
        {
            train.Info();
        }

        Console.Write("\nВведите номер поезда для получения информации: ");
        int trainNumber = int.Parse(Console.ReadLine());
        Train requestedTrain = Array.Find(trains, train => train.train_num == trainNumber);
        if (requestedTrain != null)
        {
            requestedTrain.Info();
        }
        else
        {
            Console.WriteLine("Поезд с таким номером не найден.");
        }

    }
}
class Train
{
    public string destination;
    public int train_num;
    public string departure_time;

    public Train(string destination, int train_num, string departure_time)
    {
        this.destination = destination;
        this.train_num = train_num;
        this.departure_time = departure_time;
    }

    public void Info()
    {
        Console.WriteLine($"Номер поезда: {train_num}, Пункт назначения: {destination}, Время отправления: {departure_time}");
    }
}