using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class4.Generics.Enteties
{
    public class NonGenericHelper
    {

        public void GoTroughList (List<string> strings)
        {
            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        public void GetInfoForList(List<string> strings)
        {
            Console.WriteLine($"List has {strings.Count}  and the elements are of type {strings[0].GetType()}");
        }


        public void GoTroughList(List<int> integers)
        {
            foreach (int i in integers)
            {
                Console.WriteLine(i);
            }
        }

        public void GetInfoForList(List<int> integers)
        {
            Console.WriteLine($"List has {integers.Count}  and the elements are of type {integers[0].GetType()}");
        }

    }
}
