using System;

namespace HomeWork_09_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // тип Имя = new Конструктор (параметры);
            Rocket rocket = new Rocket("реактивный", 90, 1800, "жидкий метан", "космический");
            Console.WriteLine();
            Rocket.diameter++;
            Console.WriteLine(Rocket.diameter);
            Rocket.netWeight++;
            Console.WriteLine(Rocket.netWeight);

            var RocketDiameter = Rocket.GetRocketDiametr();

            //Rocket[] rockets = { new Rocket(), new Rocket() };
            //Array.Resize(ref rokets, 5);


        }
    }
    
    public partial class Roket
    {
        public void ParseTextToInt(string text)
        { 
            
        }           
         
    } 
}
