using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassTypeTour
    {
        public int id;
        public string name;
        public ClassTypeTour()
        {
            id = 0;
            name = "";
        }
        public ClassTypeTour(string info)
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
