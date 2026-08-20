namespace Es1Recupero
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nudToner = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatistica = new System.Windows.Forms.ComboBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.lblStampa = new System.Windows.Forms.Label();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnVisualizza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudToner)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(159, 28);
            this.txtNome.MaxLength = 5;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(141, 22);
            this.txtNome.TabIndex = 0;
            // 
            // nudToner
            // 
            this.nudToner.Location = new System.Drawing.Point(159, 70);
            this.nudToner.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudToner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToner.Name = "nudToner";
            this.nudToner.Size = new System.Drawing.Size(141, 22);
            this.nudToner.TabIndex = 1;
            this.nudToner.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome dipartimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero cartucce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Indicatore statistico";
            // 
            // cmbStatistica
            // 
            this.cmbStatistica.FormattingEnabled = true;
            this.cmbStatistica.Items.AddRange(new object[] {
            "Min",
            "Max",
            "Med"});
            this.cmbStatistica.Location = new System.Drawing.Point(662, 34);
            this.cmbStatistica.Name = "cmbStatistica";
            this.cmbStatistica.Size = new System.Drawing.Size(141, 24);
            this.cmbStatistica.TabIndex = 5;
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(173, 110);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(141, 33);
            this.btnSalva.TabIndex = 6;
            this.btnSalva.Text = "Salva su file";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // lblStampa
            // 
            this.lblStampa.AutoSize = true;
            this.lblStampa.Location = new System.Drawing.Point(510, 85);
            this.lblStampa.Name = "lblStampa";
            this.lblStampa.Size = new System.Drawing.Size(0, 16);
            this.lblStampa.TabIndex = 7;
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(26, 110);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(141, 33);
            this.btnLista.TabIndex = 8;
            this.btnLista.Text = "Salva su lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnVisualizza
            // 
            this.btnVisualizza.Location = new System.Drawing.Point(513, 128);
            this.btnVisualizza.Name = "btnVisualizza";
            this.btnVisualizza.Size = new System.Drawing.Size(141, 37);
            this.btnVisualizza.TabIndex = 9;
            this.btnVisualizza.Text = "Visualizza label";
            this.btnVisualizza.UseVisualStyleBackColor = true;
            this.btnVisualizza.Click += new System.EventHandler(this.btnVisualizza_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 487);
            this.Controls.Add(this.btnVisualizza);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.lblStampa);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.cmbStatistica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudToner);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudToner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.NumericUpDown nudToner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatistica;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Label lblStampa;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnVisualizza;
    }
}

