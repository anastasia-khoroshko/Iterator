using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public static class ExtensionMethod
    {
        public static IEnumerable<T> Iterator<T>(this IEnumerable<T> list, Func<T, bool> comparer)
        {
            if (Object.ReferenceEquals(list, null) || Object.ReferenceEquals(comparer, null)) throw new ArgumentNullException();
            foreach (T elem in list)
            {
                if (comparer(elem))
                    yield return elem;
            }
        }

        public static IEnumerable<T> Iterator<T>(this IEnumerable<T> list,int from=0,int to=100,Func<int,int> comparer)
        {
            if (Object.ReferenceEquals(list, null) || Object.ReferenceEquals(comparer, null)) throw new ArgumentNullException();
            T[] a=list.ToArray<T>();
            for(int i=from;i<=to;i++)
            {
                if (to > a.Length||to<from) throw new IndexOutOfRangeException();
                yield return a[i];
                i = comparer(i);
            }
        }
    }
}
