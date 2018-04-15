using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //make an array of items that has 3 items in it to start
            //then create a menu for the user to choose what to do
            //1)add to the list
            //2) remove from the list
            //3) view the list
            //4) exit
            AarizList list = new AarizList();
            bool stillRunning = true;
            

            do
            {
                Console.WriteLine("What do you want to do?\n1)Add to the list\n2)Remove from the list\n3)View your list\n4)Exit this program");
                int program = int.Parse(Console.ReadLine());

                switch(program)
                {
                    case 1:
                        Console.WriteLine("Enter the item you would like to add");
                        string item = Console.ReadLine();
                        list.Add(item);
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.WriteLine("Enter the item you would like to remove");
                        item = Console.ReadLine();
                        list.Remove(item);
                        Console.WriteLine(" ");
                        break;
                    case 3:
                        /*for(int i = 0; i < list.Length; i++)
                        {
                            Console.WriteLine(list[i]);
                        } */


                        Console.WriteLine(" ");
                        break;
                    case 4:
                        stillRunning = false;
                        break;
                }
            } while (stillRunning);
        }

        static string[] Add(string[] list, string item)
        {
            string[] temporary = new string[list.Length + 1];
            for(int i = 0; i < list.Length; i++)
            {
                temporary[i] = list[i];
            }
            temporary[temporary.Length - 1] = item;

            return temporary;
        }

        static string[] Remove(string[] list, string item)
        {
            string[] temporary = new string[list.Length - 1];
            int counter = 0;

            for(int i = 0; i < temporary.Length; i++)
            {
                if(list[i] == item)
                {
                    counter++;
                }
               
                temporary[i] = list[counter];
                counter++;
                
            }

            return temporary;
        }
    }
}
