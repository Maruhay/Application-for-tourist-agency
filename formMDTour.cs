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
    public partial class formMDTour : Form
    {
        public int idChangeTour=0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassTypeTour> typeTour = new List<ClassTypeTour>();
        List<ClassCountry> country = new List<ClassCountry>();
        List<ClassCity> city = new List<ClassCity>();
        List<ClassOperator> oper = new List<ClassOperator>();

        public formMDTour()
        {
            InitializeComponent();
            lblCity.Visible = false;
            lblCountry.Visible = false;
            lblWay.Visible = false;
            lblExcursions.Visible = false;
            cbCity.Visible = false;
            cbCountry.Visible = false;
            tbExcursions.Visible = false;
            tbWay.Visible = false;
            cbStatus.SelectedIndex = 0;
            btnOK.Visible = true;
            btnUpdate.Visible = false;

        }
        //Конструктор инициализации автобусных туров и морских круизов
        public formMDTour(int id,string typetour,string name,string date,int number,string tOper,int price,string status,int days,string cityDep,string way)
        {
            idChangeTour = id;
            InitializeComponent();
            cbTypeTour.Text = typetour;
            tbNameTour.Text = name;
            dtpDateStart.Text = date;
            tbNumberTour.Text = number.ToString();
            tbPrice.Text = price.ToString();
            cbOperator.Text = tOper.ToString();
            if (status == "Доступен")
                cbStatus.SelectedIndex = 0;
            else cbStatus.SelectedIndex = 1;
            tbDays.Text = days.ToString();
            tbCityDep.Text = cityDep.ToString();
            tbWay.Text = way.ToString();
        }
        //Конструктор инициализации экскурсионных туров
        public formMDTour(int id, string typetour, string name, string date, int number, string tOper, int price, string status, int days, string cityDep, string way, string excurss,int x)
        {
            idChangeTour = id;
            InitializeComponent();
            cbTypeTour.Text = typetour;
            tbNameTour.Text = name;
            dtpDateStart.Text = date;
            tbNumberTour.Text = number.ToString();
            tbPrice.Text = price.ToString();
            cbOperator.Text = tOper.ToString();
            if (status == "Доступен")
                cbStatus.SelectedIndex = 0;
            else cbStatus.SelectedIndex = 1;
            tbDays.Text = days.ToString();
            tbCityDep.Text = cityDep.ToString();
            tbWay.Text = way.ToString();
            tbExcursions.Text = excurss;
        }

        //Конструктор инициализации отдыха на море и горнолыжного курорта
        public formMDTour(int id, string typetour, string name, string date, int number, string tOper, int price, string status, int days, string cityDep, string country, string city)
        {
            idChangeTour = id;
            InitializeComponent();
            cbTypeTour.Text = typetour;
            tbNameTour.Text = name;
            dtpDateStart.Text = date;
            tbNumberTour.Text = number.ToString();
            tbPrice.Text = price.ToString();
            cbOperator.Text = tOper.ToString();
            if (status == "Доступен")
                cbStatus.SelectedIndex = 0;
            else cbStatus.SelectedIndex = 1;
            tbDays.Text = days.ToString();
            tbCityDep.Text = cityDep.ToString();
            cbCountry.Text = country.ToString();
            cbCity.Text = city.ToString();
        }
        private void formMDTour_Load(object sender, EventArgs e)
        {        
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
            if (cbTypeTour.Text != "")
            {if (cbTypeTour.Text == "Автобусный тур")
                    cbTypeTour.SelectedIndex = 0;
                else if (cbTypeTour.Text == "Отдых на море")
                    cbTypeTour.SelectedIndex = 1;
                else if (cbTypeTour.Text == "Морской круиз")
                    cbTypeTour.SelectedIndex = 2;
                else if (cbTypeTour.Text == "Экскурсионный тур")
                    cbTypeTour.SelectedIndex = 3;
                else if (cbTypeTour.Text == "Горнолыжный курорт")
                    cbTypeTour.SelectedIndex = 4;
            }
            //Комбобокс оператора
            db.Execute<ClassOperator>(ref stp, "SELECT id_operator, name_operator, phone_contact_operator, fio_contact_operator, country_operator FROM operator", ref oper);
            if (oper.Count > 0)
            {
                for (int i = 0; i < oper.Count; i++)
                {
                    cbOperator.Items.Add(oper[i].name_operator);
                }
            }
/*            if (cbOperator.Text != "")
            {
                oper.Clear();
                db.Execute<ClassOperator>(ref stp, "SELECT id_operator, name_operator, phone_contact_operator, fio_contact_operator, country_operator FROM operator  WHERE name_operator='" + cbOperator.Text + "'", ref oper);
                cbOperator.SelectedIndex = oper[0].id_operator - 1;
            } */
        }

        private void cbTypeTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTypeTour.SelectedIndex == 3)
            {
                lblCity.Visible = false;
                lblCountry.Visible = false;
                lblWay.Visible = true;
                lblExcursions.Visible = true;
                cbCity.Visible = false;
                cbCountry.Visible = false;
                tbExcursions.Visible = true;
                tbWay.Visible = true;
            }
            else if (cbTypeTour.SelectedIndex == 0 || cbTypeTour.SelectedIndex == 2)
            {
                lblCity.Visible = false;
                lblCountry.Visible = false;
                lblWay.Visible = true;
                cbCity.Visible = false;
                cbCountry.Visible = false;
                tbWay.Visible = true;
                lblExcursions.Visible = false;
                tbExcursions.Visible = false;
            }
            else
            {
                lblCity.Visible = true;
                lblCountry.Visible = true;
                lblWay.Visible = false;
                lblExcursions.Visible = false;
                cbCity.Visible = true;
                cbCountry.Visible = true;
                tbExcursions.Visible = false;
                tbWay.Visible = false;
                //Комбобокс стран
                country.Clear();
                cbCountry.Items.Clear();
                if(cbTypeTour.SelectedIndex==1)
                db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country NATURAL JOIN city ct WHERE ct.sea = 1 GROUP BY id_country", ref country);
                else
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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {          
            oper.Clear();
            db.Execute<ClassOperator>(ref stp, "SELECT id_operator, name_operator, phone_contact_operator, fio_contact_operator, country_operator FROM operator WHERE name_operator='" + cbOperator.Text + "'", ref oper);
            typeTour.Clear();
            db.Execute<ClassTypeTour>(ref stp, "SELECT id_type_tour,name_type_tour FROM type_tour WHERE name_type_tour='" + cbTypeTour.Text + "'", ref typeTour);
            if (cbTypeTour.SelectedIndex == 0)
            {
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || tbWay.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,way_tour) VALUES ('" + tbNameTour.Text + "'," + tbPrice.Text + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + oper[0].id_operator + "," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbNumberTour.Text + ",'" + cbStatus.Text + "','" + tbWay.Text + "')");
                    cbTypeTour.Text = "";
                    cbStatus.SelectedIndex = 0;
                    cbOperator.Text = "";
                    tbWay.Text = "";
                    tbPrice.Text = "";
                    tbNumberTour.Text = "";
                    tbNameTour.Text = "";
                    tbDays.Text = "";
                    tbCityDep.Text = "";
                    cbCity.Text = "";
                    cbCountry.Text = "";
                    MessageBox.Show("Успешно!");
                }
            }
            else if (cbTypeTour.SelectedIndex == 1)
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || cbCountry.Text == "" || cbCity.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,id_city) VALUES ('" + tbNameTour.Text + "'," + tbPrice.Text + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + oper[0].id_operator + "," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbNumberTour.Text + ",'" + cbStatus.Text + "'," + city[0].id + ")");
                    cbTypeTour.Text = "";
                    cbStatus.SelectedIndex = 0;
                    cbOperator.Text = "";
                    tbWay.Text = "";
                    tbPrice.Text = "";
                    tbNumberTour.Text = "";
                    tbNameTour.Text = "";
                    tbDays.Text = "";
                    tbCityDep.Text = "";
                    cbCity.Text = "";
                    cbCountry.Text = "";
                    MessageBox.Show("Успешно!");
                }
            }
            else if (cbTypeTour.SelectedIndex == 2)
            {
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || tbWay.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,way_tour) VALUES ('" + tbNameTour.Text + "'," + tbPrice.Text + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + oper[0].id_operator + "," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbNumberTour.Text + ",'" + cbStatus.Text + "','" + tbWay.Text + "')");
                    cbTypeTour.Text = "";
                    cbStatus.SelectedIndex = 0;
                    cbOperator.Text = "";
                    tbWay.Text = "";
                    tbPrice.Text = "";
                    tbNumberTour.Text = "";
                    tbNameTour.Text = "";
                    tbDays.Text = "";
                    tbCityDep.Text = "";
                    cbCity.Text = "";
                    cbCountry.Text = "";
                    MessageBox.Show("Успешно!");
                }
            }
            else if (cbTypeTour.SelectedIndex == 3)
            {
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || tbWay.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,way_tour,excursions_tour) VALUES ('" + tbNameTour.Text + "'," + tbPrice.Text + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + oper[0].id_operator + "," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbNumberTour.Text + ",'" + cbStatus.Text + "','" + tbWay.Text + "','" + tbExcursions.Text + "')");
                    cbTypeTour.Text = "";
                    cbStatus.SelectedIndex = 0;
                    cbOperator.Text = "";
                    tbWay.Text = "";
                    tbPrice.Text = "";
                    tbNumberTour.Text = "";
                    tbNameTour.Text = "";
                    tbDays.Text = "";
                    tbCityDep.Text = "";
                    cbCity.Text = "";
                    cbCountry.Text = "";
                    MessageBox.Show("Успешно!");
                }
            }
            else
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || cbCountry.Text == "" || cbCity.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "INSERT INTO tour(name_tour,price,date_start,id_operator,day_tour,id_type_tour,city_departure,number_tour,status_tour,id_city) VALUES ('" + tbNameTour.Text + "'," + tbPrice.Text + ",'" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "'," + oper[0].id_operator + "," + tbDays.Text + "," + typeTour[0].id + ",'" + tbCityDep.Text + "'," + tbNumberTour.Text + ",'" + cbStatus.Text + "'," + city[0].id + ")");
                    cbTypeTour.Text = "";
                    cbStatus.SelectedIndex = 0;
                    cbOperator.Text = "";
                    tbWay.Text = "";
                    tbPrice.Text = "";
                    tbNumberTour.Text = "";
                    tbNameTour.Text = "";
                    tbDays.Text = "";
                    tbCityDep.Text = "";
                    cbCity.Text = "";
                    cbCountry.Text = "";
                    MessageBox.Show("Успешно!");
                }
            }
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
                    MessageBox.Show("Вводимое количество дней не может превышать 3 месяцы (92 дня)!", "Ошибка");
                    tbDays.Text = "";
                }
        }

        private void tbDays_TextChanged(object sender, EventArgs e)
        {
        }

        private void tbNumberTour_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumberTour_Leave(object sender, EventArgs e)
        {
            if (tbNumberTour.Text != "")
                try
            {
                Convert.ToInt32(tbNumberTour.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
                tbNumberTour.Text = "";
            };
            if (tbNumberTour.Text != "")
                if (Convert.ToInt32(tbNumberTour.Text) <= 0)
                {
                    MessageBox.Show("Вводимое значение не может быть отрицательным!", "Ошибка");
                    tbNumberTour.Text = "";
                }
        }

        private void tbPrice_Leave(object sender, EventArgs e)
        {
            if (tbPrice.Text != "")
                try
            {
                Convert.ToInt32(tbPrice.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
                tbPrice.Text = "";
            };
            if (tbPrice.Text != "")
                if (Convert.ToInt32(tbPrice.Text) <= 0)
                {
                    MessageBox.Show("Вводимое значение не может быть отрицательным!", "Ошибка");
                    tbPrice.Text = "";
                }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            country.Clear();
            db.Execute<ClassCountry>(ref stp, "SELECT id_country,name_country FROM country WHERE name_country='" + cbCountry.Text + "'", ref country);
            cbCity.Items.Clear();
            city.Clear();
            if (cbTypeTour.SelectedIndex == 1)
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE sea=1 AND id_country=" + country[0].id, ref city);
            else
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE id_country=" + country[0].id, ref city);
            if (city.Count > 0)
                for (int i = 0; i < city.Count; i++)
                    cbCity.Items.Add(city[i].name);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            oper.Clear();
            db.Execute<ClassOperator>(ref stp, "SELECT id_operator, name_operator, phone_contact_operator, fio_contact_operator, country_operator FROM operator WHERE name_operator='" + cbOperator.Text + "'", ref oper);
            typeTour.Clear();
            db.Execute<ClassTypeTour>(ref stp, "SELECT id_type_tour,name_type_tour FROM type_tour WHERE name_type_tour='" + cbTypeTour.Text + "'", ref typeTour);
            if (cbTypeTour.SelectedIndex == 0)
            {
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || tbWay.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET name_tour='" + tbNameTour.Text + "', price=" + tbPrice.Text + ",date_start='" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',id_operator=" + oper[0].id_operator + ",day_tour=" + tbDays.Text + ",id_type_tour=" + typeTour[0].id + ",city_departure='" + tbCityDep.Text + "',number_tour=" + tbNumberTour.Text + ",status_tour='" + cbStatus.Text + "',way_tour='" + tbWay.Text + "' WHERE id_tour="+idChangeTour);
                    MessageBox.Show("Успешно!");
                }
            }
            else if (cbTypeTour.SelectedIndex == 1)
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || cbCountry.Text == "" || cbCity.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET name_tour='" + tbNameTour.Text + "', price=" + tbPrice.Text + ",date_start='" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',id_operator=" + oper[0].id_operator + ",day_tour=" + tbDays.Text + ",id_type_tour=" + typeTour[0].id + ",city_departure='" + tbCityDep.Text + "',number_tour=" + tbNumberTour.Text + ",status_tour='" + cbStatus.Text + "',id_city='" + city[0].id + "' WHERE id_tour=" + idChangeTour);
                    MessageBox.Show("Успешно!");
                }
            }
            else if (cbTypeTour.SelectedIndex == 2)
            {
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || tbWay.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET name_tour='" + tbNameTour.Text + "', price=" + tbPrice.Text + ",date_start='" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',id_operator=" + oper[0].id_operator + ",day_tour=" + tbDays.Text + ",id_type_tour=" + typeTour[0].id + ",city_departure='" + tbCityDep.Text + "',number_tour=" + tbNumberTour.Text + ",status_tour='" + cbStatus.Text + "',way_tour='" + tbWay.Text + "' WHERE id_tour=" + idChangeTour);
                    MessageBox.Show("Успешно!");
                }
            }
            else if (cbTypeTour.SelectedIndex == 3)
            {
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || tbWay.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET name_tour='" + tbNameTour.Text + "', price=" + tbPrice.Text + ",date_start='" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',id_operator=" + oper[0].id_operator + ",day_tour=" + tbDays.Text + ",id_type_tour=" + typeTour[0].id + ",city_departure='" + tbCityDep.Text + "',number_tour=" + tbNumberTour.Text + ",status_tour='" + cbStatus.Text + "',way_tour='" + tbWay.Text + "', excursions_tour='"+tbExcursions.Text+"' WHERE id_tour=" + idChangeTour);
                    MessageBox.Show("Успешно!");
                }
            }
            else
            {
                city.Clear();
                db.Execute<ClassCity>(ref stp, "SELECT id_city,name_city FROM city WHERE name_city='" + cbCity.Text + "'", ref city);
                if (cbTypeTour.Text == "" || cbStatus.Text == "" || cbOperator.Text == "" || tbCityDep.Text == "" || tbDays.Text == "" || tbNameTour.Text == "" || tbNumberTour.Text == "" || tbPrice.Text == "" || cbCountry.Text == "" || cbCity.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET name_tour='" + tbNameTour.Text + "', price=" + tbPrice.Text + ",date_start='" + dtpDateStart.Value.ToString("yyyy-MM-dd") + "',id_operator=" + oper[0].id_operator + ",day_tour=" + tbDays.Text + ",id_type_tour=" + typeTour[0].id + ",city_departure='" + tbCityDep.Text + "',number_tour=" + tbNumberTour.Text + ",status_tour='" + cbStatus.Text + "',id_city='" + city[0].id + "' WHERE id_tour=" + idChangeTour);
                    MessageBox.Show("Успешно!");
                }
            }
        }

        private void formMDTour_Leave(object sender, EventArgs e)
        {
            
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}