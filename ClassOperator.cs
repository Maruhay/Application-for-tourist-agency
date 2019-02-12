using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassOperator
    {
        public int id_operator;
        public string name_operator;
        public string phone_operator;
        public string fio_operator;
        public string country_operator;
        public ClassOperator()
        {
            id_operator = 0;
            name_operator = "";
            phone_operator = "";
            fio_operator = "";
            country_operator = "";
        }
        public ClassOperator(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id_operator = Convert.ToInt32(val[0]);
                name_operator = val[1];
                phone_operator = val[2];
                fio_operator = val[3];
                country_operator = val[4];
            }
        }
    }
}
