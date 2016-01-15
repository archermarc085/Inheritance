using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        protected Coordinate coordinates = null;
        protected int speed = 0;
        protected int price = 0;
        protected string name = "";
        protected DateTime yearOfIssue;

        public Vehicle(string name, int x, int y, int speed, int price, DateTime yearOfIssue)
        {
            this.name = name;
            coordinates = new Coordinate(x, y);
            this.speed = speed;
            this.price = price;
            this.yearOfIssue = yearOfIssue;
        }
        public virtual void Information()
        {
            Console.WriteLine(@"Имя: {0} 
Координаты: ({1};{2})
Скорость: {3}km/h
Цена: {4}$
Год выпуска: {5}", name, coordinates.X, coordinates.Y, speed, price, yearOfIssue);
        }
    }
    class Plane : Vehicle
    {
        int height = 0;
        int numberOfPassengers = 0;

        public Plane(string name, int x, int y, int speed, int price, DateTime yearOfIssue, int height, int numberOfPassengers)
            : base(name, x, y, speed, price, yearOfIssue)
        {
            this.height = height;
            this.numberOfPassengers = numberOfPassengers;
        }
        public override void Information()
        {
            base.Information();
            Console.WriteLine(@"Высота: {0} km
Кол-во пассажиров: {1}", height, numberOfPassengers);
        }

    }
    class Car : Vehicle
    {
        public Car(string name, int x, int y, int speed, int price, DateTime yearOfIssue)
            : base(name, x, y, speed, price, yearOfIssue)
        {

        }
    }
    class Ship : Vehicle
    {
        string portOfRegistration = "";
        int numberOfPassengers = 0;

        public Ship(string name, int x, int y, int speed, int price, DateTime yearOfIssue, int numberOfPassengers, string portOfRegistration)
            : base(name, x, y, speed, price, yearOfIssue)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.portOfRegistration = portOfRegistration;
        }
        public override void Information()
        {
            base.Information();
            Console.WriteLine(@"Порт: {0} 
Кол-во пассажиров: {1}", portOfRegistration, numberOfPassengers);
        }
    }
}