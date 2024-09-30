using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro.models;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Person> persons;
        public Form1()
        {
            InitializeComponent();
            persons = new List<Person>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.FirstName = tbFirstName.Text;
            person.LastName = tbLastName.Text;
            person.BirthDay = DateTime.Parse(dtpBirthDay.Text);
            persons.Add(person);
            ShowPersons();
            ClearTb();
        }
        private void ShowPersons()
        {
            dgvShow.DataSource = null;
            dgvShow.DataSource = persons;
        }
        private void ClearTb()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            dtpBirthDay.Value = DateTime.Now;
            tbFirstName.Focus();
        }
    }
}
