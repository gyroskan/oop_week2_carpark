namespace parking
{
    public class Customer
    {
        public string Name { get; }
        public long ID { get; }
        public string LicensePlate { get; }

        // useless for this exercise
        public float Arrival_time { get; set; }

        public int Hours { get; }

        public Customer(string _name, long _ID, string _licensePlate, int _hours)
        {
            Name = _name;
            ID = _ID;
            LicensePlate = _licensePlate;
            Hours = _hours;
        }

        public float calculateCharges()
        {
            if (Hours <= 3)
                return 2f;

            if (Hours >= 19)
                return 10;

            return 2 + (Hours - 3) * 0.5f;
        }
    }
}