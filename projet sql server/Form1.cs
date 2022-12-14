using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projet_sql_server
{

    public partial class Form1 : Form
    {
        Requete req = new Requete();
        string fromDGV;
        bool clicked = false;
        string btn;

        public Form1()
        {
            InitializeComponent();
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEcole_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            groupBox.Text = "ecole";
            groupBoxbtns.Visible = false;

            ajouter.Visible = false;
            btnJoin.Visible = false;

            dgv.DataSource = req.selectFromEcole();

        }
        private void groupBoxEcole_Enter(object sender, EventArgs e)
        {

        }
        private void btnEtudiant_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            groupBox.Text = "Etudiant";
            groupBoxbtns.Visible = true;

            ajouter.Visible = false;
            btnJoin.Visible = false;

            dgv.DataSource = req.selectFromEtudiant();
        }
        private void btnFiliere_Click(object sender, EventArgs e)
        {
            groupBox.Visible = true;
            groupBox.Text = "filiere";
            groupBoxbtns.Visible = false;

            btnJoin.Visible = false;

            dgv.DataSource = req.selectFromFiliere();
            if (clicked)
            {
                ajouter.Visible = true;
            }
            else
            {
                ajouter.Visible = false;
            }
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label2.Text = dgv.SelectedCells[0].Value.ToString();
            btnJoin.Visible = true;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            groupBoxtxt.Visible = true;

            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            btn = "insert";
        }
        private void groupBoxbtns_Enter(object sender, EventArgs e)
        {

        }
        private void txtboxNom_TextChanged(object sender, EventArgs e)
        {
            btnSave.BackColor = default;
            btnSave.Text = "save";
        }
        private void txtboxPrenom_TextChanged(object sender, EventArgs e)
        {
            btnSave.BackColor = default;
            btnSave.Text = "save";
        }
        private void txtboxCne_TextChanged(object sender, EventArgs e)
        {
            btnSave.BackColor = default;
            btnSave.Text = "save";
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            btnSave.BackColor = default;
            btnSave.Text = "save";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;

            if (btn == "insert")
            {
                string nom = txtboxNom.Text;
                string prenom = txtboxPrenom.Text;
                string cne = txtboxCne.Text;
                int note = (int)numericUpDown1.Value;

                if (note > 20 || note < 0 || cne == "" || nom == "" || prenom == "")
                {
                    btnSave.BackColor = Color.Red;
                    btnSave.Text = " try again";
                }
                else
                {
                    req.insertEtudiant(cne, nom, prenom, note);
                }
            }
            if (btn == "delete")
            {
                req.deleteEtudiant(label2.Text.ToString());
            }
            txtboxNom.Clear();
            txtboxPrenom.Clear();
            txtboxCne.Clear();
            numericUpDown1.Value = 0;
        }

        public string getFromtable(DataGridView dgv)
        {
            return dgv.SelectedCells[0].Value.ToString();
        }
        private void groupBoxtxt_Enter(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            groupBoxtxt.Visible = false;

            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            btn = "delete";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            clicked = true;
            btnFiliere.PerformClick();
            fromDGV = label2.Text;
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            req.inscrirEtudiant(fromDGV, int.Parse(dgv.SelectedCells[0].Value.ToString()), int.Parse(dgv.SelectedCells[3].Value.ToString()));
        }
    }
}