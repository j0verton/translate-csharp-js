using System;
using System.Collections.Generic;

namespace csharp
{
    // Define class here
    public class GuestList
    {
        private string _name;
        public List<Guest> Guests { get; set; } = new List<Guest>();

        public void AddAGuest(Guest guest)
        {
            this.Guests.Add(guest);
        }

        public GuestList(string name)
        {
            _name = name;
        }

        public PrintGuestList()
        {
            Console.WriteLine($"{name}");
            Console.WriteLine("---------------");
            foreach (Guest guest in this.Guests)
            {
                guest.PrintGuest();
            }
        }

    }
}