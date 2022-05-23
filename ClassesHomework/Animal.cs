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
        public string Species { get; set; }
        public int Age { get; private set; } = 1;
            //public string Speak { get; set; }
        public bool IsSitting { get; private set; } = false;

        public Animal()
        {
            Species = "unkown";
        }
        public virtual string Speak()
        {
            return "What am I?";
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
            Age = Age++;
            return Age;
        }
    }
    
}