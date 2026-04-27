using System;
using System.Collections.Generic;

namespace ConsoleApp_FirstApp
{
    /// <summary>
    /// Главный класс приложения.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Galaxy News!");
            IterateThroughList();
            Console.ReadKey();
        }

        /// <summary>
        /// Создает список галактик и выводит информацию о них в консоль.
        /// </summary>
        private static void IterateThroughList()
        {
            var theGalaxies = new List<Galaxy>
            {
                new Galaxy() { Name="Tadpole", MegaLightYears=400, GalaxyType=new GType('S')},
                new Galaxy() { Name="Pinwheel", MegaLightYears=25, GalaxyType=new GType('S')},
                new Galaxy() { Name="Cartwheel", MegaLightYears=500, GalaxyType=new GType('L')},
                new Galaxy() { Name="Small Magellanic Cloud", MegaLightYears=.2, GalaxyType=new GType('I')},
                new Galaxy() { Name="Andromeda", MegaLightYears=3, GalaxyType=new GType('S')},
                new Galaxy() { Name="Maffei 1", MegaLightYears=11, GalaxyType=new GType('E')}
            };

            foreach (Galaxy theGalaxy in theGalaxies)
            {
                Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears + ",  " + theGalaxy.GalaxyType.MyGType);
            }

            // Expected Output:
            //  Tadpole  400,  Spiral
            //  Pinwheel  25,  Spiral
            //  Cartwheel, 500,  Lenticular
            //  Small Magellanic Cloud .2,  Irregular
            //  Andromeda  3,  Spiral
            //  Maffei 1,  11,  Elliptical
        }
    }

    /// <summary>
    /// Модель данных, представляющая галактику.
    /// </summary>
    public class Galaxy
    {
        /// <summary>Название галактики.</summary>
        public string Name { get; set; }

        /// <summary> Расстояние до галактики в миллионах световых лет.
        /// </summary>
        public double MegaLightYears { get; set; }

        /// <summary>Классификация типа галактики.</summary>
        public GType GalaxyType { get; set; }
    }

    /// <summary>
    /// Класс для определения и хранения типа галактики.
    /// </summary>
    public class GType
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса GType.
        /// </summary>
        /// <param name="type"> Символ, обозначающий тип (S, E, I, L).
        /// </param>
        public GType(char type)
        {
            switch (type)
            {
                case 'S':
                    MyGType = Type.Spiral;
                    break;
                case 'E':
                    MyGType = Type.Elliptical;
                    break;
                case 'I':
                    MyGType = Type.Irregular;
                    break;
                case 'L':
                    MyGType = Type.Lenticular;
                    break;
                default:
                    break;
            }
        }

        /// <summary> Установленный тип галактики из перечисления.
        /// </summary>
        public object MyGType { get; set; }

        /// <summary> Внутреннее перечисление доступных типов галактик.
        /// </summary>
        private enum Type { Spiral, Elliptical, Irregular, Lenticular }
    }
}