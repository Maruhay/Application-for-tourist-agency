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
    public partial class formConstructor : Form
    {
        int price = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassTypeTour> typeTour = new List<ClassTypeTour>();
        List<ClassCountry> country = new List<ClassCountry>();
        List<ClassCity> city = new List<ClassCity>();
        List<ClassBusTour> busTour = new List<ClassBusTour>();
        List<ClassExcursionsTour> excursTour = new List<ClassExcursionsTour>();
        List<ClassMarinTour> marinTour = new List<ClassMarinTour>();
        List<ClassMountainTour> mountTour = new List<ClassMountainTour>();
        List<ClassSeaTour> seaTour = new List<ClassSeaTour>();

        public formConstructor()
        {
            InitializeComponent();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            formMDCountry obj = new formMDCountry();
            obj.ShowDialog();
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
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            formMDCity obj = new formMDCity();
            obj.ShowDialog();
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
            if (cbCountry.Text != "")
                cbCountry_SelectedIndexChanged(sender, e);
        }

        private void formConstructor_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = false;
            lblWay.Visible = false;
            tbWay.Visible = false;
            lblExcursions.Visible = false;
            tbExcursions.Visible = false;
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
            //Комбобокс типов тура
            typeTour.Clear();
            db.Execute<ClassTypeTour>(ref stp, "SELECT id_type_tour,name_type_tour FROM type_tour", ref typeTour);
            if (typeTour.Count > 0)
            {
                for (int i = 0; i < typeTour.Count; i++)
                {
                    cbTypeTour.Items.Add(typeTour[i].name);
                }
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country WHERE name_country='" + cbCountry.Text + "'", ref country);
            cbCity.Items.Clear();
            city.Clear();
            if(cbTypeTour.SelectedIndex==1)
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE sea=1 AND id_country=" + country[0].id, ref city);
            else
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE id_country=" + country[0].id, ref city);
            if (city.Count > 0)
                for (int i = 0; i < city.Count; i++)
                    cbCity.Items.Add(city[i].name);
        }

        private void tbDays_Leave(object sender, EventArgs e)
        {
            if (tbDays.Text != "")
                try
                {
                    Convert.ToInt32(tbDays.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
                    tbDays.Text = "";
                };
            if (tbDays.Text != "")
                if (Convert.ToInt32(tbDays.Text) <= 0)
                {
                    MessageBox.Show("Вводимое значение не может быть отрицательным!", "Ошибка");
                    tbDays.Text = "";
                }
            if (tbDays.Text != "")
                if (Convert.ToInt32(tbDays.Text) > 92)
                {
                    MessageBox.Show("Вводимое количество дней не может превышать 3 месяца (92 дня)!", "Ошибка");
                    tbDays.Text = "";
                }
        }

        private void cbTypeTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeTour.SelectedIndex == 0)
            {
                btnAdd.Visible = true;
                btnMode.Visible = false;
                lblWay.Visible = true;
                tbWay.Visible = true;
                lblExcursions.Visible = false;
                tbExcursions.Visible = false;
                price = 500;
                country.Clear();
                cbCountry.Items.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country", ref country);
                if (country.Count > 0)
                {
                    for (int i = 0; i < country.Count; i++)
                    {
                        cbCountry.Items.Add(country[i].name);
                    }
                }
            }
            else if (cbTypeTour.SelectedIndex == 1)
            {
                btnMode.Visible = true;
                btnAdd.Visible = false;
                lblWay.Visible = false;
                tbWay.Visible = false;
                lblExcursions.Visible = false;
                tbExcursions.Visible = false;
                price = 500;
                country.Clear();
                cbCountry.Items.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country NATURAL JOIN city ct WHERE ct.sea = 1 GROUP BY id_country", ref country);
                if (country.Count > 0)
                {
                    for (int i = 0; i < country.Count; i++)
                    {
                        cbCountry.Items.Add(country[i].name);
                    }
                }
            }
            else if (cbTypeTour.SelectedIndex == 2)
            {
                btnMode.Visible = true;
                btnAdd.Visible = true;
                lblWay.Visible = true;
                tbWay.Visible = true;
                lblExcursions.Visible = false;
                tbExcursions.Visible = false;
                price = 700;
                country.Clear();
                cbCountry.Items.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country", ref country);
                if (country.Count > 0)
                {
                    for (int i = 0; i < country.Count; i++)
                    {
                        cbCountry.Items.Add(country[i].name);
                    }
                }
            }
            else if (cbTypeTour.SelectedIndex == 3)
            {   
                btnMode.Visible = false;
                btnAdd.Visible = true;
                lblWay.Visible = true;
                tbWay.Visible = true;
                lblExcursions.Visible = true;
                tbExcursions.Visible = true;
                price = 750;
                country.Clear();
                cbCountry.Items.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country", ref country);
                if (country.Count > 0)
                {
                    for (int i = 0; i < country.Count; i++)
                    {
                        cbCountry.Items.Add(country[i].name);
                    }
                }
            }
            else if (cbTypeTour.SelectedIndex == 4)
            {
                btnMode.Visible = true;
                lblWay.Visible = false;
                tbWay.Visible = false;
                lblExcursions.Visible = false;
                tbExcursions.Visible = false;
                btnAdd.Visible = false;
                price = 600;
                country.Clear();
                cbCountry.Items.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country", ref country);
                if (country.Count > 0)
                {
                    for (int i = 0; i < country.Count; i++)
                    {
                        cbCountry.Items.Add(country[i].name);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCity.Text == "")
                MessageBox.Show("Выберите город!", "Ошибка");
            else
            {
                if (tbWay.Text == "")
                    tbWay.Text = cbCity.Text;
                else
                    tbWay.Text = tbWay.Text + "_" + cbCity.Text;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            typeTour.Clear();
            db.Execute<ClassTypeTour>(ref stp, "SELECT id_type_tour,name_type_tour FROM type_tour WHERE name_type_tour='" + cbTypeTour.Text + "'", ref typeTour);
            if (cbTypeTour.SelectedIndex == 0)
            {
                if (cbTypeTour.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbWay.Text == "" || dtpDateStart.Text == "" || tbPerson.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    string[] numberCities = tbWay.Text.Split('_');
                    price += numberCities.Length * 200;
                    if (Convert.ToInt32(tbDays.Text) > 60)
                        price *= 3;
                    else if (Convert.ToInt32(tbDays.Text) > 20)
                        price *= 2;
                    else if (Convert.ToInt32(tbDays.Text) > 13)
                        price += 500;
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,day_tour,id_type_tour,city_departure,number_tour,status_tour,way_tour,id_operator) VALUES ('" + tbNameTour.Text + "'," + price + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbPerson.Text + ",'Не доступен','" + tbWay.Text + "',9)");
                    busTour.Clear();
                    db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  ORDER BY t.id_tour desc limit 1", ref busTour);
                    formFormSale obj = new formFormSale(busTour[0].id_tour, 0);
                    obj.ShowDialog();
                }
            }
            else if (cbTypeTour.SelectedIndex == 1)
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                if (cbTypeTour.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || cbCity.Text == "" || dtpDateStart.Text == "" || tbPerson.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    if (Convert.ToInt32(tbDays.Text) > 60)
                        price *= 3;
                    else if (Convert.ToInt32(tbDays.Text) > 20)
                        price *= 2;
                    else if (Convert.ToInt32(tbDays.Text) > 13)
                        price += 500;
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,id_city) VALUES ('" + tbNameTour.Text + "'," + price + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',9," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbPerson.Text + ",'Не доступен'," + city[0].id.ToString() + ")");
                    seaTour.Clear();
                    db.Execute<ClassSeaTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o)", ref seaTour);
                    formFormSale obj = new formFormSale(seaTour[0].id_tour, 1);
                    obj.ShowDialog();   
                }
            }
            else if (cbTypeTour.SelectedIndex == 2)
            {
                if (cbTypeTour.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbWay.Text == "" || dtpDateStart.Text == "" || tbPerson.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    string[] numberCities = tbWay.Text.Split('_');
                    price += numberCities.Length * 200;
                    if (Convert.ToInt32(tbDays.Text) > 60)
                        price *= 3;
                    else if (Convert.ToInt32(tbDays.Text) > 20)
                        price *= 2;
                    else if (Convert.ToInt32(tbDays.Text) > 13)
                        price += 500;
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,day_tour,id_type_tour,city_departure,number_tour,status_tour,way_tour,id_operator) VALUES ('" + tbNameTour.Text + "'," + price + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbPerson.Text + ",'Не доступен','" + tbWay.Text + "',9)");
                    marinTour.Clear();
                    db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  ORDER BY t.id_tour desc limit 1", ref marinTour);
                    formFormSale obj = new formFormSale(marinTour[0].id_tour, 2);
                    obj.ShowDialog();
                }
            }
            else if (cbTypeTour.SelectedIndex == 3)
            {
                if (cbTypeTour.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbWay.Text == "" || dtpDateStart.Text == "" || tbPerson.Text == "" || tbExcursions.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    string[] numberCities = tbWay.Text.Split('_');
                    price += numberCities.Length * 200;
                    if (Convert.ToInt32(tbDays.Text) > 60)
                        price *= 3;
                    else if (Convert.ToInt32(tbDays.Text) > 20)
                        price *= 2;
                    else if (Convert.ToInt32(tbDays.Text) > 13)
                        price += 500;
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,day_tour,id_type_tour,city_departure,number_tour,status_tour,way_tour,id_operator,excursions_tour) VALUES ('" + tbNameTour.Text + "'," + price + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbPerson.Text + ",'Не доступен','" + tbWay.Text + "',9,'" + tbExcursions.Text + "')");
                    excursTour.Clear();
                    db.Execute<ClassExcursionsTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.excursions_tour, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o ORDER BY t.id_tour desc limit 1", ref excursTour);
                    formFormSale obj = new formFormSale(excursTour[0].id_tour, 3);
                    obj.ShowDialog();
                }
            }
            else if (cbTypeTour.SelectedIndex == 4)
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                if (cbTypeTour.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || cbCity.Text == "" || dtpDateStart.Text == "" || tbPerson.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    if (Convert.ToInt32(tbDays.Text) > 60)
                        price *= 3;
                    else if (Convert.ToInt32(tbDays.Text) > 20)
                        price *= 2;
                    else if (Convert.ToInt32(tbDays.Text) > 13)
                        price += 500;
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,id_city) VALUES ('" + tbNameTour.Text + "'," + price + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',9," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbPerson.Text + ",'Не доступен'," + city[0].id + ")");
                    mountTour.Clear();
                    db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) ORDER BY t.id_tour desc limit 1", ref mountTour);
                    formFormSale obj = new formFormSale(mountTour[0].id_tour, 4);
                    obj.ShowDialog();
                }
            }
        }

        private void tbPerson_TextChanged(object sender, EventArgs e)
        {
            if (tbPerson.Text != "")
                try
                {
                    Convert.ToInt32(tbPerson.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
                    tbPerson.Text = "";
                };
            if (tbPerson.Text != "")
                if (Convert.ToInt32(tbPerson.Text) <= 0)
                {
                    MessageBox.Show("Вводимое значение не может быть отрицательным!", "Ошибка");
                    tbPerson.Text = "";
                }
            if (tbPerson.Text != "")
                if (Convert.ToInt32(tbPerson.Text) > 92)
                {
                    MessageBox.Show("Вводимое количество людей не может превышать 10!", "Ошибка");
                    tbPerson.Text = "";
                }
        }

        private void formConstructor_Enter(object sender, EventArgs e)
        {
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            if (cbTypeTour.Text == "Отдых на море")
            {
                formInteractiveConstrustor obj = new formInteractiveConstrustor(1, this);
                obj.ShowDialog();
            }
            else if (cbTypeTour.Text == "Горнолыжный курорт")
            {
                formInteractiveConstrustor obj1 = new formInteractiveConstrustor(4, this);
                obj1.ShowDialog();
            }
            else if (cbTypeTour.Text == "Морской круиз")
            {
                formInteractiveConstrustor obj2 = new formInteractiveConstrustor(2,this);
                obj2.ShowDialog();
            }
        }

        public void CountryOfCity(string nameCity)
        {
            city.Clear();
            db.Execute<ClassCity>(ref stp, "SELECT id_country,name_city FROM city WHERE name_city='"+nameCity+"'", ref city);
            if (city.Count > 0)
            {
                country.Clear();
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country WHERE id_country="+city[0].id.ToString(), ref country);
                if (country.Count > 0)
                {
                    cbCountry.Text = country[0].name;
                }
            }
        }
    }
}
