using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    // Write your Cat class here
    public class Cat : Animal
    {
        public override string Species { get; } = "cat";

        public override string Speak()
        {
            return "meow!";
        }
    }

}
