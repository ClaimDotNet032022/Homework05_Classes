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
        public Cat()
        {

        }

        public override string Species { get; set; } = "cat";

        public override string Speak()
        {
            return "Meow!";
        }

    }

}
