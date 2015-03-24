using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var list = new List<int> { 1,2,3,4};
            foreach(int elem in ExtensionMethod.Iterator(list,x=>x%2==1))
            {
                Console.WriteLine(elem);
            }
            var list1 = new List<char> { 'a','b', 'c', 'd' };
            foreach (char elem in ExtensionMethod.Iterator(list1, x => x.CompareTo('a')==0))
            {
                Console.WriteLine(elem);
            }
            var list2 = new List<double> {1.2,2.5,6.3,7.7,2.6,1.0 };
            foreach (double elem in ExtensionMethod.Iterator(list2, 1, 6, x => { return x + 1; }))
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
        }
    }
}
