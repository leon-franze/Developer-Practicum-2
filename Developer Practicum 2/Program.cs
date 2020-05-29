using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Developer_Practicum_2
{
    public class Program
    {
        protected class Dishes
        {
            public string Dishtype {get; set;}
        }
        public class Waiter {
            public string processOrder(string input)
            {
                var outputlist = new List<string>();

                List<Dishes> dishlist = new List<Dishes>();

                var inputarray = input.Split(',');



                if (inputarray[0] == "morning")
                {
                    inputarray = inputarray.Skip(1).ToArray();
                    foreach (string item in inputarray)
                    {
                        dishlist.Add(new Dishes
                        {
                            Dishtype = item
                        });
                    }

                    //var result = dishlist.GroupBy<dishtype>;

                    var result = from dish in dishlist
                                 group dish by dish.Dishtype into groupedDisches
                                 orderby groupedDisches.Key
                                 select new { Count = groupedDisches.Count(), Type = groupedDisches.Key };

                    var result2 = dishlist.GroupBy(dishes => dishes.Dishtype)
                                          .OrderBy(group => group.Key)
                                          .Select(group => new { Count = group.Count(), Type = group.Key });


                    // group array

                    foreach (var item in result)
                    {
                        switch (item.Type)
                        {
                            case "1":
                                //output = "Eggs";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Eggs(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Eggs");
                                }
                                break;

                            case "2":
                                //output = "Toast";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Toast(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Toast");
                                }
                                break;

                            case "3":
                                //output = "Coffee";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Coffee(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Coffee");
                                }
                                break;

                            case "4":
                                //output = "Error";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Error(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Error");
                                }
                                break;
                        }
                    }
                }
                else if (inputarray[0] == "night")
                {
                    inputarray = inputarray.Skip(1).ToArray();
                    foreach (string item in inputarray)
                    {
                        dishlist.Add(new Dishes
                        {
                            Dishtype = item
                        });
                    }

                    var result = from dish in dishlist
                                 group dish by dish.Dishtype into groupedDisches
                                 orderby groupedDisches.Key
                                 select new { Count = groupedDisches.Count(), Type = groupedDisches.Key };
                    //group array

                    foreach (var item in result)
                    {
                        switch (item.Type)
                        {
                            case "1":
                                //output = "Steak";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Steak(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Steak");
                                }
                                break;

                            case "2":
                                //output = "Potato";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Potato(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Potato");
                                }
                                break;

                            case "3":
                                //output = "Wine";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Wine(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Wine");
                                }
                                break;

                            case "4":
                                //output = "Cake";
                                if (item.Count >= 2)
                                {
                                    outputlist.Add("Cake(x" + item.Count.ToString() + ")");
                                }
                                else
                                {
                                    outputlist.Add("Cake");
                                }
                                break;
                        }
                    }
                }
                else
                {
                    return "No available menu";
                }

                return String.Join(", ", outputlist);

            }
        }
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var waiter = new Waiter();

            string output = waiter.processOrder(input);

            Console.WriteLine(String.Join(", ",output));
        }
    }
}
