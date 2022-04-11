using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Generics.Enteties
{
    public class GenericDB<T> where T : BaseEntity 
    {
            private List<T> items;

        public GenericDB()
        {
            items = new List<T>();
        }


        public void Add(T item)
        {
            items.Add(item);
            Console.WriteLine($"New item of type{typeof(T)} was added!");
        }

        public void PrintInfo()
        {
            foreach(T item in items)
            {
                item.PrintInfro();
            }  

        }


        public void DeleteItem(T itemToDelete)
        {
            T item = items.FirstOrDefault( x => x == itemToDelete);
            
            if(item != null)
            {
                items.Remove(item);
                Console.WriteLine($" Item with ID {item.Id} was deleted!");
            }

            else
            {
                Console.WriteLine("The item was not found");
            }
        }

        public void DeleteItemByID(int id)
        {
            T item = items.FirstOrDefault(x => x.Id == id);
            items.Remove(item);

        }

    }
}
