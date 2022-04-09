﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class3.Polymorhism.Entities
{
    public abstract class Pet
    {
        public string Name { get; set; }


        public Pet(string name)
        {
            Name = name;
        }
        
        public abstract void Eat(); 


        
    }
}
