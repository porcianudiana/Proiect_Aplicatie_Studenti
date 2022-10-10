using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incercare_proiect
{
    public partial class FormMedii : Form
    {
        public FormMedii()
        {
            InitializeComponent();
            Medii m1 = new Medii("Informatica Economica","CSIE","Macroeconomie","Obligatoriu",8.33);
            Medii m2 = new Medii("Statistica", "CSIE", "Econometrie", "Obligatoriu", 7.7);
            Medii m3 = new Medii("Informatica economica", "CSIE", "SGBD", "Obligatoriu", 7.90);
            Medii m4 = new Medii("Management", "Management", "Managementul riscului in afaceri internationale", "Optional", 8.78);
            Medii m5 = new Medii("Informatica economica", "CSIE", "PAW", "Obligatoriu", 9.13);
            Medii m6 = new Medii("Limbi straine", "Relatii internationale", "Limba franceza", "Facultativa", 9);
            Medii m7 = new Medii("Informatica economica", "CSIE", "Java", "Obligatoriu",7);

            ListViewItem lv1 = new ListViewItem(new string[] { m1.Materie, Convert.ToString(m1.nota)});
            lv1.Tag = m1;
            listView1.Items.Add(lv1);


            ListViewItem lv2 = new ListViewItem(new string[] { m2.Materie, Convert.ToString(m2.nota) });
            lv2.Tag = m2;
            listView1.Items.Add(lv2);

            ListViewItem lv3 = new ListViewItem(new string[] { m3.Materie, Convert.ToString(m3.nota) });
            lv3.Tag = m3;
            listView1.Items.Add(lv3);

            ListViewItem lv4 = new ListViewItem(new string[] { m4.Materie, Convert.ToString(m4.nota) });
            lv4.Tag = m4;
            listView1.Items.Add(lv4);

            ListViewItem lv5 = new ListViewItem(new string[] { m5.Materie, Convert.ToString(m5.nota) });
            lv5.Tag = m5;
            listView1.Items.Add(lv5);

            ListViewItem lv6 = new ListViewItem(new string[] { m6.Materie, Convert.ToString(m6.nota) });
            lv6.Tag = m6;
            listView1.Items.Add(lv6);

            ListViewItem lv7 = new ListViewItem(new string[] { m7.Materie, Convert.ToString(m7.nota) });
            lv7.Tag = m7;
            listView1.Items.Add(lv7);

        }
        

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }

        
    }
}
