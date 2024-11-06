namespace ETICHETTE
{
    partial class frmPrincipale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFornitoriElimina = new System.Windows.Forms.Button();
            this.dgvFornitori = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Denominazione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbxFornitore = new System.Windows.Forms.TextBox();
            this.btnSalvaFornitori = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEtichettaAltezza = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEtichette = new System.Windows.Forms.DataGridView();
            this.ID_Etichetta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornitore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etichetta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEtichettaElimina = new System.Windows.Forms.Button();
            this.btnEtichettaSalva = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nudPaginaLarghezza = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.nudPaginaAltezza = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudEtichettaQtOrizzontale = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudEtichettaQtVerticale = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudEtichettaPassoOrizzontale = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudEtichettaPassoVerticale = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudEtichettaMargineLaterale = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudEtichettaMargineSuperiore = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEtichettaLarghezza = new System.Windows.Forms.NumericUpDown();
            this.tbxEtichetta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFornitori = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornitori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaAltezza)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtichette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginaLarghezza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginaAltezza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaQtOrizzontale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaQtVerticale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaPassoOrizzontale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaPassoVerticale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaMargineLaterale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaMargineSuperiore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaLarghezza)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFornitoriElimina);
            this.groupBox1.Controls.Add(this.dgvFornitori);
            this.groupBox1.Controls.Add(this.tbxFornitore);
            this.groupBox1.Controls.Add(this.btnSalvaFornitori);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fornitori";
            // 
            // btnFornitoriElimina
            // 
            this.btnFornitoriElimina.Location = new System.Drawing.Point(734, 139);
            this.btnFornitoriElimina.Name = "btnFornitoriElimina";
            this.btnFornitoriElimina.Size = new System.Drawing.Size(120, 30);
            this.btnFornitoriElimina.TabIndex = 3;
            this.btnFornitoriElimina.Text = "Elimina";
            this.btnFornitoriElimina.UseVisualStyleBackColor = true;
            this.btnFornitoriElimina.Click += new System.EventHandler(this.btnFornitoriElimina_Click);
            // 
            // dgvFornitori
            // 
            this.dgvFornitori.AllowUserToAddRows = false;
            this.dgvFornitori.AllowUserToDeleteRows = false;
            this.dgvFornitori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornitori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Denominazione});
            this.dgvFornitori.Location = new System.Drawing.Point(6, 19);
            this.dgvFornitori.MultiSelect = false;
            this.dgvFornitori.Name = "dgvFornitori";
            this.dgvFornitori.ReadOnly = true;
            this.dgvFornitori.RowHeadersVisible = false;
            this.dgvFornitori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornitori.Size = new System.Drawing.Size(710, 150);
            this.dgvFornitori.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Denominazione
            // 
            this.Denominazione.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Denominazione.HeaderText = "Denominazione";
            this.Denominazione.Name = "Denominazione";
            this.Denominazione.ReadOnly = true;
            // 
            // tbxFornitore
            // 
            this.tbxFornitore.Location = new System.Drawing.Point(734, 77);
            this.tbxFornitore.Name = "tbxFornitore";
            this.tbxFornitore.Size = new System.Drawing.Size(120, 20);
            this.tbxFornitore.TabIndex = 1;
            // 
            // btnSalvaFornitori
            // 
            this.btnSalvaFornitori.Location = new System.Drawing.Point(734, 103);
            this.btnSalvaFornitori.Name = "btnSalvaFornitori";
            this.btnSalvaFornitori.Size = new System.Drawing.Size(120, 30);
            this.btnSalvaFornitori.TabIndex = 2;
            this.btnSalvaFornitori.Text = "Salva";
            this.btnSalvaFornitori.UseVisualStyleBackColor = true;
            this.btnSalvaFornitori.Click += new System.EventHandler(this.btnSalvaFornitori_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fornitore";
            // 
            // nudEtichettaAltezza
            // 
            this.nudEtichettaAltezza.DecimalPlaces = 2;
            this.nudEtichettaAltezza.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaAltezza.Location = new System.Drawing.Point(468, 87);
            this.nudEtichettaAltezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaAltezza.Name = "nudEtichettaAltezza";
            this.nudEtichettaAltezza.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaAltezza.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Etichetta altezza";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEtichette);
            this.groupBox2.Controls.Add(this.btnEtichettaElimina);
            this.groupBox2.Controls.Add(this.btnEtichettaSalva);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.nudPaginaLarghezza);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.nudPaginaAltezza);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nudEtichettaQtOrizzontale);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nudEtichettaQtVerticale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nudEtichettaPassoOrizzontale);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudEtichettaPassoVerticale);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nudEtichettaMargineLaterale);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nudEtichettaMargineSuperiore);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudEtichettaLarghezza);
            this.groupBox2.Controls.Add(this.tbxEtichetta);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxFornitori);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nudEtichettaAltezza);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 269);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Etichetta";
            // 
            // dgvEtichette
            // 
            this.dgvEtichette.AllowUserToAddRows = false;
            this.dgvEtichette.AllowUserToDeleteRows = false;
            this.dgvEtichette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtichette.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Etichetta,
            this.Fornitore,
            this.Etichetta});
            this.dgvEtichette.Location = new System.Drawing.Point(6, 19);
            this.dgvEtichette.MultiSelect = false;
            this.dgvEtichette.Name = "dgvEtichette";
            this.dgvEtichette.ReadOnly = true;
            this.dgvEtichette.RowHeadersVisible = false;
            this.dgvEtichette.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtichette.Size = new System.Drawing.Size(453, 244);
            this.dgvEtichette.TabIndex = 0;
            this.dgvEtichette.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtichette_CellDoubleClick);
            // 
            // ID_Etichetta
            // 
            this.ID_Etichetta.HeaderText = "ID";
            this.ID_Etichetta.Name = "ID_Etichetta";
            this.ID_Etichetta.ReadOnly = true;
            this.ID_Etichetta.Width = 50;
            // 
            // Fornitore
            // 
            this.Fornitore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fornitore.HeaderText = "Fornitore";
            this.Fornitore.Name = "Fornitore";
            this.Fornitore.ReadOnly = true;
            // 
            // Etichetta
            // 
            this.Etichetta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Etichetta.HeaderText = "Etichetta";
            this.Etichetta.Name = "Etichetta";
            this.Etichetta.ReadOnly = true;
            // 
            // btnEtichettaElimina
            // 
            this.btnEtichettaElimina.Location = new System.Drawing.Point(734, 233);
            this.btnEtichettaElimina.Name = "btnEtichettaElimina";
            this.btnEtichettaElimina.Size = new System.Drawing.Size(120, 30);
            this.btnEtichettaElimina.TabIndex = 14;
            this.btnEtichettaElimina.Text = "Elimina";
            this.btnEtichettaElimina.UseVisualStyleBackColor = true;
            this.btnEtichettaElimina.Click += new System.EventHandler(this.btnEtichettaElimina_Click);
            // 
            // btnEtichettaSalva
            // 
            this.btnEtichettaSalva.Location = new System.Drawing.Point(734, 197);
            this.btnEtichettaSalva.Name = "btnEtichettaSalva";
            this.btnEtichettaSalva.Size = new System.Drawing.Size(120, 30);
            this.btnEtichettaSalva.TabIndex = 13;
            this.btnEtichettaSalva.Text = "Salva";
            this.btnEtichettaSalva.UseVisualStyleBackColor = true;
            this.btnEtichettaSalva.Click += new System.EventHandler(this.btnEtichettaSalva_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(593, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Pagina larghezza";
            // 
            // nudPaginaLarghezza
            // 
            this.nudPaginaLarghezza.DecimalPlaces = 2;
            this.nudPaginaLarghezza.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPaginaLarghezza.Location = new System.Drawing.Point(596, 243);
            this.nudPaginaLarghezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaginaLarghezza.Name = "nudPaginaLarghezza";
            this.nudPaginaLarghezza.Size = new System.Drawing.Size(120, 20);
            this.nudPaginaLarghezza.TabIndex = 12;
            this.nudPaginaLarghezza.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Pagina altezza";
            // 
            // nudPaginaAltezza
            // 
            this.nudPaginaAltezza.DecimalPlaces = 2;
            this.nudPaginaAltezza.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPaginaAltezza.Location = new System.Drawing.Point(469, 243);
            this.nudPaginaAltezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPaginaAltezza.Name = "nudPaginaAltezza";
            this.nudPaginaAltezza.Size = new System.Drawing.Size(120, 20);
            this.nudPaginaAltezza.TabIndex = 11;
            this.nudPaginaAltezza.ThousandsSeparator = true;
            this.nudPaginaAltezza.Value = new decimal(new int[] {
            297,
            0,
            0,
            65536});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Quantità orizzontale";
            // 
            // nudEtichettaQtOrizzontale
            // 
            this.nudEtichettaQtOrizzontale.DecimalPlaces = 2;
            this.nudEtichettaQtOrizzontale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaQtOrizzontale.Location = new System.Drawing.Point(595, 204);
            this.nudEtichettaQtOrizzontale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaQtOrizzontale.Name = "nudEtichettaQtOrizzontale";
            this.nudEtichettaQtOrizzontale.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaQtOrizzontale.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(465, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quantità verticale";
            // 
            // nudEtichettaQtVerticale
            // 
            this.nudEtichettaQtVerticale.DecimalPlaces = 2;
            this.nudEtichettaQtVerticale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaQtVerticale.Location = new System.Drawing.Point(468, 204);
            this.nudEtichettaQtVerticale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaQtVerticale.Name = "nudEtichettaQtVerticale";
            this.nudEtichettaQtVerticale.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaQtVerticale.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(592, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Passo orizzontale";
            // 
            // nudEtichettaPassoOrizzontale
            // 
            this.nudEtichettaPassoOrizzontale.DecimalPlaces = 2;
            this.nudEtichettaPassoOrizzontale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaPassoOrizzontale.Location = new System.Drawing.Point(595, 165);
            this.nudEtichettaPassoOrizzontale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaPassoOrizzontale.Name = "nudEtichettaPassoOrizzontale";
            this.nudEtichettaPassoOrizzontale.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaPassoOrizzontale.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Passo verticale";
            // 
            // nudEtichettaPassoVerticale
            // 
            this.nudEtichettaPassoVerticale.DecimalPlaces = 2;
            this.nudEtichettaPassoVerticale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaPassoVerticale.Location = new System.Drawing.Point(468, 165);
            this.nudEtichettaPassoVerticale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaPassoVerticale.Name = "nudEtichettaPassoVerticale";
            this.nudEtichettaPassoVerticale.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaPassoVerticale.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(592, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Margine laterale";
            // 
            // nudEtichettaMargineLaterale
            // 
            this.nudEtichettaMargineLaterale.DecimalPlaces = 2;
            this.nudEtichettaMargineLaterale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaMargineLaterale.Location = new System.Drawing.Point(595, 126);
            this.nudEtichettaMargineLaterale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaMargineLaterale.Name = "nudEtichettaMargineLaterale";
            this.nudEtichettaMargineLaterale.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaMargineLaterale.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Margine superiore";
            // 
            // nudEtichettaMargineSuperiore
            // 
            this.nudEtichettaMargineSuperiore.DecimalPlaces = 2;
            this.nudEtichettaMargineSuperiore.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaMargineSuperiore.Location = new System.Drawing.Point(468, 126);
            this.nudEtichettaMargineSuperiore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaMargineSuperiore.Name = "nudEtichettaMargineSuperiore";
            this.nudEtichettaMargineSuperiore.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaMargineSuperiore.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Etichetta larghezza";
            // 
            // nudEtichettaLarghezza
            // 
            this.nudEtichettaLarghezza.DecimalPlaces = 2;
            this.nudEtichettaLarghezza.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEtichettaLarghezza.Location = new System.Drawing.Point(595, 87);
            this.nudEtichettaLarghezza.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEtichettaLarghezza.Name = "nudEtichettaLarghezza";
            this.nudEtichettaLarghezza.Size = new System.Drawing.Size(120, 20);
            this.nudEtichettaLarghezza.TabIndex = 4;
            // 
            // tbxEtichetta
            // 
            this.tbxEtichetta.Location = new System.Drawing.Point(595, 47);
            this.tbxEtichetta.Name = "tbxEtichetta";
            this.tbxEtichetta.Size = new System.Drawing.Size(120, 20);
            this.tbxEtichetta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome etichetta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fornitore";
            // 
            // cbxFornitori
            // 
            this.cbxFornitori.FormattingEnabled = true;
            this.cbxFornitori.Location = new System.Drawing.Point(468, 47);
            this.cbxFornitori.Name = "cbxFornitori";
            this.cbxFornitori.Size = new System.Drawing.Size(121, 21);
            this.cbxFornitori.TabIndex = 1;
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 474);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creazione etichette";
            this.Load += new System.EventHandler(this.frmPrincipale_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornitori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaAltezza)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtichette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginaLarghezza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginaAltezza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaQtOrizzontale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaQtVerticale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaPassoOrizzontale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaPassoVerticale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaMargineLaterale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaMargineSuperiore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEtichettaLarghezza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxFornitore;
        private System.Windows.Forms.Button btnSalvaFornitori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFornitori;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Denominazione;
        private System.Windows.Forms.Button btnFornitoriElimina;
        private System.Windows.Forms.NumericUpDown nudEtichettaAltezza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudEtichettaLarghezza;
        private System.Windows.Forms.TextBox tbxEtichetta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFornitori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudEtichettaMargineLaterale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudEtichettaMargineSuperiore;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudEtichettaPassoOrizzontale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudEtichettaPassoVerticale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudPaginaLarghezza;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudPaginaAltezza;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudEtichettaQtOrizzontale;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudEtichettaQtVerticale;
        private System.Windows.Forms.Button btnEtichettaElimina;
        private System.Windows.Forms.Button btnEtichettaSalva;
        private System.Windows.Forms.DataGridView dgvEtichette;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Etichetta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornitore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etichetta;
    }
}

