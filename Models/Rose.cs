using System;

namespace flowers_interfaces
{
    public class Rose : IMothersDay
    {
        public string Name { get; set; } = "Rose";
        public bool Thorny { get; set; } = true;
        public string ArrangementName { get; set; } = "Mother's Day";

        // this is a method that is unique to a rose
        public void removeThorns()
        {
            Thorny = false;
        }

        // this method must be implemented in some way in the Rose class because Rose is using the IMothersday interface, which has defined a TrimStems() method. 
        public void TrimStems()
        {
            Console.WriteLine("You trimmed the Rose's stem!");
        }
    }
}
