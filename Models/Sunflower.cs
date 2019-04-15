using System;

namespace flowers_interfaces
{
    public class Sunflower : IMothersDay
    {
        public string Name { get; set; } = "Sunflower";
        public bool Seeds { get; set; } = true;
        public string ArrangementName { get; set; } = "Mother's Day";

        // notice how this method also implements the TrimStems() method, but the Console.WriteLine is different from Rose. The logic can be different for each class's "version" of the TrimStems() method.
        public void TrimStems()
        {
            Console.WriteLine("You trimmed the Sunflowers's stem!");
        }
    }
}
