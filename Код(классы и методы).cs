using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Client
    {
        public int ClientID;
        public string last_name;
        public string fist_name;
        public string middle_name;
        public string pasport;
        public string phone;
        private int Paid = 0;

        public void Photo_Before()
        {
            Console.WriteLine("Пожалуйста, отправте отчет о состоянии автомобиля перед началом поездки");
        }
        public void Booking()
        {
            if (string.IsNullOrEmpty(last_name))
            {
                throw new ArgumentNullException("Это поле не может быть пустым");
            }
            if (string.IsNullOrEmpty(fist_name))
            {
                throw new ArgumentNullException("Это поле не может быть пустым");
            }
            if (string.IsNullOrEmpty(middle_name))
            {
                throw new ArgumentNullException("Это поле не может быть пустым");
            }
            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentNullException("Это поле не может быть пустым");
            }
        }
        public void StopTime()
        {
            Console.WriteLine("Поездка была приостановлена");
        }
        public void Photo_After()
        {
            Console.WriteLine("Пожалуйста, отправте отчет о состоянии автомобиля перед завершением аренды");
        }

    }
    public class Colleague
    {
        public int ColleagueID;
        public string last_name;
        public string fist_name;
        public string middle_name;
        public string phone;

        public void Repair()
        {
            Console.WriteLine("Автомобиль был принят в ремонт");
        }
        public void TypeWork()
        {
            Console.WriteLine("Покраска переднего бампера");
        }
        public void Term()
        {
            Console.WriteLine("Время починки: 30 минут");
        }
        public void Agreement()
        {
            Console.WriteLine("Договор о назначении ремонта автомобиля подписан");
        }
        public void Giving()
        {
            Console.WriteLine("Автомобиль был выдан на прокат");
        }
    }
    public class Cars
    {
        public int CarId;
        public int GosNumber;
        public string model;
        public string color;
        public int cost_hour;
        public int speed = 0;

        public void GPS()
        {
            Console.WriteLine("Место аварии автомобиля: 55.33544,85.54577");
        }
        public void Fuel()
        {
            Console.WriteLine("Объем топлива 20 литор");
        }
        public void Speed()
        {
            if (speed > 80)
            {
                Console.WriteLine("Привышение скорости в зоне действия знака 'Движение больше 80км/ч запрещено'");
            }
        }
        public void Inclusion()
        {
            Console.WriteLine("Автомобиль заведен");
        }
        public void Accumulator()
        {
            Console.WriteLine("Заряд аккумулятор 90%");
        }
    }
    public class Orders
    {
        public int OrderID;
        public int CarsID;
        public int ColleagueIDD;
        public int ClientID;
        public string stat_time;
        public string end_time;
        public string start_place;
        public string finish_place;
        public string defect;
        private int Amount = 0;
        public void TTIME()
        {
            Console.WriteLine("Текущее время поездки: 00:50:12");
        }
        public void Cost()
        {

            Console.WriteLine("Текущая стоимость поездки: 205Р.");
        }
        public void Promocode()
        {
            if (Amount > 700)
            {
                Console.WriteLine("Спасибо за поездку! Введите: 6HGDG5G, и получите скидку за поездку");
            }
        }
        public void Place()
        {
            Console.WriteLine("Место завершения поездки");
        }
    }
    public class Maintenance_Service
    {
        public int repairID;
        public int ColleagueID;
        public int CarsID;
        public string take_time;
        public string recoil_time;
        public string repair_work;
        public void remont()
        {
            Console.WriteLine("Стоимость ремонта составляет: 20000Р.");
        }
        public void TypeWorkk()
        {
            Console.WriteLine("Работа по технической части");
        }
        public void Malfunction()
        {
            Console.WriteLine("Замена передних колодок и заднего фонаря");
        }
        public void Date_Issue()
        {
            Console.WriteLine("Дата выдачи автомобиля: 09.07.2021");
        }
        public void Signature()
        {
            Console.WriteLine("Договор о выдаче автомобиля подписан");
        }
    }
}
