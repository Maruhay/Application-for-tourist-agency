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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Resources.SaleT obj = new Resources.SaleT();
            obj.ShowDialog();
        }

        private void btnFindTour_Click(object sender, EventArgs e)
        {
            Resources.SearchTour obj = new Resources.SearchTour();
            obj.ShowDialog();
        }

        private void btnManageData_Click(object sender, EventArgs e)
        {
            Resources.rbCity obj = new Resources.rbCity();
            obj.ShowDialog();
        }

        private void btnConstructor_Click(object sender, EventArgs e)
        {
            formConstructor obj = new formConstructor();
            obj.ShowDialog();
        }

        private void formMain_Enter(object sender, EventArgs e)
        {
        }

        private void formMain_Load(object sender, EventArgs e)
        {

            ClassDataBase db = new ClassDataBase();
            ClassSetupProgram stp = new ClassSetupProgram();
            List<ClassBusTour> tour = new List<ClassBusTour>();
            List<ClassClient> client = new List<ClassClient>();
            List<ClassSale> sale = new List<ClassSale>();
            //Проверка туров на доступность
            tour.Clear();
            db.Execute<ClassBusTour>(ref stp, "SELECT t.id_tour, t.name_tour, t.price, t.date_start, t.day_tour, t.city_departure, t.way_tour, o.name_operator, t.number_tour, t.status_tour FROM tour t NATURAL JOIN operator o  WHERE t.number_tour<=0 OR t.date_start<NOW()", ref tour);
            if (tour.Count > 0)
            {
                for (int i = 0; i < tour.Count; i++)
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE tour SET status_tour='Не доступен' WHERE id_tour=" + tour[i].id_tour);
                }
            }
            //Проверка клиентов на постоянность
            client.Clear();
            db.Execute<ClassClient>(ref stp, "SELECT c.id_client,c.fio_client,c.phone_client,c.series_pasp_client,c.number_pasp_client,c.discount,c.adress_client FROM client c NATURAL JOIN sale s GROUP BY s.id_client HAVING Count(s.id_client)>2", ref client);
            if (client.Count > 0)
            {
                for (int i = 0; i < client.Count(); i++)
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE client SET discount='Постоянный' WHERE id_client=" + client[i].id_client);
                }
            }
            //Проверка на состояние заказа
            sale.Clear();
            db.Execute<ClassSale>(ref stp, "SELECT sale.id_sale, sale.date_sale, sale.id_client, sale.id_empl, sale.id_tour, client.fio_client, employe.fio_empl, tour.name_tour, type_tour.name_type_tour, sale.number_sale, s.price, status_sale.status_sale FROM sale INNER JOIN client ON sale.id_client = client.id_client INNER JOIN employe ON sale.id_empl = employe.id_empl INNER JOIN tour ON sale.id_tour = tour.id_tour INNER JOIN type_tour ON tour.id_type_tour = type_tour.id_type_tour INNER JOIN status_sale ON sale.id_status_sale = status_sale.id_status_sale WHERE CURDATE() BETWEEN tour.date_start AND DATE_ADD(tour.date_start,INTERVAL tour.day_tour day)", ref sale);
            if (sale.Count > 0)
            {
                for (int i = 0; i > sale.Count; i++)
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE sale SET id_status_sale=2");
                }
            }
            sale.Clear();
            db.Execute<ClassSale>(ref stp, "SELECT sale.id_sale, sale.date_sale, sale.id_client, sale.id_empl, sale.id_tour, client.fio_client, employe.fio_empl, tour.name_tour, type_tour.name_type_tour, sale.number_sale, (sale.number_sale*tour.price), status_sale.status_sale FROM sale INNER JOIN client ON sale.id_client = client.id_client INNER JOIN employe ON sale.id_empl = employe.id_empl INNER JOIN tour ON sale.id_tour = tour.id_tour INNER JOIN type_tour ON tour.id_type_tour = type_tour.id_type_tour INNER JOIN status_sale ON sale.id_status_sale = status_sale.id_status_sale WHERE CURDATE()> DATE_ADD(tour.date_start,INTERVAL tour.day_tour day)", ref sale);
            if (sale.Count > 0)
            {
                for (int i = 0; i > sale.Count; i++)
                {
                    db.ExecuteNonQuery(ref stp, "UPDATE sale SET id_status_sale=3");
                }
            }
        }
    }
}
