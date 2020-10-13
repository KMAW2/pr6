using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr6
{
    class ResearchTeam
    {
        string theme;
        string org;
        int number;
        TimeFrame last;
        Paper[] list;
        public ResearchTeam(string t, string o, int num, TimeFrame la)
        {
            theme = t;
            org = o;
            number = num;
            la = last;
        }
        public ResearchTeam()
        {
            theme = "Research";
            org = "MyOrganisation";
            number = 228;
            last = TimeFrame.TwoYears;
        }

        public string Theme
        {
            get
            {
                return theme;
            }
            set
            {
                theme = value;
            }
        }
        public string Org
        {
            get
            {
                return org;
            }
            set
            {
                org = value;
            }
        }
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public TimeFrame Last
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }
        public Paper[] List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
            }
        }
        public Paper lastdate
        {
            get
            {
                if (list.Length==0)
                {
                    return null;
                }
                int ii=0;
                for(int i = 0; i < list.Length-1; i++) 
                {
                    if (DateTime.Compare(list[i].dpub, list[i + 1].dpub) < 0)
                        ii = i + 1; 
                    else 
                        ii = i; 
                }
                return list[ii];
            }
        }
        public bool this[TimeFrame time]
        {
            get 
            {
                return (time == last);
            }
        }
        public void AddPapers(params Paper[] lists)
        {
            for (int i = 0; i < lists.Length; i++) 
                for(int j=0;j<List.Length;j++)
                    if (List[j] == null)
                    {
                        List[j] = lists[i];
                        break;
                    }          
        }
        public override string ToString()
        {
            string slist = "";
            for (int i = 0; i < List.Length; i++)
            {
                if(List[i]!=null) slist += List[i].ToString();
            }
            return theme.ToString()+number.ToString()+org.ToString()+last.ToString()+slist;
        }
        public virtual string ToShortString()
        {
            return theme.ToString() +number.ToString()+ org.ToString() + last.ToString();
        }
    }

}
