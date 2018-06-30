using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BL
{
    public class PersonBR : IPerson
    {
        Person p = new Person();
        public Person GetSinglePerson(int id)
        {
            p.ID = id;
            p.Name = "Adolf Hiller";
            return p;
        }
    }
}
