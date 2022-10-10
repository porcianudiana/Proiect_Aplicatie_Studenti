namespace incercare_proiect
{
    partial class FormProfesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewProf = new System.Windows.Forms.ListView();
            this.chNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chspecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDepartament = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelProf = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareDateProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareDateProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareDateProfesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProf
            // 
            this.listViewProf.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNume,
            this.chspecializare,
            this.chCod,
            this.chDepartament});
            this.listViewProf.GridLines = true;
            this.listViewProf.HideSelection = false;
            this.listViewProf.Location = new System.Drawing.Point(55, 150);
            this.listViewProf.MultiSelect = false;
            this.listViewProf.Name = "listViewProf";
            this.listViewProf.Size = new System.Drawing.Size(790, 189);
            this.listViewProf.TabIndex = 0;
            this.listViewProf.UseCompatibleStateImageBehavior = false;
            this.listViewProf.View = System.Windows.Forms.View.Details;
            // 
            // chNume
            // 
            this.chNume.Text = "Nume Profesor";
            this.chNume.Width = 150;
            // 
            // chspecializare
            // 
            this.chspecializare.Text = "Specializare Profesor";
            this.chspecializare.Width = 150;
            // 
            // chCod
            // 
            this.chCod.Text = "Cod";
            this.chCod.Width = 100;
            // 
            // chDepartament
            // 
            this.chDepartament.Text = "Departament";
            this.chDepartament.Width = 200;
            // 
            // labelProf
            // 
            this.labelProf.AutoSize = true;
            this.labelProf.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProf.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelProf.Location = new System.Drawing.Point(50, 97);
            this.labelProf.Name = "labelProf";
            this.labelProf.Size = new System.Drawing.Size(103, 27);
            this.labelProf.TabIndex = 1;
            this.labelProf.Text = "Profesori";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.editareDateProfesoriToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareDateProfesorToolStripMenuItem,
            this.restaurareDateProfesorToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareDateProfesorToolStripMenuItem
            // 
            this.salvareDateProfesorToolStripMenuItem.Name = "salvareDateProfesorToolStripMenuItem";
            this.salvareDateProfesorToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.salvareDateProfesorToolStripMenuItem.Text = "Salvare date profesor";
            this.salvareDateProfesorToolStripMenuItem.Click += new System.EventHandler(this.salvareDateProfesorToolStripMenuItem_Click);
            // 
            // restaurareDateProfesorToolStripMenuItem
            // 
            this.restaurareDateProfesorToolStripMenuItem.Name = "restaurareDateProfesorToolStripMenuItem";
            this.restaurareDateProfesorToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.restaurareDateProfesorToolStripMenuItem.Text = "Restaurare date profesor";
            this.restaurareDateProfesorToolStripMenuItem.Click += new System.EventHandler(this.restaurareDateProfesorToolStripMenuItem_Click);
            // 
            // editareDateProfesoriToolStripMenuItem
            // 
            this.editareDateProfesoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProfesorToolStripMenuItem,
            this.stergereProfesorToolStripMenuItem,
            this.editareProfesorToolStripMenuItem});
            this.editareDateProfesoriToolStripMenuItem.Name = "editareDateProfesoriToolStripMenuItem";
            this.editareDateProfesoriToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.editareDateProfesoriToolStripMenuItem.Text = "Editare date profesori";
            // 
            // adaugareProfesorToolStripMenuItem
            // 
            this.adaugareProfesorToolStripMenuItem.Name = "adaugareProfesorToolStripMenuItem";
            this.adaugareProfesorToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.adaugareProfesorToolStripMenuItem.Text = "Adaugare profesor";
            this.adaugareProfesorToolStripMenuItem.Click += new System.EventHandler(this.adaugareProfesorToolStripMenuItem_Click);
            // 
            // stergereProfesorToolStripMenuItem
            // 
            this.stergereProfesorToolStripMenuItem.Name = "stergereProfesorToolStripMenuItem";
            this.stergereProfesorToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.stergereProfesorToolStripMenuItem.Text = "Stergere profesor";
            this.stergereProfesorToolStripMenuItem.Click += new System.EventHandler(this.stergereProfesorToolStripMenuItem_Click);
            // 
            // editareProfesorToolStripMenuItem
            // 
            this.editareProfesorToolStripMenuItem.Name = "editareProfesorToolStripMenuItem";
            this.editareProfesorToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.editareProfesorToolStripMenuItem.Text = "Editare profesor";
            this.editareProfesorToolStripMenuItem.Click += new System.EventHandler(this.editareProfesorToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1172, 476);
            this.Controls.Add(this.labelProf);
            this.Controls.Add(this.listViewProf);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProfesor";
            this.Text = "FormProfesor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProf;
        private System.Windows.Forms.ColumnHeader chNume;
        private System.Windows.Forms.ColumnHeader chspecializare;
        private System.Windows.Forms.ColumnHeader chCod;
        private System.Windows.Forms.ColumnHeader chDepartament;
        private System.Windows.Forms.Label labelProf;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editareDateProfesoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareDateProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareDateProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}