using System;
using System.Collections.Generic;
using System.Text;

namespace pr6
{
    class Paper
    {
        public string pub { get; set; }
        public Person auth { get; set; }
        public DateTime dpub { get; set; }
        public Paper(string p, Person a, DateTime dp)
        {
            pub = p;
            auth = a;
            dpub = dp;
        }
        public Paper()
        {
            pub = "News";
            auth = new Person();
            dpub = new DateTime(2028, 3, 5);
        }
        public override string ToString()
        {
            string z= pub + auth.ToString() + dpub.ToString();
            return pub + auth.ToString() + dpub.ToString();
        }
    }
}
