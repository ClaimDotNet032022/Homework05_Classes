using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    
    public class Cat : Animal
    {
        public Cat()
        {

        }
        public override string Speak()
        {
            return "meow!";
        }
        public override string Species { get; set; } = "cat";
       
    }
    



}
