using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
   public class ClassExcursionsTour
    {
      public int id_tour;
       public string name;
       public int price;
       public string date_start;
       public int day_tour;
       public string city_departure;
       public string way_tour;
       public string operator_name;
       public string excursions;
       public int number;
        public string status;

        public ClassExcursionsTour()
        {
            id_tour = 0;
            name = "";
            price = 0;
            date_start = "";
            day_tour = 0;
            city_departure = "";
            way_tour = "";
            operator_name = "";
            excursions = "";
            number = 0;
            status = "";
        }
        public ClassExcursionsTour(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id_tour = Convert.ToInt32(val[0]);
                name = val[1];
                price = Convert.ToInt32(val[2]);
                date_start = val[3];
                day_tour = Convert.ToInt32(val[4]);
                city_departure = val[5];
                way_tour = val[6];
                operator_name = val[7];
                excursions = val[8];
                number = Convert.ToInt32(val[9]);
                status = val[10];
            }
        }
    }
}
