using System;
namespace csharp
{
    public class Word
    {
        public string Name;

        public int Number;

        public Word(string name)
        {
            Name = name;
            Number = 1;
        }

        public override string ToString()
        {
            return $"{Name}: {Number}";
        }
    }
}
