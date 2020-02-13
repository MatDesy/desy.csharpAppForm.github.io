namespace AppHopitalUI
{
    partial class FrmListePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListePatient));
            this.lsvPatientEnAttente = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevenirActif = new System.Windows.Forms.Button();
            this.btnEnleverPatient = new System.Windows.Forms.Button();
            this.btnTerminerPatient = new System.Windows.Forms.Button();
            this.btnEncours = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lsvPatientAssigner = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lsvPatientEnAttente
            // 
            this.lsvPatientEnAttente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lsvPatientEnAttente.FullRowSelect = true;
            this.lsvPatientEnAttente.GridLines = true;
            this.lsvPatientEnAttente.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvPatientEnAttente.Location = new System.Drawing.Point(68, 89);
            this.lsvPatientEnAttente.MultiSelect = false;
            this.lsvPatientEnAttente.Name = "lsvPatientEnAttente";
            this.lsvPatientEnAttente.Size = new System.Drawing.Size(489, 682);
            this.lsvPatientEnAttente.TabIndex = 2;
            this.lsvPatientEnAttente.UseCompatibleStateImageBehavior = false;
            this.lsvPatientEnAttente.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID patient";
            this.columnHeader5.Width = 90;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nom";
            this.columnHeader6.Width = 127;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prénom";
            this.columnHeader7.Width = 117;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No Assurance Maladie";
            this.columnHeader8.Width = 94;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(186, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient en attente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1192, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient assigné";
            // 
            // btnDevenirActif
            // 
            this.btnDevenirActif.Location = new System.Drawing.Point(726, 89);
            this.btnDevenirActif.Name = "btnDevenirActif";
            this.btnDevenirActif.Size = new System.Drawing.Size(127, 73);
            this.btnDevenirActif.TabIndex = 5;
            this.btnDevenirActif.Text = "Assigner le patient";
            this.btnDevenirActif.UseVisualStyleBackColor = true;
            this.btnDevenirActif.Click += new System.EventHandler(this.btnDevenirActif_Click);
            // 
            // btnEnleverPatient
            // 
            this.btnEnleverPatient.Location = new System.Drawing.Point(726, 227);
            this.btnEnleverPatient.Name = "btnEnleverPatient";
            this.btnEnleverPatient.Size = new System.Drawing.Size(127, 73);
            this.btnEnleverPatient.TabIndex = 6;
            this.btnEnleverPatient.Text = "Mettre en attente";
            this.btnEnleverPatient.UseVisualStyleBackColor = true;
            this.btnEnleverPatient.Click += new System.EventHandler(this.btnEnleverPatient_Click);
            // 
            // btnTerminerPatient
            // 
            this.btnTerminerPatient.Location = new System.Drawing.Point(726, 365);
            this.btnTerminerPatient.Name = "btnTerminerPatient";
            this.btnTerminerPatient.Size = new System.Drawing.Size(127, 73);
            this.btnTerminerPatient.TabIndex = 7;
            this.btnTerminerPatient.Text = "Terminer avec le patient";
            this.btnTerminerPatient.UseVisualStyleBackColor = true;
            this.btnTerminerPatient.Click += new System.EventHandler(this.btnTerminerPatient_Click);
            // 
            // btnEncours
            // 
            this.btnEncours.Location = new System.Drawing.Point(726, 523);
            this.btnEncours.Name = "btnEncours";
            this.btnEncours.Size = new System.Drawing.Size(127, 73);
            this.btnEncours.TabIndex = 8;
            this.btnEncours.Text = "Mettre le patient en cours";
            this.btnEncours.UseVisualStyleBackColor = true;
            this.btnEncours.Click += new System.EventHandler(this.btnEncours_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(726, 787);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 38);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Fermer session";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lsvPatientAssigner
            // 
            this.lsvPatientAssigner.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10});
            this.lsvPatientAssigner.FullRowSelect = true;
            this.lsvPatientAssigner.GridLines = true;
            this.lsvPatientAssigner.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvPatientAssigner.Location = new System.Drawing.Point(1024, 89);
            this.lsvPatientAssigner.MultiSelect = false;
            this.lsvPatientAssigner.Name = "lsvPatientAssigner";
            this.lsvPatientAssigner.Size = new System.Drawing.Size(501, 682);
            this.lsvPatientAssigner.TabIndex = 10;
            this.lsvPatientAssigner.UseCompatibleStateImageBehavior = false;
            this.lsvPatientAssigner.View = System.Windows.Forms.View.Details;
            this.lsvPatientAssigner.DoubleClick += new System.EventHandler(this.lsvPatientAssigner_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID patient";
            this.columnHeader1.Width = 94;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prénom";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No Assurance Maladie";
            this.columnHeader4.Width = 87;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Status";
            // 
            // FrmListePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.lsvPatientAssigner);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEncours);
            this.Controls.Add(this.btnTerminerPatient);
            this.Controls.Add(this.btnEnleverPatient);
            this.Controls.Add(this.btnDevenirActif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvPatientEnAttente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListePatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des patients";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvPatientEnAttente;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDevenirActif;
        private System.Windows.Forms.Button btnEnleverPatient;
        private System.Windows.Forms.Button btnTerminerPatient;
        private System.Windows.Forms.Button btnEncours;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListView lsvPatientAssigner;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}