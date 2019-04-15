using System;

namespace flowers_interfaces
{
    public class Hydrangea : IBirthday
    {
        public string Name { get; set; }
        public string ArrangementName { get; set; } = "Birthday";
    }

}
