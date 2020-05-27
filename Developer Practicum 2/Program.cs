using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Developer_Practicum_2
{
    class Program
    {
        protected class Dishes
        {
            public string dishtype {get; set;}
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = "" ;

            string[] outputarray = new string[4];
            int arraycounter = 0;
            int dishcount1 = 0;
            int dishcount2 = 0;
            int dishcount3 = 0;
            int dishcount4 = 0;

            List<Dishes> dishlist = new List<Dishes>();

            var inputarray = input.Split(',');

            

            if (inputarray[0] == "morning")
            {
                inputarray.Skip(1);
                foreach (string item in inputarray)
                {
                    dishlist.Add(new Dishes {
                        dishtype = item
                    });
                }

                var result = dishlist.GroupBy<dishtype>;

                // group array

                foreach (var item in inputarray)
                {
                    switch (item)
                    {
                        case "1":
                            //output = "Eggs";
                            outputarray[arraycounter] = "Eggs";
                            arraycounter++;
                            dishcount1++;
                            break;

                        case "2":
                            //output = "Toast";
                            outputarray[arraycounter] = "Toast";
                            arraycounter++;
                            dishcount2++;
                            break;

                        case "3":
                            //output = "Coffee";
                            outputarray[arraycounter] = "Coffee";
                            arraycounter++;
                            dishcount3++;
                            break;

                        case "4":
                            //output = "Error";
                            outputarray[arraycounter] = "Error";
                            arraycounter++;
                            dishcount4++;
                            break;
                    }
                }
            }
            else if (inputarray[0] == "night")
            {
                inputarray.Skip(1);

                //group array

                foreach (var item in inputarray)
                {
                    switch (item)
                    {
                        case "1":
                            //output = "Steak";
                            outputarray[arraycounter] = "Steak";
                            arraycounter++;
                            dishcount1++;
                            break;

                        case "2":
                            //output = "Potato";
                            outputarray[arraycounter] = "Potato";
                            arraycounter++;
                            dishcount2++;
                            break;

                        case "3":
                            //output = "Wine";
                            outputarray[arraycounter] = "Wine";
                            arraycounter++;
                            dishcount3++;
                            break;

                        case "4":
                            //output = "Cake";
                            outputarray[arraycounter] = "Cake";
                            arraycounter++;
                            dishcount4++;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No available menu");
            }

            Console.WriteLine(String.Join(", ",outputarray));
        }
    }
}
