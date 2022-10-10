namespace incercare_proiect
{
    partial class FormStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.buttonActualizare = new System.Windows.Forms.Button();
            this.lSpecializare = new System.Windows.Forms.Label();
            this.lFacultate = new System.Windows.Forms.Label();
            this.lNumep = new System.Windows.Forms.Label();
            this.lCnp = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lVarsta = new System.Windows.Forms.Label();
            this.comboBoxSp = new System.Windows.Forms.ComboBox();
            this.comboBoxFac = new System.Windows.Forms.ComboBox();
            this.textBoxNumec = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.userControl11 = new incercare_proiect.UserControl1();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonActualizare
            // 
            this.buttonActualizare.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonActualizare.Location = new System.Drawing.Point(602, 59);
            this.buttonActualizare.Name = "buttonActualizare";
            this.buttonActualizare.Size = new System.Drawing.Size(123, 63);
            this.buttonActualizare.TabIndex = 0;
            this.buttonActualizare.Text = "Actualizare";
            this.buttonActualizare.UseVisualStyleBackColor = true;
            this.buttonActualizare.Click += new System.EventHandler(this.buttonActualizare_Click);
            // 
            // lSpecializare
            // 
            this.lSpecializare.AutoSize = true;
            this.lSpecializare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lSpecializare.Location = new System.Drawing.Point(80, 35);
            this.lSpecializare.Name = "lSpecializare";
            this.lSpecializare.Size = new System.Drawing.Size(85, 17);
            this.lSpecializare.TabIndex = 1;
            this.lSpecializare.Text = "Specializare";
            // 
            // lFacultate
            // 
            this.lFacultate.AutoSize = true;
            this.lFacultate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lFacultate.Location = new System.Drawing.Point(80, 97);
            this.lFacultate.Name = "lFacultate";
            this.lFacultate.Size = new System.Drawing.Size(66, 17);
            this.lFacultate.TabIndex = 2;
            this.lFacultate.Text = "Facultate";
            // 
            // lNumep
            // 
            this.lNumep.AutoSize = true;
            this.lNumep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lNumep.Location = new System.Drawing.Point(80, 159);
            this.lNumep.Name = "lNumep";
            this.lNumep.Size = new System.Drawing.Size(98, 17);
            this.lNumep.TabIndex = 3;
            this.lNumep.Text = "Nume complet";
            // 
            // lCnp
            // 
            this.lCnp.AutoSize = true;
            this.lCnp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lCnp.Location = new System.Drawing.Point(80, 221);
            this.lCnp.Name = "lCnp";
            this.lCnp.Size = new System.Drawing.Size(36, 17);
            this.lCnp.TabIndex = 4;
            this.lCnp.Text = "CNP";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lId.Location = new System.Drawing.Point(80, 283);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 17);
            this.lId.TabIndex = 5;
            this.lId.Text = "Id";
            // 
            // lVarsta
            // 
            this.lVarsta.AutoSize = true;
            this.lVarsta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lVarsta.Location = new System.Drawing.Point(80, 345);
            this.lVarsta.Name = "lVarsta";
            this.lVarsta.Size = new System.Drawing.Size(49, 17);
            this.lVarsta.TabIndex = 6;
            this.lVarsta.Text = "Varsta";
            // 
            // comboBoxSp
            // 
            this.comboBoxSp.FormattingEnabled = true;
            this.comboBoxSp.Items.AddRange(new object[] {
            "Cibernetica",
            "Informatica Economica",
            "Statistica",
            "CSIE"});
            this.comboBoxSp.Location = new System.Drawing.Point(237, 35);
            this.comboBoxSp.Name = "comboBoxSp";
            this.comboBoxSp.Size = new System.Drawing.Size(306, 24);
            this.comboBoxSp.TabIndex = 7;
            // 
            // comboBoxFac
            // 
            this.comboBoxFac.FormattingEnabled = true;
            this.comboBoxFac.Items.AddRange(new object[] {
            "CSIE",
            "Relatii internationale",
            "FABIZ",
            "Contabilitate si Informatica de Gestiune",
            "Economie Aplicata",
            "Management"});
            this.comboBoxFac.Location = new System.Drawing.Point(237, 98);
            this.comboBoxFac.Name = "comboBoxFac";
            this.comboBoxFac.Size = new System.Drawing.Size(306, 24);
            this.comboBoxFac.TabIndex = 8;
            // 
            // textBoxNumec
            // 
            this.textBoxNumec.Location = new System.Drawing.Point(237, 161);
            this.textBoxNumec.Name = "textBoxNumec";
            this.textBoxNumec.Size = new System.Drawing.Size(306, 22);
            this.textBoxNumec.TabIndex = 9;
            this.textBoxNumec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumec_KeyPress);
            this.textBoxNumec.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumec_Validating);
            this.textBoxNumec.Validated += new System.EventHandler(this.textBoxNumec_Validated);
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(237, 222);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(306, 22);
            this.textBoxCNP.TabIndex = 10;
            this.textBoxCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCNP_KeyPress);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(237, 283);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(306, 22);
            this.textBoxId.TabIndex = 11;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.Location = new System.Drawing.Point(237, 344);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(306, 22);
            this.textBoxVarsta.TabIndex = 12;
            this.textBoxVarsta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarsta_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(602, 314);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(123, 23);
            this.buttonPrint.TabIndex = 13;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(602, 144);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(330, 150);
            this.userControl11.TabIndex = 14;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.textBoxVarsta);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxNumec);
            this.Controls.Add(this.comboBoxFac);
            this.Controls.Add(this.comboBoxSp);
            this.Controls.Add(this.lVarsta);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lCnp);
            this.Controls.Add(this.lNumep);
            this.Controls.Add(this.lFacultate);
            this.Controls.Add(this.lSpecializare);
            this.Controls.Add(this.buttonActualizare);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lSpecializare;
        private System.Windows.Forms.Label lFacultate;
        private System.Windows.Forms.Label lNumep;
        private System.Windows.Forms.Label lCnp;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lVarsta;
        private System.Windows.Forms.ComboBox comboBoxSp;
        private System.Windows.Forms.ComboBox comboBoxFac;
        private System.Windows.Forms.TextBox textBoxNumec;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxVarsta;
        public System.Windows.Forms.Button buttonActualizare;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Button buttonPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private UserControl1 userControl11;
    }
}