namespace incercare_proiect
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCnp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpecializare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVarsta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareStudentBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurareStudentBinarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listvNotediscipline = new System.Windows.Forms.ListView();
            this.columnHeaderDisciplina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProfil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderOb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewNote = new System.Windows.Forms.ListView();
            this.columnHeaderNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adaugareStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereStudentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNume,
            this.columnHeaderCnp,
            this.columnHeaderId,
            this.columnHeaderSpecializare,
            this.columnHeaderVarsta});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(66, 103);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 230);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            // 
            // columnHeaderNume
            // 
            this.columnHeaderNume.Text = "Nume";
            this.columnHeaderNume.Width = 80;
            // 
            // columnHeaderCnp
            // 
            this.columnHeaderCnp.Text = "CNP";
            this.columnHeaderCnp.Width = 120;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            // 
            // columnHeaderSpecializare
            // 
            this.columnHeaderSpecializare.Text = "Specializare";
            this.columnHeaderSpecializare.Width = 120;
            // 
            // columnHeaderVarsta
            // 
            this.columnHeaderVarsta.Text = "Varsta";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisiereToolStripMenuItem,
            this.disciplineToolStripMenuItem,
            this.profesoriToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1477, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareStudentBinarToolStripMenuItem,
            this.restaurareStudentBinarToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareStudentBinarToolStripMenuItem
            // 
            this.salvareStudentBinarToolStripMenuItem.Name = "salvareStudentBinarToolStripMenuItem";
            this.salvareStudentBinarToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.salvareStudentBinarToolStripMenuItem.Text = "Salvare Student binar";
            this.salvareStudentBinarToolStripMenuItem.Click += new System.EventHandler(this.salvareStudentBinarToolStripMenuItem_Click);
            // 
            // restaurareStudentBinarToolStripMenuItem
            // 
            this.restaurareStudentBinarToolStripMenuItem.Name = "restaurareStudentBinarToolStripMenuItem";
            this.restaurareStudentBinarToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.restaurareStudentBinarToolStripMenuItem.Text = "Restaurare Student binar";
            this.restaurareStudentBinarToolStripMenuItem.Click += new System.EventHandler(this.restaurareStudentBinarToolStripMenuItem_Click);
            // 
            // disciplineToolStripMenuItem
            // 
            this.disciplineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareStudentToolStripMenuItem,
            this.stergereStudentToolStripMenuItem,
            this.editareStudentToolStripMenuItem});
            this.disciplineToolStripMenuItem.Name = "disciplineToolStripMenuItem";
            this.disciplineToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.disciplineToolStripMenuItem.Text = "Studenti";
            // 
            // adaugareStudentToolStripMenuItem
            // 
            this.adaugareStudentToolStripMenuItem.Name = "adaugareStudentToolStripMenuItem";
            this.adaugareStudentToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.adaugareStudentToolStripMenuItem.Text = "Adaugare Student";
            this.adaugareStudentToolStripMenuItem.Click += new System.EventHandler(this.adaugareStudentToolStripMenuItem_Click);
            // 
            // stergereStudentToolStripMenuItem
            // 
            this.stergereStudentToolStripMenuItem.Name = "stergereStudentToolStripMenuItem";
            this.stergereStudentToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.stergereStudentToolStripMenuItem.Text = "Stergere Student";
            this.stergereStudentToolStripMenuItem.Click += new System.EventHandler(this.stergereStudentToolStripMenuItem_Click);
            // 
            // editareStudentToolStripMenuItem
            // 
            this.editareStudentToolStripMenuItem.Name = "editareStudentToolStripMenuItem";
            this.editareStudentToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.editareStudentToolStripMenuItem.Text = "Editare Student";
            this.editareStudentToolStripMenuItem.Click += new System.EventHandler(this.editareStudentToolStripMenuItem_Click);
            // 
            // profesoriToolStripMenuItem
            // 
            this.profesoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informatiiToolStripMenuItem});
            this.profesoriToolStripMenuItem.Name = "profesoriToolStripMenuItem";
            this.profesoriToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.profesoriToolStripMenuItem.Text = "Profesori";
            this.profesoriToolStripMenuItem.Click += new System.EventHandler(this.profesoriToolStripMenuItem_Click);
            // 
            // informatiiToolStripMenuItem
            // 
            this.informatiiToolStripMenuItem.Name = "informatiiToolStripMenuItem";
            this.informatiiToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.informatiiToolStripMenuItem.Text = "Informatii si setari";
            this.informatiiToolStripMenuItem.Click += new System.EventHandler(this.informatiiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Studenți";
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(66, 379);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(492, 222);
            this.treeView1.TabIndex = 3;
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            // 
            // listvNotediscipline
            // 
            this.listvNotediscipline.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderDisciplina,
            this.columnHeaderProfil,
            this.columnHeaderOb});
            this.listvNotediscipline.FullRowSelect = true;
            this.listvNotediscipline.GridLines = true;
            this.listvNotediscipline.HideSelection = false;
            this.listvNotediscipline.Location = new System.Drawing.Point(781, 103);
            this.listvNotediscipline.Name = "listvNotediscipline";
            this.listvNotediscipline.Size = new System.Drawing.Size(550, 230);
            this.listvNotediscipline.TabIndex = 4;
            this.listvNotediscipline.UseCompatibleStateImageBehavior = false;
            this.listvNotediscipline.View = System.Windows.Forms.View.Details;
            this.listvNotediscipline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listvNotediscipline_MouseDown);
            // 
            // columnHeaderDisciplina
            // 
            this.columnHeaderDisciplina.Text = "Disciplina";
            this.columnHeaderDisciplina.Width = 150;
            // 
            // columnHeaderProfil
            // 
            this.columnHeaderProfil.Text = "Profil";
            this.columnHeaderProfil.Width = 150;
            // 
            // columnHeaderOb
            // 
            this.columnHeaderOb.Text = "Obligativitate";
            this.columnHeaderOb.Width = 100;
            // 
            // listViewNote
            // 
            this.listViewNote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNota});
            this.listViewNote.GridLines = true;
            this.listViewNote.HideSelection = false;
            this.listViewNote.Location = new System.Drawing.Point(674, 379);
            this.listViewNote.Name = "listViewNote";
            this.listViewNote.Size = new System.Drawing.Size(137, 253);
            this.listViewNote.TabIndex = 5;
            this.listViewNote.UseCompatibleStateImageBehavior = false;
            this.listViewNote.View = System.Windows.Forms.View.Details;
            this.listViewNote.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewNote_ItemDrag);
            // 
            // columnHeaderNota
            // 
            this.columnHeaderNota.Text = "Nota";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareStudentToolStripMenuItem1,
            this.stergereStudentToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 52);
            // 
            // adaugareStudentToolStripMenuItem1
            // 
            this.adaugareStudentToolStripMenuItem1.Name = "adaugareStudentToolStripMenuItem1";
            this.adaugareStudentToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.adaugareStudentToolStripMenuItem1.Text = "Adaugare Student";
            this.adaugareStudentToolStripMenuItem1.Click += new System.EventHandler(this.adaugareStudentToolStripMenuItem_Click);
            // 
            // stergereStudentToolStripMenuItem1
            // 
            this.stergereStudentToolStripMenuItem1.Name = "stergereStudentToolStripMenuItem1";
            this.stergereStudentToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.stergereStudentToolStripMenuItem1.Text = "Stergere Student";
            this.stergereStudentToolStripMenuItem1.Click += new System.EventHandler(this.stergereStudentToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1477, 835);
            this.Controls.Add(this.listViewNote);
            this.Controls.Add(this.listvNotediscipline);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNume;
        private System.Windows.Forms.ColumnHeader columnHeaderCnp;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderSpecializare;
        private System.Windows.Forms.ColumnHeader columnHeaderVarsta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareStudentBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurareStudentBinarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informatiiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listvNotediscipline;
        private System.Windows.Forms.ColumnHeader columnHeaderDisciplina;
        private System.Windows.Forms.ColumnHeader columnHeaderProfil;
        private System.Windows.Forms.ColumnHeader columnHeaderOb;
        private System.Windows.Forms.ListView listViewNote;
        private System.Windows.Forms.ColumnHeader columnHeaderNota;
        private System.Windows.Forms.ToolStripMenuItem adaugareStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareStudentToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stergereStudentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
    }
}

