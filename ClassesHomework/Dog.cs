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

        public string Speak(string bark)
        {
            return bark;
        }

        //public bool Sit()
        //{
        //    IsSitting = true;
        //    return IsSitting;
        //}

        //public bool Stand()
        //{
        //    IsSitting = false;
        //    return IsSitting;
        //}

        //public int CelebrateBirthday()
        //{
        //    //Age = ++Age;
        //    this.Age = Age + 1;
        //    return Age;
        //}


        public string Breed { get; private set; }

        //public override int Age { get; set; }

        //public bool IsSitting { get; private set; } = false;
        
        public override string Species { get; set; } = "dog";
   
    }

}
