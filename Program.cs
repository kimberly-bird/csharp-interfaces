using System;
using System.Collections.Generic;

namespace flowers_interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // when you create a new instance of a flower, it will have two types: type of flower and type of arrangement interface

            // Type: Rose, Interface: IMothersDay
            Rose pinkRose = new Rose();
            // Type: Sunflower, Interface: IMothersDay
            Sunflower yellowSunflower = new Sunflower();
            // Type: Hydrangea, Interface: IBirthday
            Hydrangea blueHydrangea = new Hydrangea();
            // Type: Lily, Interface: IBirthday
            Lily whiteLily = new Lily();

            // This is a list that contains 2 types (Rose and Sunflower) because they both have the same interface of IMothersDay
            List<IMothersDay> mothersdayFlowers = new List<IMothersDay>(){
                pinkRose,
                yellowSunflower
            };

            // Thorny is a property on the Rose class, and is not on the IMothersDay interface, which means that you can only access its value on the class itself.
            Console.WriteLine(pinkRose.Thorny);

            // Because Name is a property on the IMothersDay interface, we can access the Name value from the interface
            mothersdayFlowers.ForEach(flower => Console.WriteLine($"The {flower.Name} is in the Mother's Day arrangement"));

            List<IBirthday> birthdayFlowers = new List<IBirthday>(){
                blueHydrangea,
                whiteLily
            };

            mothersdayFlowers.ForEach(flower => Console.WriteLine($"The {flower.Name} is in the birthday arrangement"));

            // calling some of the methods from the Rose class, Sunflower Class, and IMothersday interface 
            pinkRose.TrimStems();
            yellowSunflower.TrimStems();
            pinkRose.removeThorns();

            // or, if you want to trim all of the stems in a specific list, you can simply foreach over the list of mothersdayFlowers and call that method
            mothersdayFlowers.ForEach(flower => flower.TrimStems());
        }
    }
}
