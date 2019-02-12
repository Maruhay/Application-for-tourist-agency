using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassCountry
    {
        public int id;
        public string name;
        public ClassCountry()
        {
            id = 0;
            name = "";
        }
        public ClassCountry(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
            }
        }
    }
}
