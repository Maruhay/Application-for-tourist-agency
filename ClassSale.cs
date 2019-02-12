using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TouristAgency
{
    public class ClassSale
    {
       [XmlAttribute]public int id_sale;
       [XmlAttribute]public string date_sale;
       [XmlAttribute]public int id_client;
        public int id_empl;
        public int id_tour;
       [XmlAttribute]public string fio_client;
       [XmlAttribute]public string fio_empl;
       [XmlAttribute]public string name_tour;
       [XmlAttribute]public string type_tour;
       [XmlAttribute]public int number_sale;
       [XmlAttribute]public int price;
       [XmlAttribute]public string status_sale;
        public ClassSale()
        {
            id_sale = 0;
            date_sale = "";
            id_client = 0;
            id_empl = 0;
            id_tour = 0;
            fio_client = "";
            fio_empl = "";
            name_tour = "";
            type_tour = "";
            number_sale = 0;
            price = 0;
            status_sale = "";
            
        }
        public ClassSale(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id_sale = Convert.ToInt32(val[0]);
                date_sale = val[1];
                id_client = Convert.ToInt32(val[2]);
                id_empl = Convert.ToInt32(val[3]);
                id_tour = Convert.ToInt32(val[4]);
                fio_client = val[5];
                fio_empl = val[6];
                name_tour = val[7];
                type_tour = val[8];
                number_sale = Convert.ToInt32(val[9]);
                price = Convert.ToInt32(val[10]);
                status_sale = val[11];
            }
        }
    }
}
