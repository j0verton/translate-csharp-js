using System;
using System.Collections.Generic;

namespace csharp
{
    // Define class here
    public class Guest
    {
        private string _name;
        private string _occupation;
        private string _bio;

        public Guest(string name, string occupation, string bio)
        {
            _name = name;
            _occupation = occupation;
            _bio = bio;

        }

        public void PrintGuest()
        {
            Console.WriteLine($"{this._name} ({this._occupation}) {this._bio}");
        }
    }
}