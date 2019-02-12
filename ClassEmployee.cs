using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristAgency
{
    public class ClassEmployee
    {
        public int id_empl;
        public string fio_empl;
        public string phone_empl;
        public string adress_empl;
        public string series_pasp_empl;
        public string number_pasp_empl;
        public string position;
        public ClassEmployee()
        {
            id_empl = 0;
            fio_empl = "";
            phone_empl = "";
            adress_empl = "";
            series_pasp_empl = "";
            number_pasp_empl = "";
            position = "";
        }
        public ClassEmployee(string info)
        {
            if (info != null && info != "")
            {
                string[] val = info.Split('!');
                id_empl = Convert.ToInt32(val[0]);
                fio_empl = val[1];
                phone_empl = val[2];
                adress_empl = val[3];
                series_pasp_empl = val[4];
                number_pasp_empl = val[5];
                position = val[6];
            }
        }

        public ClassPosition ClassPosition
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
