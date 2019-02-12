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
    public partial class formGoogleImages : Form
    {
        string query;
        public formGoogleImages(string q)
        {
            InitializeComponent();
            query = q;
        }

        private void formGoogleImages_Load(object sender, EventArgs e)
        {
            webB.Navigate("https://www.google.com.ua/search?tbm=isch&source=hp&q="+query);
        }
    }
}
