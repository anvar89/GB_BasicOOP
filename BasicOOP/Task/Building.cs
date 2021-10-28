using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Building
    {
        private int id;
        private int numberOfFloors;
        private int numberOfFlats;
        private int numberOfEntrance;
        private int flatPerFloor;
        private double heightBuilding;
        private double heightFloor;



        private static int lastId;

        public int Id { get => id; set => id = value; }
        public double HeightBuilding { get => heightBuilding; }
        public int NumberOfFloors { get => numberOfFloors; }
        public int NumberOfFlats { get => numberOfFlats; }
        public int NumberOfEntrance { get => numberOfEntrance; }
        public int FlatPerFloor { get => flatPerFloor = CalculateFlatsPerFloor(); }
        public double HeightFloor { get => heightFloor = CalculateHeightOfFloor(); }

        private int GetUniqueId() => ++lastId;

        private int CalculateFlatsPerFloor() => numberOfFlats / numberOfFloors;

        private double CalculateHeightOfFloor() => heightBuilding / Convert.ToDouble(numberOfFloors);

        public override string ToString()
        {
            return $"Индентификатор здания: {Id}/n" +
                $"Высота здания: {HeightBuilding} м/n" +
                $"Высота этажа: {heightFloor} м/n" +
                $"Всего квартир: {numberOfFlats}/n" +
                $"Квартир на этаж: {flatPerFloor}/n" +
                $"Количество подъездов: {numberOfEntrance}";
        }

    }
}
