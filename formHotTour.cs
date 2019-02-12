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
    public partial class formHotTour : Form
    {
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassBusTour> busTour = new List<ClassBusTour>();
        List<ClassSeaTour> seaTour = new List<ClassSeaTour>();
        List<ClassExcursionsTour> excursTour = new List<ClassExcursionsTour>();
        List<ClassMarinTour> marinTour = new List<ClassMarinTour>();
        List<ClassMountainTour> mountTour = new List<ClassMountainTour>();
        List<ClassTypeTour> typeTour = new List<ClassTypeTour>();

        public formHotTour()
        {
            InitializeComponent();
        }

        private void formHotTour_Load(object sender, EventArgs e)
        {
            busTour.Clear();
            seaTour.Clear();
            excursTour.Clear();
            mountTour.Clear();
            marinTour.Clear();
            dgvHotTour.Rows.Clear();
            db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=1 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start", ref busTour);
            if (busTour.Count > 0)
            { 
                for (int i = 0; i < busTour.Count; i++)
                {
                    dgvHotTour.Rows.Add(busTour[i].id_tour, "Автобусный тур", busTour[i].name, busTour[i].city_departure ,busTour[i].date_start, busTour[i].day_tour, busTour[i].way_tour,"","","",busTour[i].price);
                }
            }
            db.Execute<ClassSeaTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=2 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start", ref seaTour);
            if (seaTour.Count > 0)
            {
                for (int i = 0; i < seaTour.Count; i++)
                {
                    dgvHotTour.Rows.Add(seaTour[i].id_tour, "Отдых на море", seaTour[i].name,seaTour[i].city_departure, seaTour[i].date_start, seaTour[i].day_tour, "","",seaTour[i].country,seaTour[i].city,seaTour[i].price);
                }

            }
            db.Execute<ClassExcursionsTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.excursions_tour, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=4 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start", ref excursTour);
            if (excursTour.Count > 0)
            {
                for (int i = 0; i < excursTour.Count; i++)
                {
                    dgvHotTour.Rows.Add(excursTour[i].id_tour, "Экскурсионный тур", excursTour[i].name, excursTour[i].city_departure ,excursTour[i].date_start, excursTour[i].day_tour, excursTour[i].way_tour, excursTour[i].excursions,"","", excursTour[i].price);
                }
            }
            db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start", ref mountTour);
            if (mountTour.Count > 0)
            {
                for (int i = 0; i < mountTour.Count; i++)
                {
                    dgvHotTour.Rows.Add(mountTour[i].id_tour, "Горнолыжный курорт", mountTour[i].name, mountTour[i].city_departure, mountTour[i].date_start, mountTour[i].day_tour,"", "", mountTour[i].country, mountTour[i].city, mountTour[i].price);
                }
            }
            db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=3 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day) >= date_start", ref marinTour);
            if (marinTour.Count > 0)
            {
                for (int i = 0; i < marinTour.Count; i++)
                {
                    dgvHotTour.Rows.Add(marinTour[i].id_tour, "Морской круиз", marinTour[i].name, marinTour[i].city_departure, marinTour[i].date_start, marinTour[i].day_tour, marinTour[i].way_tour,"","","",marinTour[i].price);
                }
            }
            lblFoundNumber.Text = "Найдено вариантов: "+(marinTour.Count + mountTour.Count + excursTour.Count + seaTour.Count + busTour.Count).ToString();
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

        private void lblPersons_Click(object sender, EventArgs e)
        {

        }

        private void nudPerson_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTypeTour_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (cbTypeTour.Text == "") formHotTour_Load(sender, e);
            else if (cbTypeTour.SelectedIndex == 1)
            {
                busTour.Clear();
                dgvHotTour.Rows.Clear();
                db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=1 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start", ref busTour);
                if (busTour.Count > 0)
                {
                    for (int i = 0; i < busTour.Count; i++)
                    {
                        dgvHotTour.Rows.Add(busTour[i].id_tour, "Автобусный тур", busTour[i].name, busTour[i].city_departure, busTour[i].date_start, busTour[i].day_tour, busTour[i].way_tour, "", "", "", busTour[i].price);
                    }
                }
                lblFoundNumber.Text = "Найдено вариантов: " + busTour.Count.ToString();
            }
            else if (cbTypeTour.SelectedIndex == 2)
            {
                seaTour.Clear();
                dgvHotTour.Rows.Clear();
                db.Execute<ClassSeaTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=2 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day) >= date_start AND number_tour>" + nudPerson.Value.ToString(), ref seaTour);
                if (seaTour.Count > 0)
                {
                    for (int i = 0; i < seaTour.Count; i++)
                    {
                        dgvHotTour.Rows.Add(seaTour[i].id_tour, "Отдых на море", seaTour[i].name, seaTour[i].city_departure, seaTour[i].date_start, seaTour[i].day_tour, "", "", seaTour[i].country, seaTour[i].city, seaTour[i].price);
                    }
                }
                lblFoundNumber.Text = "Найдено вариантов: " + seaTour.Count.ToString();
            }
            else if (cbTypeTour.SelectedIndex == 3)
            {
                marinTour.Clear();
                dgvHotTour.Rows.Clear();
                db.Execute<ClassMarinTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=3 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start AND number_tour>" + nudPerson.Value.ToString(), ref marinTour);
                if (marinTour.Count > 0)
                {
                    for (int i = 0; i < marinTour.Count; i++)
                    {
                        dgvHotTour.Rows.Add(marinTour[i].id_tour, "Морской круиз", marinTour[i].name, marinTour[i].city_departure, marinTour[i].date_start, marinTour[i].day_tour, marinTour[i].way_tour, "", "", "", marinTour[i].price);
                    }
                    lblFoundNumber.Text = "Найдено вариантов: " + marinTour.Count.ToString();
                }
                lblFoundNumber.Text = "Найдено вариантов: " + marinTour.Count.ToString();
            }
            else if (cbTypeTour.SelectedIndex == 4)
            {
                excursTour.Clear();
                dgvHotTour.Rows.Clear();
                db.Execute<ClassExcursionsTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.excursions_tour, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.id_type_tour=4 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start AND number_tour>" + nudPerson.Value.ToString(), ref excursTour);
                if (excursTour.Count > 0)
                {
                    for (int i = 0; i < excursTour.Count; i++)
                    {
                        dgvHotTour.Rows.Add(excursTour[i].id_tour, "Экскурсионный тур", excursTour[i].name, excursTour[i].city_departure, excursTour[i].date_start, excursTour[i].day_tour, excursTour[i].way_tour, excursTour[i].excursions, "", "", excursTour[i].price);
                    }
                }
                lblFoundNumber.Text = "Найдено вариантов: " + excursTour.Count.ToString();
            }
            else if (cbTypeTour.SelectedIndex == 5)
            {
                mountTour.Clear();
                dgvHotTour.Rows.Clear();
                db.Execute<ClassMountainTour>(ref stp, "SELECT t.id_tour, t.name_tour,t.price,t.date_start,t.day_tour,t.city_departure,co.name_country,ct.name_city,o.name_operator, t.number_tour, t.status_tour FROM (((tour t NATURAL JOIN city ct) NATURAL JOIN country co) NATURAL JOIN operator o) WHERE t.id_type_tour=5 AND status_tour='Доступен' AND DATE_ADD(NOW(), INTERVAL 5 day)>= date_start AND number_tour>" + nudPerson.Value.ToString(), ref mountTour);
                if (mountTour.Count > 0)
                {
                    for (int i = 0; i < mountTour.Count; i++)
                    {
                        dgvHotTour.Rows.Add(mountTour[i].id_tour, "Горнолыжный курорт", mountTour[i].name, mountTour[i].city_departure, mountTour[i].date_start, mountTour[i].day_tour, "", "", mountTour[i].country, mountTour[i].city, mountTour[i].price);
                    }
                }
                lblFoundNumber.Text = "Найдено вариантов: " + mountTour.Count.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbTypeTour.Items.Clear();
            cbTypeTour.Items.Add(" ");
            dgvHotTour.Rows.Clear();
            formHotTour_Load(sender, e);
        }

        private void cbTypeTour_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (dgvHotTour.CurrentRow == null)
                MessageBox.Show("Выберите тур!", "Ошибка");
            else
            {
                typeTour.Clear();
                db.Execute<ClassTypeTour>(ref stp, "SELECT id_type_tour,name_type_tour FROM type_tour WHERE name_type_tour='" + dgvHotTour.CurrentRow.Cells[1].Value.ToString() + "'", ref typeTour);
                formFormSale obj = new formFormSale(Convert.ToInt32(dgvHotTour.CurrentRow.Cells[0].Value.ToString()), (typeTour[0].id - 1));
                obj.ShowDialog();
            }
        }

        private void dgvHotTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
