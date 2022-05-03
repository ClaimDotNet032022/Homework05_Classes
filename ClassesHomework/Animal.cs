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
        //public string Species { get; protected set; } = "unknown";

        public virtual string Species { get; } = "unknown";

        public int Age { get; protected set; } = 1;
        public bool IsSitting { get; private set; }


        public virtual string Speak()
        {
            return "What am I?";
        }

        public void Sit()
        {
            IsSitting = true;
        }

        public void Stand()
        {
            IsSitting = false;
        }

        public void CelebrateBirthday()
        {
            //Age = Age + 1;
            //Age += 1;
            //Age++;
            ++Age;
        }

    }
}
