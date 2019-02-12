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
    public partial class formFormSale : Form
    {
        public int id = 0;
        public int maxPerson = 0;
        public int price = 0;
        public int totalPrice = -1;
        public int typeT = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassCountry> food = new List<ClassCountry>(); //Класс страна используется для вывода в комбобокс виды питания для отеля
        List<ClassEmployee> empl = new List<ClassEmployee>();
        List<ClassHotel> hotel = new List<ClassHotel>();
        List<ClassClient> client = new List<ClassClient>();
        List<ClassBusTour> busTour = new List<ClassBusTour>();
        List<ClassExcursionsTour> excursTour = new List<ClassExcursionsTour>();
        List<ClassMarinTour> marinTour = new List<ClassMarinTour>();
        List<ClassMountainTour> mountTour = new List<ClassMountainTour>();
        List<ClassSeaTour> seaTour = new List<ClassSeaTour>();
        List<ClassContract> contract = new List<ClassContract>();

        public formFormSale(int idTour, int typeTour)
        {
            InitializeComponent();
            id = idTour;
            string[] dateS;
            typeT = typeTour;
            switch (typeT)
            {
                case 0:
                    lblCountry.Visible = false;
                    lblExcursions.Visible = false;
                    lblCity.Visible = false;
                    lblHotel.Visible = false;
                    btnImg.Visible = false;
                    lblFood.Visible = false;
                    tbCountry.Visible = false;
                    tbCity.Visible = false;
                    tbExcursions.Visible = false;
                    cbFood.Visible = false;
                    cbHotel.Visible = false;
                    tbTypeTour.Text = "Автобусный тур";
                    busTour.Clear();
                    db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_tour=" + id, ref busTour);
                    tbNameTour.Text = busTour[0].name;
                    dateS = busTour[0].date_start.Split(' ');
                    tbDateStart.Text = dateS[0];
                    tbDays.Text = busTour[0].day_tour.ToString();
                    tbCityDep.Text = busTour[0].city_departure;
                    tbWay.Text = busTour[0].way_tour;
                    maxPerson = busTour[0].number;
                    price = busTour[0].price;
                    break;
                case 1:
                    lblExcursions.Visible = false;
                    tbExcursions.Visible = false;
                    lblWay.Visible = false;
                    tbWay.Visible = false;
                    tbTypeTour.Text = "Отдых на море";
                    seaTour.Clear();
                    db.Execute<ClassSeaTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_tour=" + id, ref seaTour);
                    tbNameTour.Text = seaTour[0].name;
                    dateS = seaTour[0].date_start.Split(' ');
                    tbDateStart.Text = dateS[0];
                    tbDays.Text = seaTour[0].day_tour.ToString();
                    tbCityDep.Text = seaTour[0].city_departure;
                    tbCountry.Text = seaTour[0].country;
                    tbCity.Text = seaTour[0].city;
                    maxPerson = seaTour[0].number;
                    price = seaTour[0].price;
                    hotel.Clear();
                    db.Execute<ClassHotel>(ref stp, "SELECT h.id_hotel,h.name_hotel,h.star_hotel,h.phone_hotel,co.name_country,ct.name_city FROM ((hotel h NATURAL JOIN city ct) NATURAL JOIN country co) WHERE ct.name_city='" + tbCity.Text + "'", ref hotel);
                    if (hotel.Count > 0)
                    {
                        for (int i = 0; i < hotel.Count; i++)
                            cbHotel.Items.Add(hotel[i].star_hotel + "* " + hotel[i].name_hotel);
                    }
                    break;
                case 2:
                    lblCountry.Visible = false;
                    lblExcursions.Visible = false;
                    lblCity.Visible = false;
                    lblHotel.Visible = false;
                    btnImg.Visible = false;
                    lblFood.Visible = false;
                    tbCountry.Visible = false;
                    tbCity.Visible = false;
                    tbExcursions.Visible = false;
                    cbFood.Visible = false;
                    cbHotel.Visible = false;
                    tbTypeTour.Text = "Морской круиз";
                    marinTour.Clear();
                    db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_tour=" + id, ref marinTour);
                    tbNameTour.Text = marinTour[0].name;
                    dateS = marinTour[0].date_start.Split(' ');
                    tbDateStart.Text = dateS[0];
                    tbDays.Text = marinTour[0].day_tour.ToString();
                    tbCityDep.Text = marinTour[0].city_departure;
                    tbWay.Text = marinTour[0].way_tour;
                    maxPerson = marinTour[0].number;
                    price = marinTour[0].price;
                    break;
                case 3:
                    lblCountry.Visible = false;
                    lblCity.Visible = false;
                    lblHotel.Visible = false;
                    btnImg.Visible = false;
                    lblFood.Visible = false;
                    tbCountry.Visible = false;
                    tbCity.Visible = false;
                    cbFood.Visible = false;
                    cbHotel.Visible = false;
                    tbTypeTour.Text = "Экскурсионный тур";
                    excursTour.Clear();
                    db.Execute<ClassExcursionsTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.excursions_tour, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_tour=" + id, ref excursTour);
                    tbNameTour.Text = excursTour[0].name;
                    dateS = excursTour[0].date_start.Split(' ');
                    tbDateStart.Text = dateS[0];
                    tbDays.Text = excursTour[0].day_tour.ToString();
                    tbCityDep.Text = excursTour[0].city_departure;
                    tbWay.Text = excursTour[0].way_tour;
                    tbExcursions.Text = excursTour[0].excursions;
                    maxPerson = excursTour[0].number;
                    price = excursTour[0].price;
                    break;
                case 4:
                    lblExcursions.Visible = false;
                    tbExcursions.Visible = false;
                    lblWay.Visible = false;
                    tbWay.Visible = false;
                    tbTypeTour.Text = "Горнолыжный курорт";
                    mountTour.Clear();
                    db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_tour=" + id, ref mountTour);
                    tbNameTour.Text = mountTour[0].name;
                    dateS = mountTour[0].date_start.Split(' ');
                    tbDateStart.Text = dateS[0];
                    tbDays.Text = mountTour[0].day_tour.ToString();
                    tbCityDep.Text = mountTour[0].city_departure;
                    tbCountry.Text = mountTour[0].country;
                    tbCity.Text = mountTour[0].city;
                    maxPerson = mountTour[0].number;
                    price = mountTour[0].price;
                    hotel.Clear();
                    db.Execute<ClassHotel>(ref stp, "SELECT h.id_hotel,h.name_hotel,h.star_hotel,h.phone_hotel,co.name_country,ct.name_city FROM ((hotel h NATURAL JOIN city ct) NATURAL JOIN country co) WHERE ct.name_city='" + tbCity.Text + "'", ref hotel);
                    if (hotel.Count > 0)
                    {
                        for (int i = 0; i < hotel.Count; i++)
                            cbHotel.Items.Add(hotel[i].star_hotel + "* " + hotel[i].name_hotel);
                    }
                    break;
                default:
                    break;
            }
        }

        private void formFormSale_Load(object sender, EventArgs e)
        {
            //Заполнение комбобокса сотрудника
            empl.Clear();
            db.Execute<ClassEmployee>(ref stp, "SELECT e.id_empl,e.fio_empl,e.phone_empl,e.adress_empl,e.series_pasp_empl,e.number_pasp_empl,p.name_position FROM employe e NATURAL JOIN position p", ref empl);
            if (empl.Count > 0)
                for (int i = 0; i < empl.Count; i++)
                    cbEmployee.Items.Add(empl[i].fio_empl);
            //Заполнение комбобокса клиента
            client.Clear();
            db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client", ref client);
            if (client.Count > 0)
                for (int i = 0; i < client.Count; i++)
                    cbClient.Items.Add(client[i].fio_client);
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbTour_Enter(object sender, EventArgs e)
        {

        }

        private void tbAdult_Leave(object sender, EventArgs e)
        {

            if (tbAdult.Text != "")
            {
                try
                {
                    Convert.ToInt32(tbAdult.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
                    tbAdult.Text = "";
                };
            }
            if (tbAdult.Text != "")
                if (Convert.ToInt32(tbAdult.Text) <= 0)
                {
                    MessageBox.Show("Вводимое значение не может быть отрицательным или равно 0!", "Ошибка");
                    tbAdult.Text = "";
                }
            if (tbAdult.Text != "")
                if (Convert.ToInt32(tbAdult.Text) > 10)
                {
                    MessageBox.Show("Вводимое количество не может превышать 10!", "Ошибка");
                    tbAdult.Text = "";
                }
        }

        private void tbChildren_Leave(object sender, EventArgs e)
        {
            if (tbChildren.Text != "")
                try
                {
                    Convert.ToInt32(tbChildren.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
                    tbChildren.Text = "";
                };
            if (tbChildren.Text != "")
                if (Convert.ToInt32(tbChildren.Text) <= 0)
                {
                    MessageBox.Show("Вводимое значение не может быть отрицательным!", "Ошибка");
                    tbChildren.Text = "";
                }
            if (tbChildren.Text != "")
                if (Convert.ToInt32(tbChildren.Text) > 92)
                {
                    MessageBox.Show("Вводимое количество не может превышать 10!", "Ошибка");
                    tbChildren.Text = "";
                }
        }

        private void cbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbFood.Items.Clear();
            food.Clear();
            string nameHotel = cbHotel.Text.Remove(0, 3);
            db.Execute<ClassCountry>(ref stp, "SELECT h.id_hotel,f.name_food FROM (hotel h NATURAL JOIN hotel_food hf) NATURAL JOIN food f WHERE h.name_hotel='" + nameHotel + "'", ref food);
            if (food.Count > 0)
            {
                for (int i = 0; i < food.Count(); i++)
                    cbFood.Items.Add(food[i].name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (typeT == 0 || typeT == 2 || typeT==3)
            {
                if (tbAdult.Text == "" || cbClient.Text == "" || cbEmployee.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else if (totalPrice == -1)
                    MessageBox.Show("Не расчитана стоимость тура!", "Ошибка");
                else
                {
                    int child = 0,numberSale;
                    if (tbChildren.Text != "")
                        child = Convert.ToInt32(tbChildren.Text);
                        //Количество путёвок
                        numberSale = Convert.ToInt32(tbAdult.Text);
                    if (tbChildren.Text != "")
                        numberSale += Convert.ToInt32(tbChildren.Text);
                    // id сотрудника и клиента
                    empl.Clear();
                    db.Execute<ClassEmployee>(ref stp, "SELECT e.id_empl,e.fio_empl,e.phone_empl,e.adress_empl,e.series_pasp_empl,e.number_pasp_empl,p.name_position FROM employe e NATURAL JOIN position p WHERE e.fio_empl='" + cbEmployee.Text + "'", ref empl);
                    client.Clear();
                    db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client WHERE fio_client='" + cbClient.Text + "'", ref client);
                    db.ExecuteNonQuery(ref stp, "INSERT INTO sale (date_sale,number_sale,id_client,id_empl,id_tour,id_status_sale,price) VALUES (NOW()," + numberSale.ToString() + "," + client[0].id_client.ToString() + "," + empl[0].id_empl.ToString() + "," + id.ToString() + ",4," + totalPrice.ToString() + ")");
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET number_tour=number_tour-"+tbAdult.Text+" WHERE id_tour="+id.ToString());
                    //Сериализация
                    contract.Clear();
                    db.Execute<ClassContract>(ref stp, "select s.id_sale, s.date_sale, c.fio_client, t.name_tour, t.date_start, t.day_tour,s.number_sale, s.price FROM sale s,tour t,client c Where s.id_tour=t.id_tour AND s.id_client=c.id_client ORDER BY s.id_sale desc limit 1", ref contract);
                    ClassSerialiaze.SerialiazeToXml<List<ClassContract>>(ref contract, "tour.xml");
                    formReport obj = new formReport(1);
                    obj.ShowDialog();
                }
            }
            else
            {
                if (tbAdult.Text == "" || cbClient.Text == "" || cbEmployee.Text == "" || cbHotel.Text == "" || cbFood.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else if (totalPrice == -1)
                    MessageBox.Show("Не расчитана стоимость тура!", "Ошибка");
                else
                {
                    //Количество путёвок
                    int numberSale = Convert.ToInt32(tbAdult.Text);
                    if (tbChildren.Text != "")
                        numberSale += Convert.ToInt32(tbChildren.Text);
                    // id сотрудника, клиента и отеля
                    empl.Clear();
                    db.Execute<ClassEmployee>(ref stp, "SELECT e.id_empl,e.fio_empl,e.phone_empl,e.adress_empl,e.series_pasp_empl,e.number_pasp_empl,p.name_position FROM employe e NATURAL JOIN position p WHERE e.fio_empl='" + cbEmployee.Text + "'", ref empl);
                    client.Clear();
                    db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client WHERE fio_client='" + cbClient.Text + "'", ref client);
                    string nameHotel = cbHotel.Text.Remove(0, 3);
                    hotel.Clear();
                    db.Execute<ClassHotel>(ref stp, "SELECT h.id_hotel,h.name_hotel,h.star_hotel,h.phone_hotel,co.name_country,ct.name_city FROM ((hotel h NATURAL JOIN city ct) NATURAL JOIN country co) WHERE h.name_hotel='" + nameHotel + "'", ref hotel);
                    db.ExecuteNonQuery(ref stp, "INSERT INTO sale (date_sale,number_sale,id_client,id_empl,id_tour,id_status_sale,price,id_hotel) VALUES (NOW()," + numberSale.ToString() + "," + client[0].id_client.ToString() + "," + empl[0].id_empl.ToString() + "," + id.ToString() + ",4," + totalPrice.ToString() + ","+hotel[0].id_hotel+")");
                    //Сериализация
                    contract.Clear();
                    db.Execute<ClassContract>(ref stp, "select s.id_sale, s.date_sale, c.fio_client, t.name_tour, t.date_start, t.day_tour,s.number_sale, s.price FROM sale s,tour t,client c Where s.id_tour=t.id_tour AND s.id_client=c.id_client ORDER BY s.id_sale desc limit 1", ref contract);
                    ClassSerialiaze.SerialiazeToXml<List<ClassContract>>(ref contract, "tour.xml");
                    formReport obj = new formReport(1);
                    obj.ShowDialog();
                }
            }

        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            formMDEmployee obj = new formMDEmployee();
            obj.Show();
            //Заполнение комбобокса сотрудника
            empl.Clear();
            cbEmployee.Items.Clear();
            db.Execute<ClassEmployee>(ref stp, "SELECT e.id_empl,e.fio_empl,e.phone_empl,e.adress_empl,e.series_pasp_empl,e.number_pasp_empl,p.name_position FROM employe e NATURAL JOIN position p", ref empl);
            if (empl.Count > 0)
                for (int i = 0; i < empl.Count; i++)
                    cbEmployee.Items.Add(empl[i].fio_empl);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            formMDClient obj = new formMDClient();
            obj.ShowDialog();
            //Заполнение комбобокса клиента
            client.Clear();
            cbClient.Items.Clear();
            db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client", ref client);
            if (client.Count > 0)
                for (int i = 0; i < client.Count; i++)
                     cbClient.Items.Add(client[i].fio_client);
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
          
            if (typeT == 0 || typeT == 2 || typeT == 3)
            {
                int child = 0;
                if (tbChildren.Text != "")
                    child = Convert.ToInt32(tbChildren.Text);
                if (tbAdult.Text == "" || cbClient.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else if (Convert.ToInt32(tbAdult.Text)+child > maxPerson)
                    MessageBox.Show("Недостаточно путёвок (всего " + maxPerson + ")", "Ошибка");
                else
                {
                   totalPrice = price * Convert.ToInt32(tbAdult.Text);
                    if (tbChildren.Text != "")
                        totalPrice += (price / 100 * 25) * Convert.ToInt32(tbChildren.Text);
                    //Если клиент постоянный то скидка 10 %
                    client.Clear();
                    db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client WHERE fio_client='" + cbClient.Text + "'", ref client);
                    if (client[0].discount == "Постоянный")
                        totalPrice -= totalPrice / 10;
                    lblPrice.Text = totalPrice.ToString() + " $";
                }
            }
            else
            {
                int child = 0;
                if (tbChildren.Text != "")
                    child = Convert.ToInt32(tbChildren.Text);
                if (tbAdult.Text == "" || cbClient.Text == "" || cbHotel.Text == "" || cbFood.Text == "")
                    MessageBox.Show("Введены не все поля!", "Ошибка");
                else if (Convert.ToInt32(tbAdult.Text)+child > maxPerson)
                    MessageBox.Show("Недостаточно путёвок (всего " + maxPerson + ")", "Ошибка");
                    else
                {
                    totalPrice = price * Convert.ToInt32(tbAdult.Text);
                    if (tbChildren.Text != "")
                        totalPrice += (price / 100 * 25) * Convert.ToInt32(tbChildren.Text);
                    //Изменение цены в зависимости от отеля и питания
                    if (cbHotel.Text[0] == '3')
                        totalPrice += (totalPrice / 100) * 5;
                    else if (cbHotel.Text[0] == '4')
                        totalPrice += (totalPrice / 100) * 7;
                    else if (cbHotel.Text[0] == '5')
                        totalPrice += (totalPrice / 100) * 12;
                    if (cbFood.Text == "RO")
                        totalPrice += (totalPrice / 100) * 3;
                    else if (cbFood.Text == "BB")
                        totalPrice += (totalPrice / 100) * 5;
                    else if (cbFood.Text == "HB")
                        totalPrice += (totalPrice / 100) * 7;
                    else if (cbFood.Text == "FB")
                        totalPrice += (totalPrice / 100) * 10;
                    else if (cbFood.Text == "AI")
                        totalPrice += (totalPrice / 100) * 13;
                    else if (cbFood.Text == "UAI")
                        totalPrice += (totalPrice / 100) * 15;
                    //Если клиент постоянный то скидка 10 %
                    client.Clear();
                    db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client WHERE fio_client='" + cbClient.Text + "'", ref client);
                    if (client[0].discount == "Постоянный")
                        totalPrice -= totalPrice / 10;
                    lblPrice.Text = totalPrice.ToString() + " $";
                }
            }
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            if (cbHotel.Text != "")
            {
                formGoogleImages obj = new formGoogleImages("Отель " + cbHotel.Text + " Город " + tbCity.Text);
                obj.ShowDialog();
            }
        }
    }
}
