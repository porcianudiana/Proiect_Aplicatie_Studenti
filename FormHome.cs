using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace incercare_proiect
{
    public partial class FormHome : Form
    {  
        //pentru a face marginea formului rotunda

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );
        public FormHome()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelnav.Height = btndashboard.Height;
            panelnav.Top = btndashboard.Top;
            panelnav.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelnav.Height = btndashboard.Height;
            panelnav.Top = btndashboard.Top;
            panelnav.Left = btndashboard.Left;
            btndashboard.BackColor = Color.FromArgb(46, 51, 73);

            FormHome fh = new FormHome();
            fh.ShowDialog();

        }

        private void btnstudenti_Click(object sender, EventArgs e)
        {
            panelnav.Height = btnstudenti.Height;
            panelnav.Top = btnstudenti.Top;
            btnstudenti.BackColor = Color.FromArgb(46, 51, 73);

            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnprofesori_Click(object sender, EventArgs e)
        {
            panelnav.Height = btnprofesori.Height;
            panelnav.Top = btnprofesori.Top;
            btnprofesori.BackColor = Color.FromArgb(46, 51, 73);

            FormProfesor fprof = new FormProfesor();
            fprof.ShowDialog();

        }
        private void buttonMedii_Click(object sender, EventArgs e)
        {
            panelnav.Height = buttonMedii.Height;
            panelnav.Top = buttonMedii.Top;
            buttonMedii.BackColor = Color.FromArgb(46, 51, 73);

            FormMedii fm = new FormMedii();
            fm.ShowDialog();

        }

        private void btndashboard_Leave(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnstudenti_Leave(object sender, EventArgs e)
        {
            btnstudenti.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnprofesori_Leave(object sender, EventArgs e)
        {
            btnprofesori.BackColor = Color.FromArgb(24, 30, 54);
        }
        private void buttonMedii_Leave(object sender, EventArgs e)
        {
            buttonMedii.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void buttonclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
