using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incercare_proiect
{
    public partial class FormProfesor : Form
    {
        public FormProfesor()
        {
            InitializeComponent();
            Profesor p1 = new Profesor("Nicolae Mihnea", "Economie", "10000", "Finante");
            Profesor p2 = new Profesor("Cristea Anca", "Matematica", "20000", "Matematici Aplicate");
            Profesor p3 = new Profesor("Dobre Alexandru", "Informatica", "30000", "Informatica si Cibernetica Economica");
            Profesor p4 = new Profesor("Popa Alina", "Economotrie", "40000", "Statistica si Econometrie");
            Profesor p5 = new Profesor("Serban Marian", "Baze de date", "50000", "Informatica si Cibernetica Economica");
            ListViewItem lv1 = new ListViewItem(p1.NumePrenumeProf);
            lv1.SubItems.Add(p1.SpecializareProf);
            lv1.SubItems.Add(p1.Cod);
            lv1.SubItems.Add(p1.Departament);

            lv1.Tag = p1;


            ListViewItem lv2 = new ListViewItem(p2.NumePrenumeProf);
            lv2.SubItems.Add(p2.SpecializareProf);
            lv2.SubItems.Add(p2.Cod);
            lv2.SubItems.Add(p2.Departament);

            lv2.Tag = p2;


            ListViewItem lv3 = new ListViewItem(p3.NumePrenumeProf);
            lv3.SubItems.Add(p3.SpecializareProf);
            lv3.SubItems.Add(p3.Cod);
            lv3.SubItems.Add(p3.Departament);

            lv3.Tag = p3;

            ListViewItem lv4 = new ListViewItem(p4.NumePrenumeProf);
            lv4.SubItems.Add(p4.SpecializareProf);
            lv4.SubItems.Add(p4.Cod);
            lv4.SubItems.Add(p4.Departament);

            lv4.Tag = p4;


            ListViewItem lv5 = new ListViewItem(p5.NumePrenumeProf);
            lv5.SubItems.Add(p5.SpecializareProf);
            lv5.SubItems.Add(p5.Cod);
            lv5.SubItems.Add(p5.Departament);

            lv5.Tag = p5;

            listViewProf.Items.Add(lv1);
            listViewProf.Items.Add(lv2);
            listViewProf.Items.Add(lv3);
            listViewProf.Items.Add(lv4);
            listViewProf.Items.Add(lv5);
        }

        private void editareProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditareProf fp = new FormEditareProf();
            fp.parinte2 = this;
            listViewProf.SelectedIndexChanged += new EventHandler(fp.actualizarecontroaleprof);
            fp.actualizarecontroaleprof(listViewProf, e);
            fp.ShowDialog();
        }

        public void UpdateItemsprof()
        {
            foreach (ListViewItem lvi in listViewProf.Items)
            {
                Profesor p = (Profesor)lvi.Tag;
                lvi.Text = p.NumePrenumeProf;
                lvi.SubItems[1].Text = p.SpecializareProf;
                lvi.SubItems[2].Text = p.Cod;
                lvi.SubItems[3].Text = p.Departament;
              
            }
        }

        private void adaugareProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { " ", " ", " ", " ", " " });
            listViewProf.Items.Add(lvi);
            lvi.Selected = true;
            Profesor p = new Profesor();
            lvi.Tag = p;
            FormEditareProf fp = new FormEditareProf();
            fp.prof = p;
            fp.buttonactdate.Text = "Adauga";
            fp.parinte2 = this;
            fp.ShowDialog();


            if (fp.DialogResult != DialogResult.OK)
                lvi.Remove();
        }

        private void stergereProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProf.SelectedItems.Count > 0)
            {
                Profesor p = (Profesor)listViewProf.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Doriti sa stergeti profesorul " + p.NumePrenumeProf + "?",
                  "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) listViewProf.SelectedItems[0].Remove();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salvareDateProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare profesori (*.profesori)|*.profesori";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Profesor> lista = listViewProf.Items.Cast<ListViewItem>()
                    .Select(item => (Profesor)item.Tag)
                    .ToList();
                serializator.Serialize(fb, lista);
                fb.Close();
            }
        }

        private void restaurareDateProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare profesori (*.profesori)| *.profesori";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.OpenRead(fd.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                List<Profesor> lista = (List<Profesor>)deserializator.Deserialize(fb);


                listViewProf.Items.Clear();

                foreach (Profesor p in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "" });
                    lvi.Tag = p;
                    listViewProf.Items.Add(lvi);


                }
                UpdateItemsprof();
                fb.Close();
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }
    }
}
