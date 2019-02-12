using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TouristAgency
{
    public class ClassContract
    {
       [XmlAttribute]  public int id_sale;
       [XmlAttribute]  public string date_sale;
       [XmlAttribute]  public string fio_client;
       [XmlAttribute]  public string name_tour;
       [XmlAttribute]  public string date_start;
       [XmlAttribute]  public int day_tour;
       [XmlAttribute]  public int number_sale;
       [XmlAttribute]  public int price;

        public ClassContract()
        {
            id_sale = 0;
            date_sale = "";
            fio_client = "";
            name_tour = "";
            date_start = "";
            day_tour = 0;
            number_sale = 0;
            price = 0;
        }
        public ClassContract(string info)
        {
            if (info != "")
            {
                string[] val = info.Split('!');
                id_sale = Convert.ToInt32(val[0]);
                date_sale = val[1];
                fio_client = val[2];
                name_tour = val[3];
                date_start = val[4];
                day_tour = Convert.ToInt32(val[5]); ;
                number_sale = Convert.ToInt32(val[6]); ;
                price = Convert.ToInt32(val[7]);
            }
        }
    }
}
