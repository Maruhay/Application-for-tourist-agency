using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
   public class ClassClient
    {
        public int id_client;
        public string fio_client;
        public string phone_client;
        public string series_pasp_client;
        public string number_pasp_client;
        public string discount;
        public string adress_client;
        public ClassClient()
        {
            id_client = 0;
            fio_client = "";
            phone_client = "";
            series_pasp_client = "";
            number_pasp_client = "";
            discount = "";
            adress_client = "";
        }
        public ClassClient(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id_client = Convert.ToInt32(val[0]);
                fio_client = val[1];
                phone_client = val[2];
                series_pasp_client = val[3];
                number_pasp_client = val[4];
                discount = val[5];
                adress_client = val[6];
            }
        }
    }
}
