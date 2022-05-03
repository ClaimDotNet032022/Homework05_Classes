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
        public string Breed { get; }

        public override string Species { get; } = "dog";

        public Dog(string breed, int age) : this(breed)
        {
            Age = age;
        }

        public Dog(string breed) //: this()
        {
            Breed = breed;
            //Age = 1;
            //Species = "dog";
        }

        public Dog()
        {
            //Age = 1;
            //Species = "dog";
        }



        //public string Speak(string msg = "woof!")
        //{
        //    return msg;
        //}

        public override string Speak()
        {
            return "woof!";
        }

        public string Speak(string msg)
        {
            return msg;
        }


        
    }
}
