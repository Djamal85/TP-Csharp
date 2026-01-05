namespace AppGestionCahierTexte.Views.Parametre
{
    partial class frmClasse
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
            this.DgClasse = new System.Windows.Forms.DataGridView();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.TxtAnneeAcademique = new System.Windows.Forms.Label();
            this.cbbAnneeAcademique = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtRClasse = new System.Windows.Forms.TextBox();
            this.txtRAnnee = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // DgClasse
            // 
            this.DgClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgClasse.Location = new System.Drawing.Point(308, 91);
            this.DgClasse.Name = "DgClasse";
            this.DgClasse.RowHeadersWidth = 51;
            this.DgClasse.RowTemplate.Height = 24;
            this.DgClasse.Size = new System.Drawing.Size(613, 438);
            this.DgClasse.TabIndex = 0;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Location = new System.Drawing.Point(39, 96);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(36, 32);
            this.lblLibelle.TabIndex = 1;
            this.lblLibelle.Text = "Libel\r\nle";
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(27, 131);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(258, 22);
            this.txtLibelle.TabIndex = 2;
            // 
            // TxtAnneeAcademique
            // 
            this.TxtAnneeAcademique.AutoSize = true;
            this.TxtAnneeAcademique.Location = new System.Drawing.Point(27, 198);
            this.TxtAnneeAcademique.Name = "TxtAnneeAcademique";
            this.TxtAnneeAcademique.Size = new System.Drawing.Size(126, 16);
            this.TxtAnneeAcademique.TabIndex = 3;
            this.TxtAnneeAcademique.Text = "Annee Academique";
            // 
            // cbbAnneeAcademique
            // 
            this.cbbAnneeAcademique.FormattingEnabled = true;
            this.cbbAnneeAcademique.Location = new System.Drawing.Point(30, 227);
            this.cbbAnneeAcademique.Name = "cbbAnneeAcademique";
            this.cbbAnneeAcademique.Size = new System.Drawing.Size(255, 24);
            this.cbbAnneeAcademique.TabIndex = 4;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(30, 332);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(148, 40);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "&Ajouter";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(30, 395);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 40);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "&Modifier";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "&Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(27, 22);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(196, 40);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "&Selectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtRClasse
            // 
            this.txtRClasse.Location = new System.Drawing.Point(390, 40);
            this.txtRClasse.Name = "txtRClasse";
            this.txtRClasse.Size = new System.Drawing.Size(125, 22);
            this.txtRClasse.TabIndex = 9;
            // 
            // txtRAnnee
            // 
            this.txtRAnnee.Location = new System.Drawing.Point(610, 40);
            this.txtRAnnee.Name = "txtRAnnee";
            this.txtRAnnee.Size = new System.Drawing.Size(134, 22);
            this.txtRAnnee.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(789, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 40);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Classe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Annee";
            // 
            // frmClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 550);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRAnnee);
            this.Controls.Add(this.txtRClasse);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.cbbAnneeAcademique);
            this.Controls.Add(this.TxtAnneeAcademique);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.DgClasse);
            this.Name = "frmClasse";
            this.Text = "Classe";
            this.Load += new System.EventHandler(this.frmClasse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgClasse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgClasse;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label TxtAnneeAcademique;
        private System.Windows.Forms.ComboBox cbbAnneeAcademique;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtRClasse;
        private System.Windows.Forms.TextBox txtRAnnee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}