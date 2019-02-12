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
    public partial class formImgOrChoose : Form
    {
        string query;
        int idTour, type;
        formInteractiveConstrustor interactiveConstrucor;
        formConstructor constructor;

        public formImgOrChoose(string q, int id,int t, formInteractiveConstrustor c, formConstructor cons)
        {
            InitializeComponent();
            query = q;
            idTour = id;
            type = t;
            interactiveConstrucor = c;
            constructor = cons;
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (type == 1 || type == 4)
            {
                interactiveConstrucor.Close();
                constructor.CountryOfCity(query);
                constructor.cbCity.Text = query;
                this.Close();
            }
            else if (type == 2)
            {
                interactiveConstrucor.way += '_' + query;
                interactiveConstrucor.RefreshWay();
                this.Close();
            }
        }

        private void formImgOrChoose_Load(object sender, EventArgs e)
        {
            if (idTour == 0)
            {
                btnChoose.Enabled = false;
            }
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            formGoogleImages obj = new formGoogleImages(query);
            obj.ShowDialog();
        }
    }
}
