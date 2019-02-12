using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;

namespace TouristAgency
{
    public partial class formReport : Form
    {
        int choice;
        public formReport(int a)
        {
            InitializeComponent();
            choice= a;
        }

        Report report = new Report();
        FastReport.Preview.PreviewControl p = new FastReport.Preview.PreviewControl();

        private void formReport_Load(object sender, EventArgs e)
        {
            p.Size = new Size(this.Width,this.Height);
            report.Preview = p;
            if(choice==0)
            report.Load(@"\\Mac\Home\Desktop\()\C#\TouristAgency\TouristAgency\bin\Debug\reportSale.frx");
            else if(choice==1)
                report.Load(@"\\Mac\Home\Desktop\()\C#\TouristAgency\TouristAgency\bin\Debug\reportContract.frx");
            this.Controls.Add(p);
            report.Show();
        }
    }
}
