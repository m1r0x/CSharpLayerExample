using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using BL;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonBR brperson = new PersonBR();

            Person p = brperson.GetSinglePerson(5);

            Console.WriteLine(p.ID);
            Console.WriteLine(p.Name);
            Console.ReadKey();
        }
    }
}
