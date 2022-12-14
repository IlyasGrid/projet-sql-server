namespace projet_sql_server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEtudiant = new System.Windows.Forms.Button();
            this.btnFiliere = new System.Windows.Forms.Button();
            this.btnEcole = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.groupBoxbtns = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxtxt = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcne = new System.Windows.Forms.Label();
            this.lblprenom = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtboxCne = new System.Windows.Forms.TextBox();
            this.txtboxPrenom = new System.Windows.Forms.TextBox();
            this.txtboxNom = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnJoin = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.groupBoxbtns.SuspendLayout();
            this.groupBoxtxt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEtudiant
            // 
            this.btnEtudiant.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEtudiant.Location = new System.Drawing.Point(25, 35);
            this.btnEtudiant.Name = "btnEtudiant";
            this.btnEtudiant.Size = new System.Drawing.Size(120, 36);
            this.btnEtudiant.TabIndex = 0;
            this.btnEtudiant.Text = "Etudiant";
            this.btnEtudiant.UseVisualStyleBackColor = true;
            this.btnEtudiant.Click += new System.EventHandler(this.btnEtudiant_Click);
            // 
            // btnFiliere
            // 
            this.btnFiliere.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFiliere.Location = new System.Drawing.Point(301, 35);
            this.btnFiliere.Name = "btnFiliere";
            this.btnFiliere.Size = new System.Drawing.Size(120, 36);
            this.btnFiliere.TabIndex = 1;
            this.btnFiliere.Text = "Filiere";
            this.btnFiliere.UseVisualStyleBackColor = true;
            this.btnFiliere.Click += new System.EventHandler(this.btnFiliere_Click);
            // 
            // btnEcole
            // 
            this.btnEcole.Font = new System.Drawing.Font("Andalus", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEcole.Location = new System.Drawing.Point(612, 35);
            this.btnEcole.Name = "btnEcole";
            this.btnEcole.Size = new System.Drawing.Size(120, 36);
            this.btnEcole.TabIndex = 2;
            this.btnEcole.Text = "Ecole";
            this.btnEcole.UseVisualStyleBackColor = true;
            this.btnEcole.Click += new System.EventHandler(this.btnEcole_Click);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.ajouter);
            this.groupBox.Controls.Add(this.groupBoxbtns);
            this.groupBox.Controls.Add(this.dgv);
            this.groupBox.Controls.Add(this.btnJoin);
            this.groupBox.Location = new System.Drawing.Point(38, 99);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(733, 532);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "sui";
            this.groupBox.Visible = false;
            this.groupBox.Enter += new System.EventHandler(this.groupBoxEcole_Enter);
            // 
            // ajouter
            // 
            this.ajouter.Location = new System.Drawing.Point(251, 234);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(94, 29);
            this.ajouter.TabIndex = 16;
            this.ajouter.Text = "ajouter";
            this.ajouter.UseVisualStyleBackColor = true;
            this.ajouter.Visible = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // groupBoxbtns
            // 
            this.groupBoxbtns.Controls.Add(this.label2);
            this.groupBoxbtns.Controls.Add(this.groupBoxtxt);
            this.groupBoxbtns.Controls.Add(this.btnDelete);
            this.groupBoxbtns.Controls.Add(this.btnInsert);
            this.groupBoxbtns.Controls.Add(this.btnCancel);
            this.groupBoxbtns.Controls.Add(this.btnSave);
            this.groupBoxbtns.Location = new System.Drawing.Point(6, 284);
            this.groupBoxbtns.Name = "groupBoxbtns";
            this.groupBoxbtns.Size = new System.Drawing.Size(681, 216);
            this.groupBoxbtns.TabIndex = 15;
            this.groupBoxbtns.TabStop = false;
            this.groupBoxbtns.Enter += new System.EventHandler(this.groupBoxbtns_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 22;
            // 
            // groupBoxtxt
            // 
            this.groupBoxtxt.Controls.Add(this.label4);
            this.groupBoxtxt.Controls.Add(this.lblcne);
            this.groupBoxtxt.Controls.Add(this.lblprenom);
            this.groupBoxtxt.Controls.Add(this.lblnom);
            this.groupBoxtxt.Controls.Add(this.numericUpDown1);
            this.groupBoxtxt.Controls.Add(this.txtboxCne);
            this.groupBoxtxt.Controls.Add(this.txtboxPrenom);
            this.groupBoxtxt.Controls.Add(this.txtboxNom);
            this.groupBoxtxt.Location = new System.Drawing.Point(15, 26);
            this.groupBoxtxt.Name = "groupBoxtxt";
            this.groupBoxtxt.Size = new System.Drawing.Size(487, 91);
            this.groupBoxtxt.TabIndex = 21;
            this.groupBoxtxt.TabStop = false;
            this.groupBoxtxt.Text = "groupBox1";
            this.groupBoxtxt.Enter += new System.EventHandler(this.groupBoxtxt_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "note";
            // 
            // lblcne
            // 
            this.lblcne.AutoSize = true;
            this.lblcne.Location = new System.Drawing.Point(253, 27);
            this.lblcne.Name = "lblcne";
            this.lblcne.Size = new System.Drawing.Size(37, 20);
            this.lblcne.TabIndex = 13;
            this.lblcne.Text = "CNE";
            // 
            // lblprenom
            // 
            this.lblprenom.AutoSize = true;
            this.lblprenom.Location = new System.Drawing.Point(1, 60);
            this.lblprenom.Name = "lblprenom";
            this.lblprenom.Size = new System.Drawing.Size(61, 20);
            this.lblprenom.TabIndex = 12;
            this.lblprenom.Text = "prenom";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(1, 34);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(39, 20);
            this.lblnom.TabIndex = 11;
            this.lblnom.Text = "nom";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(324, 53);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(125, 27);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtboxCne
            // 
            this.txtboxCne.Location = new System.Drawing.Point(324, 20);
            this.txtboxCne.Name = "txtboxCne";
            this.txtboxCne.Size = new System.Drawing.Size(125, 27);
            this.txtboxCne.TabIndex = 9;
            this.txtboxCne.TextChanged += new System.EventHandler(this.txtboxCne_TextChanged);
            // 
            // txtboxPrenom
            // 
            this.txtboxPrenom.Location = new System.Drawing.Point(63, 62);
            this.txtboxPrenom.Name = "txtboxPrenom";
            this.txtboxPrenom.Size = new System.Drawing.Size(125, 27);
            this.txtboxPrenom.TabIndex = 8;
            this.txtboxPrenom.TextChanged += new System.EventHandler(this.txtboxPrenom_TextChanged);
            // 
            // txtboxNom
            // 
            this.txtboxNom.Location = new System.Drawing.Point(62, 29);
            this.txtboxNom.Name = "txtboxNom";
            this.txtboxNom.Size = new System.Drawing.Size(125, 27);
            this.txtboxNom.TabIndex = 7;
            this.txtboxNom.TextChanged += new System.EventHandler(this.txtboxNom_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(108, 123);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "inserer";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(576, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(576, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(56, 26);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 29;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(609, 188);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnJoin
            // 
            this.btnJoin.Location = new System.Drawing.Point(56, 234);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(155, 29);
            this.btnJoin.TabIndex = 6;
            this.btnJoin.Text = "joindre une filiere";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Visible = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 611);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnEcole);
            this.Controls.Add(this.btnFiliere);
            this.Controls.Add(this.btnEtudiant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBoxbtns.ResumeLayout(false);
            this.groupBoxbtns.PerformLayout();
            this.groupBoxtxt.ResumeLayout(false);
            this.groupBoxtxt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnEtudiant;
        private Button btnFiliere;
        private Button btnEcole;
        private GroupBox groupBox;
        private DataGridView dgv;
        private Button btnJoin;
        private Button btnCancel;
        private Button btnSave;
        private Button btnDelete;
        private Button btnInsert;
        private GroupBox groupBoxbtns;
        private Label label4;
        private Label lblcne;
        private Label lblprenom;
        private Label lblnom;
        private NumericUpDown numericUpDown1;
        private TextBox txtboxCne;
        private TextBox txtboxPrenom;
        private TextBox txtboxNom;
        private GroupBox groupBoxtxt;
        private Label label2;
        private Button ajouter;
    }
}