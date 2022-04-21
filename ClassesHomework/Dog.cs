using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your dog class here.
    public class Dog : Animal
    {
        //
        public Dog()
        {

        }
        public Dog(string breed)
        {
            Breed = breed;

        }
        public Dog(int age)
        {
            Age = age;

        }
        public Dog(string breed, int age)
        {
            Breed = breed;
            Age = age;

        }
        public override string Speak()
        {
            return "woof!";
        }
        public string Speak(string userinput)
        {
            return userinput;
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

        //Properties of the dog
        public string Breed { get; private set; }
        public int Age { get; private set; } = 1;
        public bool IsSitting { get; private set; } = false;
        public override string Species { get; set; } = "dog";

    }
}
