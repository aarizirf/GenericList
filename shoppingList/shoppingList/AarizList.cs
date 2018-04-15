using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    class AarizList
    {
        string[] list;
        //make a constructor with any loading logic you need
        public AarizList()
        {
            list = new string[0];
        }

        //add function
        public void Add(string item)
        {
            string[] temporary = new string[list.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                temporary[i] = list[i];
            }
            temporary[temporary.Length - 1] = item;

            list = temporary;
        }

        //remove function
        public void Remove(string item)
        {
            string[] temporary = new string[list.Length - 1];
            int counter = 0;

            for (int i = 0; i < temporary.Length; i++)
            {
                if (list[i] == item)
                {
                    counter++;
                }

                temporary[i] = list[counter];
                counter++;

            }

            list = temporary;
        }

    }
}
