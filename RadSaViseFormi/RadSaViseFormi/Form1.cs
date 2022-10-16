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
    public partial class Studenti : Form
    {
        public Studenti()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            UnosNovogStudenta frm = new UnosNovogStudenta();
            DialogResult rez = frm.ShowDialog();

            if (rez == System.Windows.Forms.DialogResult.OK)
                listBox1.Items.Add(frm.Student1.ToString());
        }

        private void btnObrisiSve_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnObrisiStud_Click(object sender, EventArgs e)
        {
            if (!(listBox1.SelectedIndex < 1))
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
