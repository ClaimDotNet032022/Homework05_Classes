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
            //Age = ++Age;
            this.Age = Age + 1;
            return Age;
        }
        public virtual string Speak()
        {
            return "What am I?";
        }
        public virtual string Species { get; set; } = "unknown";

        public virtual int Age { get; set; } = 1;
        
        public bool IsSitting { get; private set; } = false;
    }

   
}
