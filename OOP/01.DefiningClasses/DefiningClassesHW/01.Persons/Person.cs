using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Persons
{
    class Person
    {
        public string name
        {
            get;
            private set
            {
                if (value == null || value.Trim().Length == 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
    }
}
