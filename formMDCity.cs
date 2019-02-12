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
    public partial class formMDCity : Form
    {
        public int idChange = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassCountry> country = new List<ClassCountry>();

        public formMDCity()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        public formMDCity(int id, string city, string country)
        {
            InitializeComponent();
            btnAdd.Visible = false;
            idChange = id;
            cbCountry.Text = country;
            tbName.Text = city;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || cbCountry.Text == "")
                MessageBox.Show("Введены не все данные!", "Ошибка");
            else
            {
                int sea = 0;
                if (chckbSea.Checked)
                    sea = 1;
                country.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country WHERE name_country='"+cbCountry.Text+"'", ref country);
                db.ExecuteNonQuery(ref stp, "INSERT INTO city(name_city,id_country,sea) VALUES('" + tbName.Text + "'," + country[0].id + ","+sea+")");
                tbName.Text = "";
                MessageBox.Show("Успешно!");
            }
        }

        private void formMDCity_Load(object sender, EventArgs e)
        {
            country.Clear();
            db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country", ref country);
            if (country.Count > 0)
            {
                for (int i = 0; i < country.Count; i++)
                {
                    cbCountry.Items.Add(country[i].name);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || cbCountry.Text == "")
                MessageBox.Show("Введены не все данные!", "Ошибка");
            else
            {
                int sea = 0;
                if (chckbSea.Checked)
                    sea = 1;
                country.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country WHERE name_country='"+cbCountry.Text+"'", ref country);
                db.ExecuteNonQuery(ref stp, "UPDATE city SET name_city='" + tbName.Text + "',id_country=" + country[0].id+ ", sea=" + sea +" WHERE id_city="+idChange);
                MessageBox.Show("Успешно!");
            }
        }
    }
}