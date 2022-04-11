using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<Student> group = new Group<Student>();
           
           
            Console.WriteLine("Ashagidakilardan birini sec:");
            int processes = Convert.ToInt32(Console.ReadLine());
            switch (processes)
            {
                case 1:
                    Console.WriteLine("1.Yeni qrup yarat:");
                    string info = Console.ReadLine();

                    break;
                case 2:
                    Console.WriteLine("Qruplarin siyahisini goster:");

                    break;
                case 3:
                    Console.WriteLine("Qrup uzerinde duzelish et:");
                    break;
                case 4:
                    Console.WriteLine("Qrupdaki telebelerin siyahisini goster.");
                    break;
                case 5:
                    Console.WriteLine("Butun telebelerin siyahisini goster:");
                    break;
                case 6:
                    Console.WriteLine("Telebe yarat:");
                    break;
                default:
                    break;
            }
        }
    }
}
