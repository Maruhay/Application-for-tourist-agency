using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassHotel
    {
        public int id_hotel;
        public string name_hotel;
        public int star_hotel;
        public string phone_hotel;
        public string country;
        public string city;
        public ClassHotel()
        {
            id_hotel = 0;
            name_hotel = "";
            star_hotel = 0;
            phone_hotel = "";
            country = "";
            city = "";
        }
        public ClassHotel(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id_hotel = Convert.ToInt32(val[0]);
                name_hotel = val[1];
                star_hotel = Convert.ToInt32(val[2]);
                phone_hotel = val[3];
                country = val[4];
                city = val[5];
            }
        }
    }
}
