using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boimatov_pm
{
    public partial class viborUrovna : Form
    {
        public viborUrovna()
        {
            InitializeComponent();
        }

        private void spo_But_Click(object sender, EventArgs e)
        {
            spo sp = new spo();
            this.Hide();
            sp.ShowDialog();    
            this.Show();
            this.Close();
        }

        private void bacalavr_but_Click(object sender, EventArgs e)
        {
            bacalavr sp = new bacalavr();
            this.Hide();
            sp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void specialitet_but_Click(object sender, EventArgs e)
        {
            specialitet sp = new specialitet();
            this.Hide();
            sp.ShowDialog();
            this.Show();
            this.Close();
        }

        private void magistr_but_Click(object sender, EventArgs e)
        {
            magistr sp = new magistr();
            this.Hide();
            sp.ShowDialog();
            this.Show();
            this.Close();
        }
    }
}
