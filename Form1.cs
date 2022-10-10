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
    public partial class Form1 : Form
    {
        TreeNode t;
        public Form1()
        {
            InitializeComponent();
            Student s1 = new Student("Cibernetica", "CSIE","Popa Mihai", "5000814033790", "500",  "20");
            Student s2 = new Student("Informatica Economica", "CSIE","Luca Andreea", "2981216217903", "510",  "22");
            Student s3 = new Student("Informatica Economica", "CSIE","Necula Ion", "5010609300593", "520", "20");
            Student s4 = new Student("Statistica", "CSIE", "Ion Gabriel", "1971215399499", "660", "23");
            Student s5 = new Student("Statistica", "CSIE", "Manole Andreea", "2990506361930", "670", "22");
            Disciplina d1 = new Disciplina("Informatica economica","CSIE","SGBD", "Obligatoriu");
            Disciplina d2 = new Disciplina("Informatica economica","CSIE","PAW",  "Obligatoriu");
            Disciplina d3 = new Disciplina("Management", "Management", "Managementul riscului in afaceri internationale", "Optional");
            Disciplina d4 = new Disciplina("Cibernetica","CSIE","Macroeconomie",  "Obligatoriu");
            Disciplina d5 = new Disciplina("Statistica","CSIE","Econometrie","Obligatoriu");
            Disciplina d6 = new Disciplina("Limbi straine","Relatii internationale","Limba franceza","Facultativa");
            Disciplina d7 = new Disciplina("Informatica economica","CSIE","Java","Obligatoriu");
            Nota n1 = new Nota("10");
            Nota n2 = new Nota("9");
            Nota n3 = new Nota("8");
            Nota n4 = new Nota("7");
            Nota n5 = new Nota("6");
            Nota n6 = new Nota("5");
            Nota n7 = new Nota("4");
            Nota n8 = new Nota("3");
            Nota n9 = new Nota("2");
            Nota n10 = new Nota("1");


            ListViewItem lv1 = new ListViewItem(s1.NumePrenume);
            lv1.SubItems.Add(s1.Cnp);
            lv1.SubItems.Add(s1.Id);
            lv1.SubItems.Add(s1.Specializare);
            lv1.SubItems.Add(s1.Varsta);

            lv1.Tag = s1;


            ListViewItem lv2 = new ListViewItem(s2.NumePrenume);
            lv2.SubItems.Add(s2.Cnp);
            lv2.SubItems.Add(s2.Id);
            lv2.SubItems.Add(s2.Specializare);
            lv2.SubItems.Add(s2.Varsta);

            lv2.Tag = s2;

            ListViewItem lv3 = new ListViewItem(s3.NumePrenume);
            lv3.SubItems.Add(s3.Cnp);
            lv3.SubItems.Add(s3.Id);
            lv3.SubItems.Add(s3.Specializare);
            lv3.SubItems.Add(s3.Varsta);

            lv3.Tag = s3;


            ListViewItem lv4 = new ListViewItem(s4.NumePrenume);
            lv4.SubItems.Add(s4.Cnp);
            lv4.SubItems.Add(s4.Id);
            lv4.SubItems.Add(s4.Specializare);
            lv4.SubItems.Add(s4.Varsta);

            lv4.Tag = s4;

            ListViewItem lv5 = new ListViewItem(s5.NumePrenume);
            lv5.SubItems.Add(s5.Cnp);
            lv5.SubItems.Add(s5.Id);
            lv5.SubItems.Add(s5.Specializare);
            lv5.SubItems.Add(s5.Varsta);

            lv5.Tag = s5;

            listView1.Items.Add(lv1);
            listView1.Items.Add(lv2);
            listView1.Items.Add(lv3);
            listView1.Items.Add(lv4);
            listView1.Items.Add(lv5);

            ListViewItem lvi1 = new ListViewItem(new string[] { d1.Materie, d1.Specializare, d1.GradObligativitate });
            lvi1.Tag = d1;
            listvNotediscipline.Items.Add(lvi1);


            ListViewItem lvi2 = new ListViewItem(new string[] { d2.Materie, d2.Specializare, d2.GradObligativitate });
            lvi2.Tag = d2;
            listvNotediscipline.Items.Add(lvi2);



            ListViewItem lvi3 = new ListViewItem(new string[] { d3.Materie, d3.Specializare, d3.GradObligativitate });
            lvi3.Tag = d3;
            listvNotediscipline.Items.Add(lvi3);


            ListViewItem lvi4 = new ListViewItem(new string[] { d4.Materie, d4.Specializare, d4.GradObligativitate });
            lvi4.Tag = d4;
            listvNotediscipline.Items.Add(lvi4);


            ListViewItem lvi5 = new ListViewItem(new string[] { d5.Materie, d5.Specializare, d5.GradObligativitate });
            lvi5.Tag = d5;
            listvNotediscipline.Items.Add(lvi5);

            ListViewItem lvi6 = new ListViewItem(new string[] { d6.Materie, d6.Specializare, d6.GradObligativitate });
            lvi6.Tag = d6;
            listvNotediscipline.Items.Add(lvi6);

            ListViewItem lvi7 = new ListViewItem(new string[] { d7.Materie, d7.Specializare, d7.GradObligativitate });
            lvi7.Tag = d7;
            listvNotediscipline.Items.Add(lvi7);

            TreeNode t1 = treeView1.Nodes.Add(s1.NumePrenume + " " + s1.Id);
            t1.Tag = s1;

            TreeNode t2 = treeView1.Nodes.Add(s2.NumePrenume + " " + s2.Id);
            t2.Tag = s2;


            TreeNode t3 = treeView1.Nodes.Add(s3.NumePrenume + " " + s3.Id);
            t3.Tag = s3;

            TreeNode t4 = treeView1.Nodes.Add(s4.NumePrenume + " " + s4.Id);
            t4.Tag = s4;

            TreeNode t5 = treeView1.Nodes.Add(s5.NumePrenume + " " + s5.Id);
            t5.Tag = s5;

            ListViewItem lvl1 = new ListViewItem(n1.nota);
            lvl1.Tag = n1;
            ListViewItem lvl2 = new ListViewItem(n2.nota);
            lvl2.Tag = n2;
            ListViewItem lvl3 = new ListViewItem(n3.nota);
            lvl3.Tag = n3;
            ListViewItem lvl4 = new ListViewItem(n4.nota);
            lvl4.Tag = n4;
            ListViewItem lvl5 = new ListViewItem(n5.nota);
            lvl5.Tag = n5;
            ListViewItem lvl6 = new ListViewItem(n6.nota);
            lvl6.Tag = n6;
            ListViewItem lvl7 = new ListViewItem(n7.nota);
            lvl7.Tag = n7;
            ListViewItem lvl8 = new ListViewItem(n8.nota);
            lvl8.Tag = n8;
            ListViewItem lvl9 = new ListViewItem(n9.nota);
            lvl9.Tag = n9;
            ListViewItem lvl10 = new ListViewItem(n10.nota);
            lvl10.Tag = n10;
            listViewNote.Items.Add(lvl1);
            listViewNote.Items.Add(lvl2);
            listViewNote.Items.Add(lvl3);
            listViewNote.Items.Add(lvl4);
            listViewNote.Items.Add(lvl5);
            listViewNote.Items.Add(lvl6);
            listViewNote.Items.Add(lvl7);
            listViewNote.Items.Add(lvl8);
            listViewNote.Items.Add(lvl9);
            listViewNote.Items.Add(lvl10);
        }

        private void informatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfesor fp = new FormProfesor();
            fp.ShowDialog();
        }

        

        private void listvNotediscipline_MouseDown(object sender, MouseEventArgs e)
        {
            if (listvNotediscipline.SelectedItems.Count > 0)
            {
                listvNotediscipline.DoDragDrop(listvNotediscipline.SelectedItems[0], DragDropEffects.Copy);
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            Point px = new Point(listView1.PointToClient(new Point(e.X, e.Y)).X,
                listView1.PointToClient(new Point(e.X, e.Y)).Y);
            ListViewItem lv = listView1.GetItemAt(px.X, px.Y);
            if (lv != null)
            {
                Disciplina d = (Disciplina)((ListViewItem)e.Data.GetData(typeof(ListViewItem))).Tag;

                Orar orar = new Orar((Student)lv.Tag, d);

                List<TreeNode> listanoduri = treeView1.Nodes.Cast<TreeNode>().ToList();

                TreeNode nodstudent = listanoduri.Find(s => ((Student)s.Tag).Specializare ==orar.stud.Specializare );

                TreeNode torar = nodstudent.Nodes.Add(orar.disc.Materie + " " + orar.disc.GradObligativitate);

                torar.Tag = orar;
            }



        }

        private void listViewNote_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(listViewNote.SelectedItems, DragDropEffects.Copy);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode n;

            if (e.Data.GetDataPresent("System.Windows.Forms.ListView+SelectedListViewItemCollection", false))
            {
                Point pt = ((TreeView)sender).PointToClient(new Point(e.X, e.Y));
                TreeNode dn = ((TreeView)sender).GetNodeAt(pt);
                ListView.SelectedListViewItemCollection lvl = (ListView.SelectedListViewItemCollection)e.Data.GetData("System.Windows.Forms.ListView+SelectedListViewItemCollection");

                foreach (ListViewItem item in lvl)
                {
                    n = new TreeNode(item.Text);
                    n.Tag = item;

                    dn.Nodes.Add((TreeNode)n.Clone());
                    dn.Expand();
                    n.Remove();
                }
            }
        }

        private void editareStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStudent fs = new FormStudent();
            fs.parinte = this;
            listView1.SelectedIndexChanged += new EventHandler(fs.actualizarec);
            fs.actualizarec(listView1, e);
            fs.ShowDialog();
        }


        public void UpdateItems()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                Student s = (Student)lvi.Tag;
                lvi.Text = s.NumePrenume;
                lvi.SubItems[1].Text = s.Cnp;
                lvi.SubItems[2].Text = s.Id;
                lvi.SubItems[3].Text = s.Specializare;
                lvi.SubItems[4].Text = s.Varsta;
            }
        }

        private void adaugareStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(new string[] { " ", " ", " ", " "," "," " });
            listView1.Items.Add(lvi);
            lvi.Selected = true;
            Student s = new Student();
            lvi.Tag = s;
            FormStudent fs = new FormStudent();
            fs.st = s;
            fs.buttonActualizare.Text = "Adauga";
            fs.parinte = this;
            fs.ShowDialog();


            if (fs.DialogResult != DialogResult.OK)
                lvi.Remove();
        }

        private void stergereStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                Student s = (Student)listView1.SelectedItems[0].Tag;
                DialogResult rezultat = MessageBox.Show("Doriti sa stergeti studentul " + s.NumePrenume + "?",
                  "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (rezultat == DialogResult.Yes) listView1.SelectedItems[0].Remove();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salvareStudentBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare studenti (*.studenti)|*.studenti";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.Create(fd.FileName);
                BinaryFormatter serializator = new BinaryFormatter();
                List<Student> lista = listView1.Items.Cast<ListViewItem>()
                    .Select(item => (Student)item.Tag)
                    .ToList();
                serializator.Serialize(fb, lista);
                fb.Close();
            }
        }

        private void restaurareStudentBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Filter = "fisiere binare studenti (*.studenti)| *.studenti";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fb = File.OpenRead(fd.FileName);
                BinaryFormatter deserializator = new BinaryFormatter();
                List<Student> lista = (List<Student>)deserializator.Deserialize(fb);


                listView1.Items.Clear();

                foreach (Student s in lista)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", "", "", "","","" });
                    lvi.Tag = s;
                    listView1.Items.Add(lvi);


                }
                UpdateItems();
                fb.Close();
            }
        }

        private void adaugareStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adaugareStudentToolStripMenuItem_Click( sender, e);

        }

        private void stergereStudentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            stergereStudentToolStripMenuItem_Click( sender, e);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHome fh = new FormHome();
            fh.ShowDialog();
        }

        private void profesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
