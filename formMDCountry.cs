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
    public partial class formMDCountry : Form
    {
        public int idChange = 0;
        ClassDataBase db = new ClassDataBase();
        ClassSetupProgram stp = new ClassSetupProgram();

        public formMDCountry()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }

        public formMDCountry(int id, string name)
        {
            InitializeComponent();
            idChange = id;
            tbName.Text = name;
            btnAdd.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                MessageBox.Show("Не введено название страны!", "Ошибка");
            else
            {
                db.ExecuteNonQuery(ref stp,"UPDATE country SET name_country='"+tbName.Text+"' WHERE id_country="+idChange);
                MessageBox.Show("Успешно!");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
                MessageBox.Show("Не введено название страны!","Ошибка");
            else
            {
                db.ExecuteNonQuery(ref stp,"INSERT INTO country(name_country) VALUES('"+tbName.Text+"')");
                tbName.Text = "";
                MessageBox.Show("Успешно!");
            }
        }
    }
}
