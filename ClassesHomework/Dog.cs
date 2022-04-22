using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    internal class Dog
    {
        public Dog()
        {
        }

        public Dog(string v)
        {
            V = v;
        }

        public Dog(string v, int v1) : this(v)
        {
        }

        public string Breed { get; internal set; }
        public string V { get; }
        public int Age { get; internal set; }
        public bool IsSitting { get; internal set; }

        internal string Speak()
        {
            throw new NotImplementedException();
        }

        internal string Speak(string v)
        {
            throw new NotImplementedException();
        }

        internal void Sit()
        {
            throw new NotImplementedException();
        }

        internal void Stand()
        {
            throw new NotImplementedException();
        }

        internal void CelebrateBirthday()
        {
            throw new NotImplementedException();
        }
    }
}
