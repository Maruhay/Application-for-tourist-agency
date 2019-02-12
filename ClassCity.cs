using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassCity
    {
        public int id;
        public string name;
        public ClassCity()
        {
            id = 0;
            name = "";
        }
        public ClassCity(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id = Convert.ToInt32(val[0]);
                name = val[1];
            }
        }

        public ClassCountry ClassCountry
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public ClassHotel ClassHotel
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
