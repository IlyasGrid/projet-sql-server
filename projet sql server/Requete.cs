using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projet_sql_server
{
    public class Requete
    {
        static string chaine = @"Data Source=DESKTOP-IOMF4D2\MSSQLSERVER02 ;Initial Catalog=projet 1;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);



        public void insertEtudiant(string cne, string nom, string prenom, int note)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into etudiant ( cne,nom,prenom,note ) values('" + cne + " ','" + nom + "','" + prenom + "','" + note + "') ;";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        public void inscrirEtudiant(string cne, int idf, int ide)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into inscription (idecole,idfiliere,cneEtudiant) values(" + ide + " ," + idf + ",'" + cne + "') ;";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public void deleteEtudiant(string cne)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from etudiant where cne = '" + cne.ToString() + "';";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        public DataTable selectFromEcole()
        {
            string query = "select * from etablissement";
            cmd.CommandText = query;
            cnx.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, cnx);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cnx.Close();
            return dt;
        }
        public DataTable selectFromFiliere()
        {
            string query = "select f.id as idfiliere, f.nom as nom_Filiere, f.noteacces  ,e.id as idEcole, e.nom as nom_Ecole ,e.ville  from filiere f join etablissement e on e.id=f.idecole ;";
            cmd.CommandText = query;
            cnx.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, cnx);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cnx.Close();
            return dt;
        }
        public DataTable selectFromEtudiant()
        {
            string query = "select * from etudiant;";
            cmd.CommandText = query;
            cnx.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, cnx);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            cnx.Close();
            return dt;
        }


    }
}
