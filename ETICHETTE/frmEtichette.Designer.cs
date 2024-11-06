namespace ETICHETTE
{
    partial class frmEtichette
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEtichette));
            this.btnCrea = new System.Windows.Forms.Button();
            this.tbxTitolo = new System.Windows.Forms.TextBox();
            this.tbxTesto = new System.Windows.Forms.TextBox();
            this.tbxProduzione = new System.Windows.Forms.TextBox();
            this.tbxScadenza = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpProduzione = new System.Windows.Forms.DateTimePicker();
            this.dtpScadenza = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grbEtichetta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbTipo = new System.Windows.Forms.GroupBox();
            this.chbBordi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQT = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudInizio = new System.Windows.Forms.NumericUpDown();
            this.cbxEtichetta = new System.Windows.Forms.ComboBox();
            this.btnTipi = new System.Windows.Forms.Button();
            this.grbEtichetta.SuspendLayout();
            this.grbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInizio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrea
            // 
            this.btnCrea.Image = global::ETICHETTE.Properties.Resources.stampa;
            this.btnCrea.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrea.Location = new System.Drawing.Point(20, 478);
            this.btnCrea.Name = "btnCrea";
            this.btnCrea.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.btnCrea.Size = new System.Drawing.Size(357, 39);
            this.btnCrea.TabIndex = 0;
            this.btnCrea.Text = "Crea PDF da stampare";
            this.btnCrea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrea.UseVisualStyleBackColor = true;
            this.btnCrea.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxTitolo
            // 
            this.tbxTitolo.Location = new System.Drawing.Point(6, 45);
            this.tbxTitolo.Name = "tbxTitolo";
            this.tbxTitolo.Size = new System.Drawing.Size(344, 20);
            this.tbxTitolo.TabIndex = 1;
            this.tbxTitolo.Text = "INGREDIENTI";
            // 
            // tbxTesto
            // 
            this.tbxTesto.Location = new System.Drawing.Point(6, 89);
            this.tbxTesto.Multiline = true;
            this.tbxTesto.Name = "tbxTesto";
            this.tbxTesto.Size = new System.Drawing.Size(344, 87);
            this.tbxTesto.TabIndex = 3;
            this.tbxTesto.Text = resources.GetString("tbxTesto.Text");
            // 
            // tbxProduzione
            // 
            this.tbxProduzione.Location = new System.Drawing.Point(6, 195);
            this.tbxProduzione.Name = "tbxProduzione";
            this.tbxProduzione.Size = new System.Drawing.Size(217, 20);
            this.tbxProduzione.TabIndex = 9;
            this.tbxProduzione.Text = "DATA DI PRODUZIONE:";
            // 
            // tbxScadenza
            // 
            this.tbxScadenza.Location = new System.Drawing.Point(6, 221);
            this.tbxScadenza.Name = "tbxScadenza";
            this.tbxScadenza.Size = new System.Drawing.Size(217, 20);
            this.tbxScadenza.TabIndex = 11;
            this.tbxScadenza.Text = "SCADENZA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Titolo";
            // 
            // dtpProduzione
            // 
            this.dtpProduzione.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProduzione.Location = new System.Drawing.Point(229, 195);
            this.dtpProduzione.Name = "dtpProduzione";
            this.dtpProduzione.Size = new System.Drawing.Size(121, 20);
            this.dtpProduzione.TabIndex = 16;
            // 
            // dtpScadenza
            // 
            this.dtpScadenza.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScadenza.Location = new System.Drawing.Point(229, 221);
            this.dtpScadenza.Name = "dtpScadenza";
            this.dtpScadenza.Size = new System.Drawing.Size(121, 20);
            this.dtpScadenza.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Testo";
            // 
            // grbEtichetta
            // 
            this.grbEtichetta.Controls.Add(this.label1);
            this.grbEtichetta.Controls.Add(this.label2);
            this.grbEtichetta.Controls.Add(this.tbxTitolo);
            this.grbEtichetta.Controls.Add(this.dtpScadenza);
            this.grbEtichetta.Controls.Add(this.tbxTesto);
            this.grbEtichetta.Controls.Add(this.dtpProduzione);
            this.grbEtichetta.Controls.Add(this.tbxProduzione);
            this.grbEtichetta.Controls.Add(this.tbxScadenza);
            this.grbEtichetta.Location = new System.Drawing.Point(20, 54);
            this.grbEtichetta.Name = "grbEtichetta";
            this.grbEtichetta.Size = new System.Drawing.Size(357, 251);
            this.grbEtichetta.TabIndex = 19;
            this.grbEtichetta.TabStop = false;
            this.grbEtichetta.Text = "Testo etichetta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "STAMPA ETICHETTE";
            // 
            // grbTipo
            // 
            this.grbTipo.Controls.Add(this.chbBordi);
            this.grbTipo.Controls.Add(this.label6);
            this.grbTipo.Controls.Add(this.label5);
            this.grbTipo.Controls.Add(this.nudQT);
            this.grbTipo.Controls.Add(this.label4);
            this.grbTipo.Controls.Add(this.nudInizio);
            this.grbTipo.Controls.Add(this.cbxEtichetta);
            this.grbTipo.Location = new System.Drawing.Point(20, 323);
            this.grbTipo.Name = "grbTipo";
            this.grbTipo.Size = new System.Drawing.Size(357, 121);
            this.grbTipo.TabIndex = 21;
            this.grbTipo.TabStop = false;
            this.grbTipo.Text = "Tipologia etichetta";
            // 
            // chbBordi
            // 
            this.chbBordi.AutoSize = true;
            this.chbBordi.Location = new System.Drawing.Point(229, 86);
            this.chbBordi.Name = "chbBordi";
            this.chbBordi.Size = new System.Drawing.Size(88, 17);
            this.chbBordi.TabIndex = 6;
            this.chbBordi.Text = "Stampa bordi";
            this.chbBordi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Etichetta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantità";
            // 
            // nudQT
            // 
            this.nudQT.Location = new System.Drawing.Point(118, 85);
            this.nudQT.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQT.Name = "nudQT";
            this.nudQT.Size = new System.Drawing.Size(105, 20);
            this.nudQT.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Inizio";
            // 
            // nudInizio
            // 
            this.nudInizio.Location = new System.Drawing.Point(6, 85);
            this.nudInizio.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInizio.Name = "nudInizio";
            this.nudInizio.Size = new System.Drawing.Size(106, 20);
            this.nudInizio.TabIndex = 1;
            this.nudInizio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbxEtichetta
            // 
            this.cbxEtichetta.FormattingEnabled = true;
            this.cbxEtichetta.Location = new System.Drawing.Point(6, 41);
            this.cbxEtichetta.Name = "cbxEtichetta";
            this.cbxEtichetta.Size = new System.Drawing.Size(344, 21);
            this.cbxEtichetta.TabIndex = 0;
            this.cbxEtichetta.SelectedIndexChanged += new System.EventHandler(this.cbxEtichetta_SelectedIndexChanged);
            // 
            // btnTipi
            // 
            this.btnTipi.Location = new System.Drawing.Point(339, 20);
            this.btnTipi.Name = "btnTipi";
            this.btnTipi.Size = new System.Drawing.Size(38, 23);
            this.btnTipi.TabIndex = 22;
            this.btnTipi.Text = "TIPI";
            this.btnTipi.UseVisualStyleBackColor = true;
            this.btnTipi.Click += new System.EventHandler(this.btnTipi_Click);
            // 
            // frmEtichette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 557);
            this.Controls.Add(this.btnTipi);
            this.Controls.Add(this.grbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbEtichetta);
            this.Controls.Add(this.btnCrea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEtichette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etichette";
            this.Load += new System.EventHandler(this.frmEtichette_Load);
            this.grbEtichetta.ResumeLayout(false);
            this.grbEtichetta.PerformLayout();
            this.grbTipo.ResumeLayout(false);
            this.grbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInizio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrea;
        private System.Windows.Forms.TextBox tbxTitolo;
        private System.Windows.Forms.TextBox tbxTesto;
        private System.Windows.Forms.TextBox tbxProduzione;
        private System.Windows.Forms.TextBox tbxScadenza;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpProduzione;
        private System.Windows.Forms.DateTimePicker dtpScadenza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbEtichetta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbTipo;
        private System.Windows.Forms.ComboBox cbxEtichetta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudInizio;
        private System.Windows.Forms.Button btnTipi;
        private System.Windows.Forms.CheckBox chbBordi;
    }
}