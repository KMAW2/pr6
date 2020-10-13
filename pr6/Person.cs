using System;
using System.Collections.Generic;
using System.Text;

namespace pr6
{
    class Person
    {
        string name;
        string sur;
        System.DateTime dr;
        public Person(string n, string s, DateTime d)
        {
            name = n;
            sur = s;
            dr = d;
        }
        public Person()
        {
            name = "Ivan";
            sur = "Ivanov";
            dr= new DateTime(2008, 3, 1);
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Sur
        {
            get
            {
                return sur;
            }
            set
            {
                sur = value;
            }
        }
        public DateTime Dr
        {
            get
            {
                return dr;
            }
            set
            {
                dr = value;
            }
        }
        public int year
        {
            get
            {
                return dr.Year;
            }
            set
            {
                dr = new DateTime(value, dr.Month, dr.Day);
            }
        }
        public override string ToString()
        {
            return dr.ToString() + sur.ToString() + name.ToString();
        }
        public virtual string ToShortString()
        {
            return sur.ToString() + name.ToString();
        }
    }

}
