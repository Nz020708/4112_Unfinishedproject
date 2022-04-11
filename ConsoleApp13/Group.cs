using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Group
    {
        List<Student> students = new List<Student>();
        public string No { get; set; }
       
        public Category categories;
        public bool isOnline { get; set; }
        public int Limit { get; set; }
        public static int BP = 100;
        public static int DB = 100;
        public static int SA = 100;
       
        public Group(Category category, bool isonline)
        {
            isOnline = isonline;
            switch (category)
            {
                case Category.Programming:

                    No = $"BP{BP}";
                    BP++;
                  break;
                case Category.Design:
                    No = $"DB{DB}";
                    break;
                case Category.SystemAdministration:
                    No = $"SA{SA}";
                    break;
                default:
                    Console.WriteLine("Bele bir qrup yoxdur.");
                    break;
            }
            categories = category;
        }

    }
}
