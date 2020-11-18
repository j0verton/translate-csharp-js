using System;
using System.Collections.Generic;

namespace csharp
{
    // Define class here
    public class Guest
    {
        private string _name;
        public string Occupation { get; set; }
        private string _bio;

        public Guest(string name, string occupation, string bio)
        {
            _name = name;
            Occupation = occupation;
            _bio = bio;

        }

        public void PrintGuest()
        {
            Console.WriteLine($"{this._name} ({this.Occupation}) {this._bio}");
        }
    }
}