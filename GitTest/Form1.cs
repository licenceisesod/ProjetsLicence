using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            int nbre1, nbre2, som;
            nbre1 = Convert.ToInt32(n1.Text);
            nbre2 =Convert.ToInt32( n2.Text);
            som = nbre1 + nbre2;
            MessageBox.Show("la somme de ces deux nombres est : "+ som);
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            int nbre1, nbre2, sous;
            nbre1 = Convert.ToInt32(n1.Text);
            nbre2 = Convert.ToInt32(n2.Text);
            sous = nbre1 - nbre2;
            MessageBox.Show("la soustraction de ces deux nombres est : " + sous);
        }
    }
}
