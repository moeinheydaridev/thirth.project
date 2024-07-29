using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personbase

{

    internal class personBase
    {
        public string name;
        public string familyname;
        public string age;

        public personBase(string name, string familyname, string age)

        {
            this.name = name;
            this.familyname = familyname;
            this.age = age;

        }
    }
}