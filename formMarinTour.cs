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
    public partial class formMarinTour : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassMarinTour> tour = new List<ClassMarinTour>();

        public formMarinTour()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            tour.Clear();
            db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=3 AND t.status_tour='Доступен'", ref tour);
        }

        void ShowData()
        {
            dgvMarinTour.Rows.Clear();
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    dgvMarinTour.Rows.Add(tour[i].id_tour, tour[i].name, tour[i].city_departure, tour[i].date_start, tour[i].day_tour, tour[i].way_tour, tour[i].operator_name, tour[i].price);
                    cbCityDep.Items.Add(tour[i].city_departure);
                    cbVisitCity.Items.Add(tour[i].way_tour);
                }
            }
            dgvMarinTour.CurrentCell = null;
            lblFindNumber.Text = "Найдено предложений: " + tour.Count;
        }

        private void formMarinTour_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (dgvMarinTour.CurrentRow == null)
                MessageBox.Show("Выберите тур!", "Ошибка");
            else
            {
                formFormSale obj = new formFormSale(Convert.ToInt32(dgvMarinTour.CurrentRow.Cells[0].Value.ToString()), 2);
                obj.ShowDialog();
            }
        }

        private void cbCityDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVisitCity.Items.Clear();
            if (!cbCityDep.SelectedIndex.Equals(0))
            {
                tour.Clear();
                db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour,t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o WHERE t.id_type_tour=3 AND t.status_tour='Доступен' AND t.city_departure='" + cbCityDep.SelectedItem + "'", ref tour);
                if (tour.Count > 0)
                {
                    cbVisitCity.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbVisitCity.Items.Add(tour[i].way_tour);
                    }
                }
            }
            else
            {
                tour.Clear();
                db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o WHERE t.id_type_tour=3 AND t.status_tour='Доступен'", ref tour);
                if (tour.Count > 0)
                {
                    cbVisitCity.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbVisitCity.Items.Add(tour[i].way_tour);
                    }
                }
            }
        }

        private void cbVisitCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCityDep.Items.Clear();
            if (!cbVisitCity.SelectedIndex.Equals(0))
            {
                tour.Clear();
                db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour,t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o WHERE t.id_type_tour=3 AND t.status_tour='Доступен' AND t.way_tour='" + cbVisitCity.SelectedItem + "'", ref tour);
                if (tour.Count > 0)
                {
                    cbCityDep.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbCityDep.Items.Add(tour[i].city_departure);
                    }
                }
            }
            else
            {
                tour.Clear();
                db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o WHERE t.id_type_tour=3 AND t.status_tour='Доступен'", ref tour);
                if (tour.Count > 0)
                {
                    cbCityDep.Items.Add("");
                    for (int i = 0; i < tour.Count; i++)
                    {
                        cbCityDep.Items.Add(tour[i].city_departure);
                    }
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string query = "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o WHERE t.id_type_tour=3 AND t.status_tour='Доступен'";
            if (!cbCityDep.SelectedIndex.Equals(-1) && !cbCityDep.SelectedIndex.Equals(0))
                query += " AND t.city_departure='" + cbCityDep.SelectedItem + "'";
            if (!cbVisitCity.SelectedIndex.Equals(-1) && !cbVisitCity.SelectedIndex.Equals(0))
                query += " AND t.way_tour='" + cbVisitCity.SelectedItem + "'";
            if (chckbDate.Checked)
                query += " AND YEAR(t.date_start)=" + dtpDateDep.Value.Year + " AND Month(t.date_start)=" + dtpDateDep.Value.Month + " AND DAY(t.date_start)=" + dtpDateDep.Value.Day;
            if (chckbDays.Checked)
                query += " AND t.day_tour=" + nudNumberDays.Value;
            if (chchbAdult.Checked)
                query += " AND number_tour >= " + nudAdult.Value;
            tour.Clear();
            db.Execute<ClassMarinTour>(ref stp, query, ref tour);
            dgvMarinTour.Rows.Clear();
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    dgvMarinTour.Rows.Add(tour[i].id_tour, tour[i].name, tour[i].city_departure, tour[i].date_start, tour[i].day_tour, tour[i].way_tour, tour[i].operator_name, tour[i].price);
                }
            }
            dgvMarinTour.CurrentCell = null;
            lblFindNumber.Text = "Найдено предложений: " + tour.Count;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbCityDep.Items.Clear();
            cbCityDep.Items.Add("");
            cbVisitCity.Items.Clear();
            cbVisitCity.Items.Add("");
            LoadData();
            ShowData();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {
            formInteractiveBusMarinExcursionTour obj = new formInteractiveBusMarinExcursionTour(2);
            obj.ShowDialog();
        }
    }
}
