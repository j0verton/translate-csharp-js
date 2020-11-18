using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GuestList AllGuests = new GuestList("All the Guests");
            GuestList TableOne = new GuestList("Table 1");
            GuestList TableTwo = new GuestList("Table 2");

            AllGuests.AddAGuest = new Guest("Marilyn Monroe", "entertainer", "(1926 - 1962) American actress, singer, model");
            AllGuests.AddAGuest = new Guest("Abraham Lincoln", "politician", "(1809 - 1865) US President during American civil war");
            AllGuests.AddAGuest = new Guest("Martin Luther King", "activist", "(1929 - 1968)  American civil rights campaigner");
            AllGuests.AddAGuest = new Guest("Rosa Parks", "activist", "(1913 - 2005)  American civil rights activist");
            AllGuests.AddAGuest = new Guest("Peter Sellers", "entertainer", "(1925 - 1980) British actor and comedian");
            AllGuests.AddAGuest = new Guest("Alan Turing", "computer scientist", "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world");
            AllGuests.AddAGuest = new Guest("Admiral Grace Hopper", "computer scientist", "(1906–1992) – developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds");
            AllGuests.AddAGuest = new Guest("Indira Gandhi", "politician", "(1917 - 1984) Prime Minister of India 1966 - 1977");

            foreach (Guest guest in AllGuests)
            {
                List<string> TableOneOccupations = new List();

                foreach (Guest guest in TableOne)
                {
                    TableOneOccupations.add(guest.Occupation);
                }
                foreach (Guest guest in AllGuests)
                {
                    if (TableOneOccupations.includes(guest.Occupation))
                    {
                        TableTwo.AddAGuest(guest);
                    }
                    else
                    {
                        TableOne.AddAGuest(guest);
                    }
                }

            }

            TableOne.PrintGuestList();
            TableTwo.PrintGuestList();


        }
    }
}
