using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadSaViseFormi
{
    public partial class UnosNovogStudenta : Form
    {
        private Student student1;
        public Student Student1
        {
            get
            {
                return student1;
            }
            set
            {
                student1 = value;
            }
        }
        public UnosNovogStudenta()
        {
            InitializeComponent();
        }

        private void UnosNovogStudenta_Load(object sender, EventArgs e)
        {

        }

        private void btnSnimi_Click(object sender, EventArgs e)
        {
            student1 = new Student();
            student1.Ime = txtIme.Text;
            student1.Prezime = txtPrezime.Text;
            student1.BrojIndeksa = txtIndeks.Text;
            student1.Smjer = cmbSmjer.SelectedItem.ToString();
            student1.DatumRodjenja = dtmRodjenja.Value; 
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
