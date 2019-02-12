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
    public partial class btnMode : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassMountainTour> tour = new List<ClassMountainTour>();

        public btnMode()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            tour.Clear();
            db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен'", ref tour);
        }

        void ShowData()
        {
            //Заполнение dgv
            dgvMountTour.Rows.Clear();
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    dgvMountTour.Rows.Add(tour[i].id_tour, tour[i].name, tour[i].city_departure, tour[i].date_start, tour[i].day_tour, tour[i].country, tour[i].city, tour[i].operator_name, tour[i].price);
                }
            }
            //Заполнение комбобоксов
            tour.Clear();
            db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен' GROUP BY t.city_departure", ref tour);
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    cbCityDep.Items.Add(tour[i].city_departure);
                }
            }
            tour.Clear();
            db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен' GROUP BY co.name_country", ref tour);
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    cbCountry.Items.Add(tour[i].country);
                }
            }
            tour.Clear();
            db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен' GROUP BY ct.name_city", ref tour);
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    cbCity.Items.Add(tour[i].city);
                }
            }
            dgvMountTour.CurrentCell = null;
            lblFindNumber.Text = "Найдено предложений: "+tour.Count;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formMountainTour_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }

        private void cbCityDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCountry.Items.Clear();
            if (!cbCityDep.SelectedIndex.Equals(0))
            {
                tour.Clear();
                db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен' AND t.city_departure='" + cbCityDep.SelectedItem + "'", ref tour);
                if (tour.Count > 0)
                {
                    cbCountry.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbCountry.Items.Add(tour[i].country);
                    }
                }
            }
            else
            {
                tour.Clear();
                db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен'", ref tour);
                if (tour.Count > 0)
                {
                    cbCountry.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbCountry.Items.Add(tour[i].country);
                    }
                }
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCityDep.Items.Clear();
            cbCity.Items.Clear();
            if (!cbCountry.SelectedIndex.Equals(0))
            {
                tour.Clear();
                db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен' AND co.name_country='" + cbCountry.SelectedItem + "'", ref tour);
                if (tour.Count > 0)
                {
                    cbCityDep.Items.Add("");
                    cbCity.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbCityDep.Items.Add(tour[i].city_departure);
                        cbCity.Items.Add(tour[i].city);
                    }
                }
            }
            else
            {
                tour.Clear();
                db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен'", ref tour);
                if (tour.Count > 0)
                {
                    cbCityDep.Items.Add("");
                    cbCity.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbCityDep.Items.Add(tour[i].city_departure);
                        cbCity.Items.Add(tour[i].city);
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            tour.Clear();
            Boolean andOr = true;
            string query = "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN (city ct NATURAL JOIN hotel h NATURAL JOIN hotel_food hf NATURAL JOIN food f)) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND t.status_tour='Доступен'";
            if (!cbCityDep.SelectedIndex.Equals(-1) && !cbCityDep.SelectedIndex.Equals(0))
                query += " AND t.city_departure='" + cbCityDep.SelectedItem + "'";
            if (!cbCountry.SelectedIndex.Equals(-1) && !cbCountry.SelectedIndex.Equals(0))
                query += " AND co.name_country='" + cbCountry.SelectedItem + "'";
            if (!cbCity.SelectedIndex.Equals(-1) && !cbCity.SelectedIndex.Equals(0))
                query += " AND ct.name_city='" + cbCity.SelectedItem + "'";
            //Сортировка по отелю
            if (chkbStar.Checked)
            {
                if (rbFiveStars.Checked)
                {
                    query += " AND (h.star_hotel=5";
                    andOr = false;
                }
                if (rbFourStars.Checked)
                    if (andOr)
                    {
                        query += " AND (h.star_hotel=4";
                        andOr = false;
                    }
                    else query += " OR h.star_hotel=4";
                if (rbThreeStars.Checked)
                    if (andOr)
                    {
                        query += " AND (h.star_hotel=3";
                        andOr = false;
                    }
                    else query += " OR h.star_hotel=3";
                if (rbTwoStars.Checked)
                    if (andOr)
                    {
                        query += " AND (h.star_hotel=2";
                        andOr = false;
                    }
                    else query += " OR h.star_hotel=2";
                if (!andOr) query += ")";
                andOr = true;
            }
            if (chkbFood.Checked)
            {
                if (rbUAI.Checked)
                {
                    query += " AND (hf.id_food=6";
                    andOr = false;
                }
                if (rbAI.Checked)
                    if (andOr)
                    {
                        query += " AND (hf.id_food=5";
                        andOr = false;
                    }
                    else query += " OR hf.id_food=5";
                if (rbFB.Checked)
                    if (andOr)
                    {
                        query += " AND (hf.id_food=4";
                        andOr = false;
                    }
                    else query += " OR hf.id_food=4";
                if (rbHB.Checked)
                    if (andOr)
                    {
                        query += " AND (hf.id_food=3";
                        andOr = false;
                    }
                    else query += " OR hf.id_food=3";
                if (rbBB.Checked)
                    if (andOr)
                    {
                        query += " AND (hf.id_food=2";
                        andOr = false;
                    }
                    else query += " OR hf.id_food=2";
                if (rbRO.Checked)
                    if (andOr)
                    {
                        query += " AND (hf.id_food=1";
                        andOr = false;
                    }
                    else query += " OR hf.id_food=1";
                if (!andOr) query += ")";
            }
            if (tbMaxPrice.Text != "")
                query += " AND t.price<= " + Convert.ToInt32(tbMaxPrice.Text);
            if (chkbDate.Checked)
                query += " AND t.day_tour=" + nudNumberDays.Value + " AND YEAR(date_start)=" + dtpDateDep.Value.Year + " AND Month(date_start)=" + dtpDateDep.Value.Month + " AND DAY(date_start)=" + dtpDateDep.Value.Day;
            if (chkbAdult.Checked)
                query += " AND t.number_tour > " + nudAdult.Value;
            query += " GROUP BY t.id_tour";
            db.Execute<ClassMountainTour>(ref stp, query, ref tour);
            dgvMountTour.Rows.Clear();
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    dgvMountTour.Rows.Add(tour[i].id_tour, tour[i].name, tour[i].city_departure, tour[i].date_start, tour[i].day_tour, tour[i].country, tour[i].city, tour[i].operator_name, tour[i].price);
                }
            }
            dgvMountTour.CurrentCell = null;
            lblFindNumber.Text = "Найдено предложений: " + tour.Count;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbCityDep.Items.Clear();
            cbCityDep.Items.Add("");
            cbCountry.Items.Clear();
            cbCountry.Items.Add("");
            cbCity.Items.Clear();
            cbCity.Items.Add("");
            LoadData();
            ShowData();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (dgvMountTour.CurrentRow == null)
                MessageBox.Show("Выберите тур!", "Ошибка");
            else
            {
                formFormSale obj = new formFormSale(Convert.ToInt32(dgvMountTour.CurrentRow.Cells[0].Value.ToString()), 4);
                obj.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInteractiveSeaMountTour obj = new formInteractiveSeaMountTour(false);
            obj.ShowDialog();
        }
    }
}
