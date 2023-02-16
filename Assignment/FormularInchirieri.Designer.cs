namespace Inchirieri_de_casete_video
{
    partial class FormularInchirieri
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
            this.labelNumarInchiriere = new System.Windows.Forms.Label();
            this.tbNumarInchiriere = new System.Windows.Forms.TextBox();
            this.labelFilm = new System.Windows.Forms.Label();
            this.tbFilm = new System.Windows.Forms.TextBox();
            this.labelTipFilm = new System.Windows.Forms.Label();
            this.cbTipFilm = new System.Windows.Forms.ComboBox();
            this.labelVersiuneFilm = new System.Windows.Forms.Label();
            this.cbVersiuneFilm = new System.Windows.Forms.ComboBox();
            this.labelDataInchirierii = new System.Windows.Forms.Label();
            this.dtpDataInchirierii = new System.Windows.Forms.DateTimePicker();
            this.labelDataReturnarii = new System.Windows.Forms.Label();
            this.dtpDataReturnarii = new System.Windows.Forms.DateTimePicker();
            this.labelPretInchiriere = new System.Windows.Forms.Label();
            this.tbPretInchiriere = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAn = new System.Windows.Forms.TextBox();
            this.labelAn = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.lvInchirieri = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelListaInchirieri = new System.Windows.Forms.Label();
            this.epNumarInchiriere = new System.Windows.Forms.ErrorProvider(this.components);
            this.epData = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEditeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsEditeaza = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSterge = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumeClient = new System.Windows.Forms.Label();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.labelPrenumeClient = new System.Windows.Forms.Label();
            this.tbPrenumeClient = new System.Windows.Forms.TextBox();
            this.labelAdresa = new System.Windows.Forms.Label();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.epNumeClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenumeClient = new System.Windows.Forms.ErrorProvider(this.components);
            this.epTelefon = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumarInchiriere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).BeginInit();
            this.cms.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenumeClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNumarInchiriere
            // 
            this.labelNumarInchiriere.AutoSize = true;
            this.labelNumarInchiriere.Location = new System.Drawing.Point(6, 28);
            this.labelNumarInchiriere.Name = "labelNumarInchiriere";
            this.labelNumarInchiriere.Size = new System.Drawing.Size(66, 13);
            this.labelNumarInchiriere.TabIndex = 0;
            this.labelNumarInchiriere.Text = "Nr. inchiriere";
            // 
            // tbNumarInchiriere
            // 
            this.tbNumarInchiriere.Location = new System.Drawing.Point(9, 44);
            this.tbNumarInchiriere.Name = "tbNumarInchiriere";
            this.tbNumarInchiriere.Size = new System.Drawing.Size(188, 20);
            this.tbNumarInchiriere.TabIndex = 1;
            this.tbNumarInchiriere.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumarInchiriere_Validating);
            this.tbNumarInchiriere.Validated += new System.EventHandler(this.tbNumarInchiriere_Validated);
            // 
            // labelFilm
            // 
            this.labelFilm.AutoSize = true;
            this.labelFilm.Location = new System.Drawing.Point(6, 72);
            this.labelFilm.Name = "labelFilm";
            this.labelFilm.Size = new System.Drawing.Size(25, 13);
            this.labelFilm.TabIndex = 2;
            this.labelFilm.Text = "Film";
            // 
            // tbFilm
            // 
            this.tbFilm.Location = new System.Drawing.Point(9, 88);
            this.tbFilm.Name = "tbFilm";
            this.tbFilm.Size = new System.Drawing.Size(188, 20);
            this.tbFilm.TabIndex = 3;
            // 
            // labelTipFilm
            // 
            this.labelTipFilm.AutoSize = true;
            this.labelTipFilm.Location = new System.Drawing.Point(6, 111);
            this.labelTipFilm.Name = "labelTipFilm";
            this.labelTipFilm.Size = new System.Drawing.Size(22, 13);
            this.labelTipFilm.TabIndex = 4;
            this.labelTipFilm.Text = "Tip";
            // 
            // cbTipFilm
            // 
            this.cbTipFilm.FormattingEnabled = true;
            this.cbTipFilm.Items.AddRange(new object[] {
            "ANIMATIE",
            "ACTIUNE",
            "COMEDIE",
            "DRAMA"});
            this.cbTipFilm.Location = new System.Drawing.Point(12, 128);
            this.cbTipFilm.Name = "cbTipFilm";
            this.cbTipFilm.Size = new System.Drawing.Size(185, 21);
            this.cbTipFilm.TabIndex = 5;
            // 
            // labelVersiuneFilm
            // 
            this.labelVersiuneFilm.AutoSize = true;
            this.labelVersiuneFilm.Location = new System.Drawing.Point(9, 152);
            this.labelVersiuneFilm.Name = "labelVersiuneFilm";
            this.labelVersiuneFilm.Size = new System.Drawing.Size(48, 13);
            this.labelVersiuneFilm.TabIndex = 6;
            this.labelVersiuneFilm.Text = "Versiune";
            // 
            // cbVersiuneFilm
            // 
            this.cbVersiuneFilm.FormattingEnabled = true;
            this.cbVersiuneFilm.Items.AddRange(new object[] {
            "BLURAY",
            "DVD"});
            this.cbVersiuneFilm.Location = new System.Drawing.Point(12, 168);
            this.cbVersiuneFilm.Name = "cbVersiuneFilm";
            this.cbVersiuneFilm.Size = new System.Drawing.Size(185, 21);
            this.cbVersiuneFilm.TabIndex = 7;
            // 
            // labelDataInchirierii
            // 
            this.labelDataInchirierii.AutoSize = true;
            this.labelDataInchirierii.Location = new System.Drawing.Point(9, 230);
            this.labelDataInchirierii.Name = "labelDataInchirierii";
            this.labelDataInchirierii.Size = new System.Drawing.Size(73, 13);
            this.labelDataInchirierii.TabIndex = 8;
            this.labelDataInchirierii.Text = "Data inchirierii";
            // 
            // dtpDataInchirierii
            // 
            this.dtpDataInchirierii.Location = new System.Drawing.Point(12, 246);
            this.dtpDataInchirierii.MinDate = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            this.dtpDataInchirierii.Name = "dtpDataInchirierii";
            this.dtpDataInchirierii.Size = new System.Drawing.Size(185, 20);
            this.dtpDataInchirierii.TabIndex = 9;
            // 
            // labelDataReturnarii
            // 
            this.labelDataReturnarii.AutoSize = true;
            this.labelDataReturnarii.Location = new System.Drawing.Point(9, 285);
            this.labelDataReturnarii.Name = "labelDataReturnarii";
            this.labelDataReturnarii.Size = new System.Drawing.Size(73, 13);
            this.labelDataReturnarii.TabIndex = 10;
            this.labelDataReturnarii.Text = "Data returnarii";
            // 
            // dtpDataReturnarii
            // 
            this.dtpDataReturnarii.Location = new System.Drawing.Point(12, 301);
            this.dtpDataReturnarii.Name = "dtpDataReturnarii";
            this.dtpDataReturnarii.Size = new System.Drawing.Size(185, 20);
            this.dtpDataReturnarii.TabIndex = 11;
            this.dtpDataReturnarii.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataReturnarii_Validating);
            this.dtpDataReturnarii.Validated += new System.EventHandler(this.dtpDataReturnarii_Validated);
            // 
            // labelPretInchiriere
            // 
            this.labelPretInchiriere.AutoSize = true;
            this.labelPretInchiriere.Location = new System.Drawing.Point(9, 324);
            this.labelPretInchiriere.Name = "labelPretInchiriere";
            this.labelPretInchiriere.Size = new System.Drawing.Size(71, 13);
            this.labelPretInchiriere.TabIndex = 12;
            this.labelPretInchiriere.Text = "Pret inchiriere";
            // 
            // tbPretInchiriere
            // 
            this.tbPretInchiriere.Location = new System.Drawing.Point(12, 340);
            this.tbPretInchiriere.Name = "tbPretInchiriere";
            this.tbPretInchiriere.Size = new System.Drawing.Size(185, 20);
            this.tbPretInchiriere.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAn);
            this.groupBox1.Controls.Add(this.labelAn);
            this.groupBox1.Controls.Add(this.dtpDataInchirierii);
            this.groupBox1.Controls.Add(this.tbPretInchiriere);
            this.groupBox1.Controls.Add(this.labelNumarInchiriere);
            this.groupBox1.Controls.Add(this.labelPretInchiriere);
            this.groupBox1.Controls.Add(this.tbNumarInchiriere);
            this.groupBox1.Controls.Add(this.dtpDataReturnarii);
            this.groupBox1.Controls.Add(this.labelFilm);
            this.groupBox1.Controls.Add(this.labelDataReturnarii);
            this.groupBox1.Controls.Add(this.tbFilm);
            this.groupBox1.Controls.Add(this.labelTipFilm);
            this.groupBox1.Controls.Add(this.labelDataInchirierii);
            this.groupBox1.Controls.Add(this.cbTipFilm);
            this.groupBox1.Controls.Add(this.cbVersiuneFilm);
            this.groupBox1.Controls.Add(this.labelVersiuneFilm);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 366);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalii inchirieri";
            // 
            // tbAn
            // 
            this.tbAn.Location = new System.Drawing.Point(12, 207);
            this.tbAn.Name = "tbAn";
            this.tbAn.Size = new System.Drawing.Size(182, 20);
            this.tbAn.TabIndex = 15;
            // 
            // labelAn
            // 
            this.labelAn.AutoSize = true;
            this.labelAn.Location = new System.Drawing.Point(9, 191);
            this.labelAn.Name = "labelAn";
            this.labelAn.Size = new System.Drawing.Size(20, 13);
            this.labelAn.TabIndex = 14;
            this.labelAn.Text = "An";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(46, 417);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(63, 38);
            this.btnAdauga.TabIndex = 15;
            this.btnAdauga.Text = "Adauga inchiriere";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(315, 417);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(64, 38);
            this.btnCurata.TabIndex = 16;
            this.btnCurata.Text = "Curata formular";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // lvInchirieri
            // 
            this.lvInchirieri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lvInchirieri.FullRowSelect = true;
            this.lvInchirieri.HideSelection = false;
            this.lvInchirieri.Location = new System.Drawing.Point(467, 38);
            this.lvInchirieri.Name = "lvInchirieri";
            this.lvInchirieri.Size = new System.Drawing.Size(411, 216);
            this.lvInchirieri.TabIndex = 17;
            this.lvInchirieri.UseCompatibleStateImageBehavior = false;
            this.lvInchirieri.View = System.Windows.Forms.View.Details;
            this.lvInchirieri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvInchirieri_MouseClick);
            this.lvInchirieri.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvInchirieri_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr. inchiriere";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Film";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tip";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Versiune";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "An";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pret";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = " Nume ";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 48;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prenume";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelListaInchirieri
            // 
            this.labelListaInchirieri.AutoSize = true;
            this.labelListaInchirieri.Location = new System.Drawing.Point(404, 9);
            this.labelListaInchirieri.Name = "labelListaInchirieri";
            this.labelListaInchirieri.Size = new System.Drawing.Size(70, 13);
            this.labelListaInchirieri.TabIndex = 18;
            this.labelListaInchirieri.Text = "Lista inchirieri";
            // 
            // epNumarInchiriere
            // 
            this.epNumarInchiriere.ContainerControl = this;
            // 
            // epData
            // 
            this.epData.ContainerControl = this;
            // 
            // btnEditeaza
            // 
            this.btnEditeaza.Location = new System.Drawing.Point(467, 417);
            this.btnEditeaza.Name = "btnEditeaza";
            this.btnEditeaza.Size = new System.Drawing.Size(75, 38);
            this.btnEditeaza.TabIndex = 19;
            this.btnEditeaza.Text = "Editeaza inchiriere";
            this.btnEditeaza.UseVisualStyleBackColor = true;
            this.btnEditeaza.Click += new System.EventHandler(this.btnEditeaza_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(799, 417);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(79, 38);
            this.btnSterge.TabIndex = 20;
            this.btnSterge.Text = "Sterge inchiriere";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsEditeaza,
            this.cmsSterge});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(118, 48);
            // 
            // cmsEditeaza
            // 
            this.cmsEditeaza.Name = "cmsEditeaza";
            this.cmsEditeaza.Size = new System.Drawing.Size(117, 22);
            this.cmsEditeaza.Text = "Editeaza";
            this.cmsEditeaza.Click += new System.EventHandler(this.cmsEditeaza_Click_1);
            // 
            // cmsSterge
            // 
            this.cmsSterge.Name = "cmsSterge";
            this.cmsSterge.Size = new System.Drawing.Size(117, 22);
            this.cmsSterge.Text = "Sterge";
            this.cmsSterge.Click += new System.EventHandler(this.cmsSterge_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.despreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(419, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 457);
            this.label1.TabIndex = 23;
            // 
            // labelNumeClient
            // 
            this.labelNumeClient.AutoSize = true;
            this.labelNumeClient.Location = new System.Drawing.Point(20, 28);
            this.labelNumeClient.Name = "labelNumeClient";
            this.labelNumeClient.Size = new System.Drawing.Size(35, 13);
            this.labelNumeClient.TabIndex = 24;
            this.labelNumeClient.Text = "Nume";
            // 
            // tbNumeClient
            // 
            this.tbNumeClient.Location = new System.Drawing.Point(20, 44);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(123, 20);
            this.tbNumeClient.TabIndex = 25;
            this.tbNumeClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeClient_Validating_1);
            this.tbNumeClient.Validated += new System.EventHandler(this.tbNumeClient_Validated);
            // 
            // labelPrenumeClient
            // 
            this.labelPrenumeClient.AutoSize = true;
            this.labelPrenumeClient.Location = new System.Drawing.Point(17, 72);
            this.labelPrenumeClient.Name = "labelPrenumeClient";
            this.labelPrenumeClient.Size = new System.Drawing.Size(49, 13);
            this.labelPrenumeClient.TabIndex = 26;
            this.labelPrenumeClient.Text = "Prenume";
            // 
            // tbPrenumeClient
            // 
            this.tbPrenumeClient.Location = new System.Drawing.Point(20, 88);
            this.tbPrenumeClient.Name = "tbPrenumeClient";
            this.tbPrenumeClient.Size = new System.Drawing.Size(123, 20);
            this.tbPrenumeClient.TabIndex = 27;
            this.tbPrenumeClient.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrenumeClient_Validating);
            this.tbPrenumeClient.Validated += new System.EventHandler(this.tbPrenumeClient_Validated);
            // 
            // labelAdresa
            // 
            this.labelAdresa.AutoSize = true;
            this.labelAdresa.Location = new System.Drawing.Point(17, 111);
            this.labelAdresa.Name = "labelAdresa";
            this.labelAdresa.Size = new System.Drawing.Size(40, 13);
            this.labelAdresa.TabIndex = 28;
            this.labelAdresa.Text = "Adresa";
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(20, 129);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(123, 20);
            this.tbAdresa.TabIndex = 29;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(20, 168);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(123, 20);
            this.tbTelefon.TabIndex = 30;
            this.tbTelefon.Validating += new System.ComponentModel.CancelEventHandler(this.tbTelefon_Validating);
            this.tbTelefon.Validated += new System.EventHandler(this.tbTelefon_Validated);
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(17, 152);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(43, 13);
            this.labelTelefon.TabIndex = 31;
            this.labelTelefon.Text = "Telefon";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAdresa);
            this.groupBox2.Controls.Add(this.labelAdresa);
            this.groupBox2.Controls.Add(this.labelTelefon);
            this.groupBox2.Controls.Add(this.tbPrenumeClient);
            this.groupBox2.Controls.Add(this.tbTelefon);
            this.groupBox2.Controls.Add(this.labelPrenumeClient);
            this.groupBox2.Controls.Add(this.tbNumeClient);
            this.groupBox2.Controls.Add(this.labelNumeClient);
            this.groupBox2.Location = new System.Drawing.Point(251, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 204);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalii clienti";
            // 
            // epNumeClient
            // 
            this.epNumeClient.ContainerControl = this;
            // 
            // epPrenumeClient
            // 
            this.epPrenumeClient.ContainerControl = this;
            // 
            // epTelefon
            // 
            this.epTelefon.ContainerControl = this;
            // 
            // FormularInchirieri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnEditeaza);
            this.Controls.Add(this.labelListaInchirieri);
            this.Controls.Add(this.lvInchirieri);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormularInchirieri";
            this.Text = "Formular inchirieri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumarInchiriere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epData)).EndInit();
            this.cms.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenumeClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epTelefon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumarInchiriere;
        private System.Windows.Forms.TextBox tbNumarInchiriere;
        private System.Windows.Forms.Label labelFilm;
        private System.Windows.Forms.TextBox tbFilm;
        private System.Windows.Forms.Label labelTipFilm;
        private System.Windows.Forms.ComboBox cbTipFilm;
        private System.Windows.Forms.Label labelVersiuneFilm;
        private System.Windows.Forms.ComboBox cbVersiuneFilm;
        private System.Windows.Forms.Label labelDataInchirierii;
        private System.Windows.Forms.DateTimePicker dtpDataInchirierii;
        private System.Windows.Forms.Label labelDataReturnarii;
        private System.Windows.Forms.DateTimePicker dtpDataReturnarii;
        private System.Windows.Forms.Label labelPretInchiriere;
        private System.Windows.Forms.TextBox tbPretInchiriere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.TextBox tbAn;
        private System.Windows.Forms.Label labelAn;
        private System.Windows.Forms.ListView lvInchirieri;
        private System.Windows.Forms.Label labelListaInchirieri;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ErrorProvider epNumarInchiriere;
        private System.Windows.Forms.ErrorProvider epData;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Button btnEditeaza;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem cmsEditeaza;
        private System.Windows.Forms.ToolStripMenuItem cmsSterge;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Label labelNumeClient;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.Label labelPrenumeClient;
        private System.Windows.Forms.TextBox tbPrenumeClient;
        private System.Windows.Forms.Label labelAdresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider epNumeClient;
        private System.Windows.Forms.ErrorProvider epPrenumeClient;
        private System.Windows.Forms.ErrorProvider epTelefon;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}

