using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.Polymorhism.Entities
{
    public class Cat : Pet
    {
        public int NumberofBalls { get; set; }


        public Cat(string name, int numberofballs) : base(name)
        {
            NumberofBalls = numberofballs;
        }

        public override void Eat()
        {
            Console.WriteLine("The cat is eating");
        }
    

   
        

        
    }
}
