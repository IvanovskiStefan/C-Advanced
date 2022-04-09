using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.Polymorhism.Entities
{
    public class Dog : Pet
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }
            public override void Eat()
        {
            Console.WriteLine("The dog is eating");       
        }

        public Dog() :base("Sharko")
        {

        }
        public Dog(string name) :base(name)
        {

        }

        
    
    }

      
    
}
