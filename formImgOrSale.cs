using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouristAgency
{
    public partial class formImgOrSale : Form
    {
        string query;
        int idTour,type;

        public formImgOrSale(string q,int id,int t)
        {
            InitializeComponent();
            query = q;
            idTour = id;
            type = t;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case 1:
                    formFormSale obj = new formFormSale(idTour, 1);
                    obj.ShowDialog();
                    break;
                case 4:
                    formFormSale obj1 = new formFormSale(idTour, 4);
                    obj1.ShowDialog();
                    break;
                case 0:
                    formFormSale obj2 = new formFormSale(idTour, 0);
                    obj2.ShowDialog();
                    break;
                case 2:
                    formFormSale obj3 = new formFormSale(idTour, 2);
                    obj3.ShowDialog();
                    break;
                case 3:
                    formFormSale obj4 = new formFormSale(idTour, 3);
                    obj4.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            formGoogleImages obj = new formGoogleImages(query);
            obj.ShowDialog();
        }
    }
}
