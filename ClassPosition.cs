using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassPosition
    {
        public int id;
        public string name;

        public ClassPosition()
        {
            id = 0;
            name = "";
        }

        public ClassPosition(string info)
        {
            if (info != "" && info!=null)
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
            }
        }
    }
}
