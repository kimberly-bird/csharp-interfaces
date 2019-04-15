namespace flowers_interfaces
{
    public interface IMothersDay
    {
        string ArrangementName { get; set; }

        string Name { get; set; }

        // note: method logic does not go in the interface itself. You can define methods here, but create the logic in another class (see Rose and Sunflower classes below).
        void TrimStems();
    }
}