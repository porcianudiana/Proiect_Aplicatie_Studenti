using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace incercare_proiect
{
    public partial class FormEditareProf : Form
    {
        public Profesor prof;
        public FormProfesor parinte2;
        public FormEditareProf()
        {
            InitializeComponent();
        }

        OleDbConnection Conexiune = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\acasa\Desktop\Studenti_bd.accdb");
        public void actualizarecontroaleprof(object sender, EventArgs e)
        {
            ListView lista1 = (ListView)sender;
            if (lista1.SelectedItems.Count > 0)
                prof = (Profesor)lista1.SelectedItems[0].Tag;


            if (prof != null)
            {
                
                textBox1.Text = prof.NumePrenumeProf;
                textBox2.Text = prof.SpecializareProf;
                textBox3.Text = prof.Cod;
                comboBox1.Text = prof.Departament;




            }
        }

        private void buttonactdate_Click(object sender, EventArgs e)
        {
            prof.NumePrenumeProf = textBox1.Text;
            prof.SpecializareProf = textBox2.Text;
            prof.Cod = textBox3.Text;
            prof.Departament = comboBox1.Text;

            this.parinte2.UpdateItemsprof();

            Conexiune.Open();

            OleDbCommand Comanda = Conexiune.CreateCommand();
            Comanda.CommandType = CommandType.Text;
            Comanda.CommandText = " insert into Profesori values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox1.Text +"')";
            Comanda.ExecuteNonQuery();

            Conexiune.Close();
            MessageBox.Show("Sarcina s-a realizat cu succes! ", "Transfer date cu succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length < 3)
            {
                errorProvider1.SetError(textBox1, "Numele profesorului nu este corect introdus.");
                e.Cancel = true;
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox1, "Numele profesorului nu este corect introdus.");

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(textBox2, "Specializarea nu este corect introdusa.");

            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                errorProvider3.SetError(textBox3, "Nu ati introdus corect codul.");
            }
        }

        private void FormEditareProf_Load(object sender, EventArgs e)
        {

        }
    }
}
