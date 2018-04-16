using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    class AarizList<T> where T : IComparable<T> 
    {
        T[] list;
        //make a constructor with any loading logic you need
        public AarizList()
        {
            list = new T[0];
        }

        //add function
        public void Add(T item)
        {
            T[] temporary = new T[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                temporary[i] = list[i];
            }
            temporary[temporary.Length - 1] = item;

            list = temporary;
        }

        //remove function
        public void Remove(T item)
        {
            T[] temporary = new T[list.Length - 1];
            int counter = 0;

            for (int i = 0; i < temporary.Length; i++)
            {
                if (list[i].CompareTo(item) == 0)
                {
                    counter++;
                }

                temporary[i] = list[counter];
                counter++;

            }

            list = temporary;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }


    }
}
