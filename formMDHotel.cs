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
    public partial class formMDHotel : Form
    {
        public int idChange = 0;
        bool[] f = new bool[6] {false,false,false,false,false,false};
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassCountry> country = new List<ClassCountry>();
        List<ClassCity> city = new List<ClassCity>();
        List<ClassHotel> hotel = new List<ClassHotel>();

        public formMDHotel()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        public formMDHotel(int id,string name,string star,string countryy,string city,string phone)
        {
            InitializeComponent();
            btnAdd.Visible = false;
            idChange = id;
            tbName.Text = name;
            cbStar.Text = star;
            cbCountry.Text = countryy;
            cbCity.Text = city;
            tbPhone.Text = phone;
            //Класс country используется для поиска видов питания в отеле
            country.Clear();
            db.Execute<ClassCountry>(ref stp, "SELECT hf.id_food,f.name_food FROM hotel_food hf NATURAL JOIN food f WHERE hf.id_hotel="+id, ref country);
            if (country.Count > 0)
            {
                for (int i = 0; i < country.Count; i++)
                    if (country[i].name == "UAI")
                    {
                        chckUAI.Checked = true;
                        f[0] = true;
                    }
                for (int i = 0; i < country.Count; i++)
                    if (country[i].name == "AI")
                    {
                        chckAI.Checked = true;
                        f[1] = true;
                    }
                for (int i = 0; i < country.Count; i++)
                    if (country[i].name == "FB")
                    {
                        chckFB.Checked = true;
                        f[2] = true;
                    }
                for (int i = 0; i < country.Count; i++)
                    if (country[i].name == "HB")
                    {
                        chckHB.Checked = true;
                        f[3] = true;
                    }
                for (int i = 0; i < country.Count; i++)
                    if (country[i].name == "BB")
                    {
                        chckBB.Checked = true;
                        f[4] = true;
                    }
                for (int i = 0; i < country.Count; i++)
                    if (country[i].name == "RO")
                    {
                        chckRO.Checked = true;
                        f[5] = true;
                    }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || cbCity.Text == "" || cbCountry.Text == "" || cbStar.Text == "")
                MessageBox.Show("Введены не все поля!", "Ошибка");
            else
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='"+cbCity.Text+"'", ref city);
                db.ExecuteNonQuery(ref stp,"INSERT INTO hotel(name_hotel,star_hotel,phone_hotel,id_city) VALUES ('"+tbName.Text+"',"+cbStar.Text+",'"+tbPhone.Text+"',"+city[0].id+")");
                hotel.Clear();
                db.Execute<ClassHotel>(ref stp, "SELECT h.id_hotel,h.name_hotel,h.star_hotel,h.phone_hotel,co.name_country,ct.name_city FROM ((hotel h NATURAL JOIN city ct) NATURAL JOIN country co) ORDER BY h.id_hotel desc limit 1", ref hotel);
                if (chckAI.Checked)
                    db.ExecuteNonQuery(ref stp,"INSERT INTO hotel_food(id_hotel,id_food) VALUES ("+hotel[0].id_hotel+",5)");
                if (chckRO.Checked)
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + hotel[0].id_hotel + ",1)");
                if (chckUAI.Checked)
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + hotel[0].id_hotel + ",6)");
                if (chckFB.Checked)
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + hotel[0].id_hotel + ",4)");
                if (chckHB.Checked)
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + hotel[0].id_hotel + ",3)");
                if (chckBB.Checked)
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + hotel[0].id_hotel + ",2)");
                tbName.Text = "";
                tbPhone.Text = "";
                cbCity.Text = "";
                cbCountry.Text = "";
                cbStar.Text = "";
                chckAI.Checked = false;
                chckUAI.Checked = false;
                chckFB.Checked = false;
                chckHB.Checked = false;
                chckBB.Checked = false;
                chckRO.Checked = false;
                MessageBox.Show("Успешно!");
            }
        }

        private void formMDHotel_Load(object sender, EventArgs e)
        {
            //Комбобокс стран
            country.Clear();
            db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country", ref country);
            if (country.Count > 0)
            {
                for (int i = 0; i < country.Count; i++)
                {
                    cbCountry.Items.Add(country[i].name);
                }
            }
            //Комбобокс городов
            city.Clear();
            db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city", ref city);
            if (city.Count > 0)
            {
                for (int i = 0; i < country.Count; i++)
                {
                    cbCity.Items.Add(city[i].name);
                }
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country.Clear();
            db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country WHERE name_country='" + cbCountry.Text + "'", ref country);
            cbCity.Items.Clear();
            city.Clear();
            db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE id_country=" + country[0].id, ref city);
            if (city.Count > 0)
                for (int i = 0; i < city.Count; i++)
                    cbCity.Items.Add(city[i].name);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbPhone.Text == "" || cbCity.Text == "" || cbCountry.Text == "" || cbStar.Text == "")
                MessageBox.Show("Введены не все поля!", "Ошибка");
            else
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                db.ExecuteNonQuery(ref stp, "UPDATE hotel SET name_hotel='"+tbName.Text+"',star_hotel='"+cbStar.Text+"',phone_hotel='"+tbPhone.Text+"',id_city="+city[0].id+" WHERE id_hotel="+idChange);
                if ((chckUAI.Checked) && (f[0] == false))
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + idChange + ",6)");
                if ((!chckUAI.Checked) && (f[0] == true))
                    db.ExecuteNonQuery(ref stp,"DELETE FROM hotel_food WHERE id_hotel="+idChange+" AND id_food=6");
                if ((chckAI.Checked) && (f[1] == false))
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + idChange + ",5)");
                if ((!chckAI.Checked) && (f[1] == true))
                    db.ExecuteNonQuery(ref stp, "DELETE FROM hotel_food WHERE id_hotel=" + idChange + " AND id_food=5");
                if ((chckFB.Checked) && (f[2] == false))
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + idChange + ",4)");
                if ((!chckFB.Checked) && (f[2] == true))
                    db.ExecuteNonQuery(ref stp, "DELETE FROM hotel_food WHERE id_hotel=" + idChange + " AND id_food=4");
                if ((chckBB.Checked) && (f[3] == false))
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + idChange + ",3)");
                if ((!chckBB.Checked) && (f[3] == true))
                    db.ExecuteNonQuery(ref stp, "DELETE FROM hotel_food WHERE id_hotel=" + idChange + " AND id_food=3");
                if ((chckHB.Checked) && (f[4] == false))
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + idChange + ",2)");
                if ((!chckHB.Checked) && (f[4] == true))
                    db.ExecuteNonQuery(ref stp, "DELETE FROM hotel_food WHERE id_hotel=" + idChange + " AND id_food=2");
                if ((chckRO.Checked) && (f[5] == false))
                    db.ExecuteNonQuery(ref stp, "INSERT INTO hotel_food(id_hotel,id_food) VALUES (" + idChange + ",1)");
                if ((!chckRO.Checked) && (f[5] == true))
                    db.ExecuteNonQuery(ref stp, "DELETE FROM hotel_food WHERE id_hotel=" + idChange + " AND id_food=1");
                MessageBox.Show("Успешно!");
            }
        }
    }
}
