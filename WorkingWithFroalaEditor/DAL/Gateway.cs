using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WorkingWithFroalaEditor.Model;

namespace WorkingWithFroalaEditor.DAL
{
    public class Gateway
    {

        private string connectionString = WebConfigurationManager.ConnectionStrings["connectionStringForArticleDB"].ConnectionString;

        public int Save(Article aArticle)
        {
            string query = "INSERT INTO tbl_Article VALUES('" + aArticle.Description + "')";
            SqlConnection aConnection = new SqlConnection(connectionString);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            aConnection.Open();
            int rowAffected=   aCommand.ExecuteNonQuery();
            aConnection.Close();
            return rowAffected;
        }
    }
}