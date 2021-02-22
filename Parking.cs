using System.Collections.Generic;
using System;

namespace parking
{
    public class Parking
    {
        private int MaxCars { get; }
        private List<Customer> customers;

        public Parking(int _maxCars, List<Customer> _customers)
        {
            MaxCars = _maxCars;
            customers = _customers != null ? _customers : new List<Customer>();
        }

        public void getDayReceipts()
        {
            float total = 0f;
            foreach (Customer cust in customers)
            {
                float price = cust.calculateCharges();
                Console.WriteLine($"{cust.Name} parked for {cust.Hours} hours and paid {price}€!");
                total += price;
            }

            Console.WriteLine($"Yesterday, the parking made {total}€ with {customers.Count} customers!");
        }

        public bool enter(Customer customer)
        {
            if (customers.Count >= this.MaxCars)
                return false;
            customers.Add(customer);
            return true;
        }

        public void leave(long ID)
        {
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].ID == ID)
                {
                    customers.RemoveAt(i);
                    break;
                }
            }
        }
    }
}