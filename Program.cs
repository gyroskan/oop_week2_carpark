using System;

namespace parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking(25, null);
            for (int i = 0; i < 24; i++)
            {
                Customer cust = new Customer($"customer{i + 1}", i, "", i + 1);
                parking.enter(cust);
            }
            parking.getDayReceipts();
        }
    }
}
