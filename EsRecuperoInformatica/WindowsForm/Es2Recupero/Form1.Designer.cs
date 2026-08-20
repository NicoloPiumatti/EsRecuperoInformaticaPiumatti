namespace Es2Recupero
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSquadre = new System.Windows.Forms.ComboBox();
            this.btnVis1 = new System.Windows.Forms.Button();
            this.btnOrdCresc = new System.Windows.Forms.Button();
            this.cmbGiocatori = new System.Windows.Forms.ComboBox();
            this.btnStatistiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome squadra";
            // 
            // cmbSquadre
            // 
            this.cmbSquadre.FormattingEnabled = true;
            this.cmbSquadre.Items.AddRange(new object[] {
            "Juventus",
            "Milan"});
            this.cmbSquadre.Location = new System.Drawing.Point(153, 25);
            this.cmbSquadre.Name = "cmbSquadre";
            this.cmbSquadre.Size = new System.Drawing.Size(121, 24);
            this.cmbSquadre.TabIndex = 1;
            // 
            // btnVis1
            // 
            this.btnVis1.Location = new System.Drawing.Point(306, 28);
            this.btnVis1.Name = "btnVis1";
            this.btnVis1.Size = new System.Drawing.Size(75, 23);
            this.btnVis1.TabIndex = 2;
            this.btnVis1.Text = "Visualizza";
            this.btnVis1.UseVisualStyleBackColor = true;
            this.btnVis1.Click += new System.EventHandler(this.btnVis1_Click);
            // 
            // btnOrdCresc
            // 
            this.btnOrdCresc.Location = new System.Drawing.Point(42, 72);
            this.btnOrdCresc.Name = "btnOrdCresc";
            this.btnOrdCresc.Size = new System.Drawing.Size(232, 23);
            this.btnOrdCresc.TabIndex = 3;
            this.btnOrdCresc.Text = "Visualizza ordine crescente";
            this.btnOrdCresc.UseVisualStyleBackColor = true;
            this.btnOrdCresc.Click += new System.EventHandler(this.btnOrdCresc_Click);
            // 
            // cmbGiocatori
            // 
            this.cmbGiocatori.FormattingEnabled = true;
            this.cmbGiocatori.Items.AddRange(new object[] {
            "Rossi",
            "Bianchi",
            "Ferrari",
            "Esposito"});
            this.cmbGiocatori.Location = new System.Drawing.Point(42, 121);
            this.cmbGiocatori.Name = "cmbGiocatori";
            this.cmbGiocatori.Size = new System.Drawing.Size(121, 24);
            this.cmbGiocatori.TabIndex = 4;
            // 
            // btnStatistiche
            // 
            this.btnStatistiche.Location = new System.Drawing.Point(199, 122);
            this.btnStatistiche.Name = "btnStatistiche";
            this.btnStatistiche.Size = new System.Drawing.Size(238, 23);
            this.btnStatistiche.TabIndex = 5;
            this.btnStatistiche.Text = "Visualizza statistiche giocatore";
            this.btnStatistiche.UseVisualStyleBackColor = true;
            this.btnStatistiche.Click += new System.EventHandler(this.btnStatistiche_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 490);
            this.Controls.Add(this.btnStatistiche);
            this.Controls.Add(this.cmbGiocatori);
            this.Controls.Add(this.btnOrdCresc);
            this.Controls.Add(this.btnVis1);
            this.Controls.Add(this.cmbSquadre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSquadre;
        private System.Windows.Forms.Button btnVis1;
        private System.Windows.Forms.Button btnOrdCresc;
        private System.Windows.Forms.ComboBox cmbGiocatori;
        private System.Windows.Forms.Button btnStatistiche;
    }
}

