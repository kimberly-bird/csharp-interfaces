using System;

namespace flowers_interfaces
{
    public class Lily : IBirthday
    {
        public string Name { get; set; }
        public int StemThickness { get; set; }
        public string ArrangementName { get; set; } = "Birthday";
    }
}
