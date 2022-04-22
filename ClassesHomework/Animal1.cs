using System;

namespace ClassesHomework
{
    internal class Animal
    {
        public string Species { get; internal set; }

        public static implicit operator Animal(bool v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Animal(Dog v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Animal(Cat v)
        {
            throw new NotImplementedException();
        }

        internal string Speak()
        {
            throw new NotImplementedException();
        }
    }
}