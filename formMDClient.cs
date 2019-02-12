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
    public partial class formMDClient : Form
    {
        public int idChange = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();

        public formMDClient()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        public formMDClient(int id,string name,string passp,string phone,string adress)
        {
            InitializeComponent();
            btnAdd.Visible = false;
            idChange = id;
            tbFIO.Text = name;
            tbPhone.Text = phone;
            tbAdress.Text = adress;
            string[] pass = passp.Split(' ');
            tbSeriesPasp.Text = pass[0];
            tbNumberPasp.Text = pass[1];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<ClassClient> client = new List<ClassClient>();
            client.Clear();
            db.Execute<ClassClient>(ref stp, "SELECT id_client,fio_client,phone_client,series_pasp_client,number_pasp_client,discount,adress_client FROM client WHERE  series_pasp_client='" + tbSeriesPasp.Text + "' AND number_pasp_client='" + tbNumberPasp.Text + "'", ref client);

            if (tbFIO.Text == "" || tbSeriesPasp.Text == "" || tbNumberPasp.Text == "")
                MessageBox.Show("Введены не все поля!", "Ошибка");
            else if (client.Count>0)
            {
                MessageBox.Show("Клиент с таким паспортом уже существует!");
            }
            else {
                db.ExecuteNonQuery(ref stp,"INSERT INTO client (fio_client,phone_client,series_pasp_client,number_pasp_client,adress_client,discount) VALUES ('"+tbFIO.Text+"','"+tbPhone.Text+"','"+tbSeriesPasp.Text+"','"+tbNumberPasp.Text+"','"+tbAdress.Text+"','Обычный')");
                tbAdress.Text = "";
                tbFIO.Text = "";
                tbNumberPasp.Text = "";
                tbPhone.Text = "";
                tbSeriesPasp.Text = "";
                MessageBox.Show("Успешно!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (tbFIO.Text == "" || tbSeriesPasp.Text == "" || tbNumberPasp.Text == "")
                MessageBox.Show("Введены не все поля!", "Ошибка");
            else
            {
                db.ExecuteNonQuery(ref stp, "UPDATE client SET fio_client='" + tbFIO.Text + "',phone_client='" + tbPhone.Text + "',series_pasp_client='" + tbSeriesPasp.Text + "',number_pasp_client='" + tbNumberPasp.Text + "',adress_client='" + tbAdress.Text + "' WHERE id_client="+idChange);
                MessageBox.Show("Успешно!");
            }
        }

        private void formMDClient_Load(object sender, EventArgs e)
        {

        }

        private void tbNumberPasp_Leave(object sender, EventArgs e)
        {
            if (tbNumberPasp.Text != "")
                try
                {
                    int x = Convert.ToInt32(tbNumberPasp.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Допускается ввод только цифр!","Ошибка");
                    tbNumberPasp.Text = "";
                };
        }

        private void tbSeriesPasp_TextChanged(object sender, EventArgs e)
        {
            if (tbSeriesPasp.Text != "")
            {
                bool isLetter = true;
                for (int i = 0; i < tbSeriesPasp.TextLength; i++)
                {
                    if (!Char.IsLetter(tbSeriesPasp.Text[i])) isLetter = false;
                }
                if (!isLetter)
                {
                    tbSeriesPasp.Text = "";
                    MessageBox.Show("Допускается ввод только букв!");
                }
            }
        }
    }
}
