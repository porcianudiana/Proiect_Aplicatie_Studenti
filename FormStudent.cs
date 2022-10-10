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
    public partial class FormStudent : Form
    {

        public Student st;
        public Form1 parinte;
        public FormStudent()
        {
            InitializeComponent();
           
           
        
        }

        OleDbConnection Conexiune = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\acasa\Desktop\Studenti_bd.accdb");
        public void actualizarec(object sender, EventArgs e)
        {
            ListView lista1 = (ListView)sender;
            if (lista1.SelectedItems.Count > 0)
                st = (Student)lista1.SelectedItems[0].Tag;


            if (st != null)
            {
                comboBoxSp.Text = st.Specializare;
                comboBoxFac.Text = st.Facultate;
                textBoxNumec.Text = st.NumePrenume;
                textBoxCNP.Text = st.Cnp;
                textBoxId.Text = st.Id;
                textBoxVarsta.Text = st.Varsta;
                
                


            }
        }


        private void buttonActualizare_Click(object sender, EventArgs e)
        {
            st.Specializare = comboBoxSp.Text;
            st.Facultate = comboBoxFac.Text;
            st.NumePrenume = textBoxNumec.Text;
            st.Cnp = textBoxCNP.Text;
            st.Id =textBoxId.Text;
            st.Varsta = textBoxVarsta.Text;
            
            this.parinte.UpdateItems();

            Conexiune.Open();

            OleDbCommand Comanda = Conexiune.CreateCommand();
            Comanda.CommandType = CommandType.Text;
            Comanda.CommandText= " insert into Studenti values('" + comboBoxSp.Text + "','" + comboBoxFac.Text + "','" + textBoxNumec.Text + "','" + textBoxCNP.Text + "','" + textBoxId.Text + "','" + textBoxVarsta.Text + "')";
            Comanda.ExecuteNonQuery();

            Conexiune.Close();
            MessageBox.Show("Sarcina s-a realizat cu succes! ", "Transfer date cu succes!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void textBoxNumec_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNumec.Text.Length < 3)
            {
                errorProvider1.SetError(textBoxNumec, "Numele introdus nu corespunde");
                e.Cancel = true;
            }
        }

        private void textBoxNumec_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxNumec, "");
        }

        private void textBoxCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider2.SetError(textBoxCNP, "Nu ati introdus corect CNP-ul.");
            }
            
                
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider3.SetError(textBoxId, "Nu ati introdus corect ID-ul.");
            }
        }

        private void textBoxVarsta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider4.SetError(textBoxVarsta, "Nu ati introdus corect varsta.");
            }

        }

        private void textBoxNumec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBoxNumec, "Numele introdus nu corespunde");

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(comboBoxSp.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 200));
            e.Graphics.DrawString(comboBoxFac.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 300));
            e.Graphics.DrawString(textBoxNumec.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 400));
            e.Graphics.DrawString(textBoxCNP.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 500));
            e.Graphics.DrawString(textBoxId.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 600));
            e.Graphics.DrawString(textBoxVarsta.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(100, 700));
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
    }
}
