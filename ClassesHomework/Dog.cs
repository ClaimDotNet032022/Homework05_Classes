using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your dog class here.
    public class Dog: Animal
    {
        public Dog()
        {
            
        }
        public string Breed { get; private set; }
        public Dog(string Breed)
        {
            this.Breed = Breed;
        }
        public Dog(string Breed, int Age)
        {
            Breed = "breed";
            
        }
        public override string Speak()
        {
            return "Woof!";
        }
        public string Speak(string userInput)
        {
            return userInput;
        }
        public int Speak(int userInput)
        {
            return userInput;
        }

    }

}