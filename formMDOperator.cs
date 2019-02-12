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
    public partial class formMDOperator : Form
    {
        public int idChange = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();
        List<ClassCountry> country = new List<ClassCountry>();

        public formMDOperator()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        public formMDOperator(int id,string name,string countr,string fio,string phon)
        {
            InitializeComponent();
            btnAdd.Visible = false;
            idChange = id;
            tbName.Text = name;
            tbFIO.Text = fio;
            tbPhone.Text = phon;
            cbCountry.Text = countr;
        }

        private void formMDOperator_Load(object sender, EventArgs e)
        {
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

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbFIO.Text == "")
                MessageBox.Show("Введены не все поля", "Ошибка");
            else
            {
                db.ExecuteNonQuery(ref stp,"INSERT INTO operator(name_operator,country_operator,fio_contact_operator,phone_contact_operator) VALUES ('"+tbName.Text+"','"+cbCountry.Text+"','"+tbFIO.Text+"','"+tbPhone.Text+"')");
                tbName.Text = "";
                tbFIO.Text = "";
                tbPhone.Text = "";
                cbCountry.Text = "";
                MessageBox.Show("Успешно!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbFIO.Text == "" || tbPhone.Text == "" || cbCountry.Text == "")
                MessageBox.Show("Введены не все поля", "Ошибка");
            else
            {
                db.ExecuteNonQuery(ref stp, "UPDATE operator SET name_operator='" + tbName.Text + "',country_operator='" + cbCountry.Text + "',fio_contact_operator='" + tbFIO.Text + "',phone_contact_operator='" + tbPhone.Text + "' WHERE id_operator="+idChange);
                MessageBox.Show("Успешно!");
            }
        }
    }
}
