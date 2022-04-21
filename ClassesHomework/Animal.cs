using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // write your Animal class here. 
    public class Animal
    {
        public Animal()
        {

        }
        public Animal(string breed)
        {
            Breed = breed;

        }
        public Animal(int age)
        {
            Age = age;

        }
        public Animal(string breed, int age)
        {
            Breed = breed;
            Age = age;

        }
        public bool Sit()
        {
            IsSitting = true;
            return IsSitting;
        }
        public bool Stand()
        {
            IsSitting = false;
            return IsSitting;
        }

        public int CelebrateBirthday()
        {
            Age = ++Age;
            return Age;
        }

        public virtual string Speak()
        {
            return "What am I?";
        }
        public virtual string Species { get; set; } = "unknown";
        public string Breed { get; private set; }
        public int Age { get; private set; } = 1;
        public bool IsSitting { get; set; } = false;

    }

}
