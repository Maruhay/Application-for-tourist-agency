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
    public partial class formMDEmployee : Form
    {
        public int idChange = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassPosition> pos = new List<ClassPosition>();

        public formMDEmployee()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        public formMDEmployee(int id, string fio, string posit, string passport, string phone, string adress)
        {
            InitializeComponent();
            btnAdd.Visible = false;
            idChange = id;
            tbFIO.Text = fio;
            tbPhone.Text = phone;
            tbAdress.Text = adress;
            string[] pass = passport.Split(' ');
            tbSeriesPasp.Text = pass[0];
            tbNumberPasp.Text = pass[1];
            cbPosition.Text = posit;
        }

        private void formMDEmployee_Load(object sender, EventArgs e)
        {
            pos.Clear();
            db.Execute<ClassPosition>(ref stp, "SELECT id_position,name_position FROM position", ref pos);
            if (pos.Count > 0)
            {
                for (int i = 0; i < pos.Count; i++)
                {
                    cbPosition.Items.Add(pos[i].name);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<ClassEmployee> empl = new List<ClassEmployee>();
            empl.Clear();
            db.Execute<ClassEmployee>(ref stp, "SELECT e.id_empl,e.fio_empl,e.phone_empl,e.adress_empl,e.series_pasp_empl,e.number_pasp_empl,p.name_position FROM employe e NATURAL JOIN position p WHERE e.series_pasp_empl='" + tbSeriesPasp.Text + "' AND e.number_pasp_empl='" + tbNumberPasp.Text + "'", ref empl);

            if (tbFIO.Text == "" || tbNumberPasp.Text == "" || tbSeriesPasp.Text == "" || cbPosition.Text == "")
                MessageBox.Show("Введены не все поля!", "Ошибка");
            else if (empl.Count > 0)
            {
                MessageBox.Show("Сотрудник с таким паспортом уже существует!");
            }
            else
            {
                db.Execute<ClassPosition>(ref stp, "SELECT id_position,name_position FROM position WHERE name_position='" + cbPosition.Text + "'", ref pos);
                db.ExecuteNonQuery(ref stp, "INSERT INTO employe(fio_empl,phone_empl,adress_empl,series_pasp_empl,number_pasp_empl,id_position) VALUES ('" + tbFIO.Text + "','" + tbPhone.Text + "','" + tbAdress.Text + "','" + tbSeriesPasp.Text + "','" + tbNumberPasp.Text + "'," + pos[0].id + ")");
                tbAdress.Text = "";
                tbFIO.Text = "";
                tbNumberPasp.Text = "";
                tbPhone.Text = "";
                tbSeriesPasp.Text = "";
                cbPosition.Text = "";
                MessageBox.Show("Успешно!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text == "" || tbNumberPasp.Text == "" || tbSeriesPasp.Text == "" || cbPosition.Text == "")
                MessageBox.Show("Введены не все поля!", "Ошибка");
            else
            {
                db.Execute<ClassPosition>(ref stp, "SELECT id_position,name_position FROM position WHERE name_position='" + cbPosition.Text + "'", ref pos);
                db.ExecuteNonQuery(ref stp, "UPDATE employe SET fio_empl='" + tbFIO.Text + "',phone_empl='" + tbPhone.Text + "',adress_empl='" + tbAdress.Text + "',series_pasp_empl='" + tbSeriesPasp.Text + "',number_pasp_empl='" + tbNumberPasp.Text + "',id_position=" + pos[0].id + " WHERE id_empl=" + idChange);
                MessageBox.Show("Успешно!");
            }
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
                    MessageBox.Show("Допускается ввод только цифр!", "Ошибка");
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
