using System;
using System.Linq;

namespace Developer_Practicum_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "" ;
            var inputarray = input.Split(',');

            if (inputarray[0] == "morning")
            {
                inputarray.Skip(1);
                foreach (var item in inputarray)
                {
                    switch (item)
                    {
                        case "1":
                            output = output + ", Eggs";
                        break;

                        case "2":
                            output = output + ", Toast";
                        break;

                        case "3":
                            output = output + ", Coffee";
                        break;

                        case "4":
                            output = output + ", Error";
                        break;
                    }
                }
            }
            else if (inputarray[0] == "night")
            {
                inputarray.Skip(1);
                foreach (var item in inputarray)
                {
                    switch (item)
                    {
                        case "1":
                            output = output + ", Steak";
                            break;

                        case "2":
                            output = output + ", Potato";
                            break;

                        case "3":
                            output = output + ", Wine";
                            break;

                        case "4":
                            output = output + ", Cake";
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No available menu");
            }

            Console.WriteLine(output);
        }
    }
}
