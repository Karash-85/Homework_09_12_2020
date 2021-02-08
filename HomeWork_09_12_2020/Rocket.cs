using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_09_12_2020
{
    public partial class Rocket
    {
        // Характеристики - полями
        // модификаторы доступа \\ доп. модификаторы \\ тип имяПоля
        private string _engine; // Двигатель
        private int _proportions; // Габариты
        private double _parameters; // Скорость полета
        private string _fuelType; // Тип топлива
        private string _rocketType; // Тип ракеты - в зависимости от назначения, космические, грузовые, военные
        public static int diameter = 50; // диаметр ракеты
        public static int netWeight = 150; // вес ракеты без груза


        // Конструктор  / Мод.доступа  имяКласса(параметры) {тело;}
        public Rocket(string engine, int proportions, double parameters, string fuelType, string rocketType)
        {
            _engine = engine;
            _proportions = proportions;
            _parameters = parameters;
            _fuelType = fuelType;
            _rocketType = rocketType;
        }
        public static int GetRocketDiametr()
        {
            return diameter;
        }

        // Методы доступа к полям (геттеры и сеттеры)
        // мод. доступа возвр. тип имяМетода (параметры)
        // { тело; returne значение (опционально); }
        public string GetEngine(string engine)
        {
            return engine;
        }
        public void SetProportions(int proportions)
        {
            _proportions = proportions;
        }
        public void SetParameters(double parameters)
        {
            _parameters = parameters;
        }
        

    }
}
