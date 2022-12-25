using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintinCo_.Model
{
    public class ComicRepository
    {
        public List<Comic> comicRepository { get; set; }

        public ComicRepository()
        {
            comicRepository = GetComicRepo();
        }


        public List<Comic> GetComicRepo()
        {
            List<Comic> listofComics = new List<Comic>();

            using (SqlConnection conn = new SqlConnection("Server=10.56.8.36;Database=DB22;User Id = STUDENT22; Password=OPENDB_22;"))
            {
                SqlCommand query = new SqlCommand("select * From Inventory INNER Join Comic On Comic.TitleID = Inventory.ID", conn);
                conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    Comic comic = new Comic();
                    comic.ID = Convert.ToInt32(row["ID"]);
                    comic.Title = row["Title"].ToString();
                    comic.Amount = Convert.ToInt32(row["Amount"]);
                    comic.Request = row["Request"].ToString();
                    comic.ReleaseYear = Convert.ToInt32(row["ReleaseYear"]);
                    comic.QualityColor = row["QualityColor"].ToString();
                    comic.Price = Convert.ToInt32(row["Price"]);
                    comic.TitleID = Convert.ToInt32(row["TitleID"]);


                    listofComics.Add(comic);
                }
                return listofComics;
            }
        }

        public void AddComic(Comic comic)
        {

            using (SqlConnection conn = new SqlConnection("Server=10.56.8.36;Database=DB22;User Id = STUDENT22; Password=OPENDB_22;"))
            {
                SqlCommand AddComicToSQL = new SqlCommand("spaddComic", conn);
                conn.Open();
                AddComicToSQL.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Title", SqlDbType.VarChar);
                SqlParameter param2 = new SqlParameter("@ReleaseYear", SqlDbType.Int);
                SqlParameter param3 = new SqlParameter("@Amount", SqlDbType.Int);
                SqlParameter param4 = new SqlParameter("@Request", SqlDbType.VarChar);
                SqlParameter param5 = new SqlParameter("@QualityColor", SqlDbType.VarChar);
                SqlParameter param6 = new SqlParameter("@Price", SqlDbType.Int);
                SqlParameter param7 = new SqlParameter("@Description", SqlDbType.VarChar);
                SqlParameter param8 = new SqlParameter("@TitleID", SqlDbType.Int);

                param1.Value = comic.Title;
                param2.Value = comic.ReleaseYear;
                param3.Value = comic.Amount;
                param4.Value = comic.Request;
                param5.Value = comic.QualityColor;
                param6.Value = comic.Price;
                param7.Value = comic.Description;
                param8.Value = comic.TitleID;

                AddComicToSQL.Parameters.Add(param1);
                AddComicToSQL.Parameters.Add(param2);
                AddComicToSQL.Parameters.Add(param3);
                AddComicToSQL.Parameters.Add(param4);
                AddComicToSQL.Parameters.Add(param5);
                AddComicToSQL.Parameters.Add(param6);
                AddComicToSQL.Parameters.Add(param7);
                AddComicToSQL.Parameters.Add(param8);
                AddComicToSQL.ExecuteNonQuery();

            }
        }
        public void DeleteComic(int id)
        {
            using (SqlConnection conn = new SqlConnection("Server=10.56.8.36;Database=DB22;User Id = STUDENT22; Password=OPENDB_22;"))
            {

                SqlCommand DelComicFromSql = new SqlCommand("spdelComic", conn);
                conn.Open();
                DelComicFromSql.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("ID", SqlDbType.Int);
                param1.Value = id;
                DelComicFromSql.Parameters.Add(param1);

                DelComicFromSql.ExecuteNonQuery();
            }
        }
        public void UpdateComic(Comic comic)
        {
            using (SqlConnection conn = new SqlConnection("Server=10.56.8.36;Database=DB22;User Id = STUDENT22; Password=OPENDB_22;"))
            {


                SqlCommand updateComicToSql = new SqlCommand("updateComic", conn);
                conn.Open();
                updateComicToSql.CommandType = CommandType.StoredProcedure;
                SqlParameter param1 = new SqlParameter("@Title", SqlDbType.VarChar);
                SqlParameter param2 = new SqlParameter("@ReleaseYear", SqlDbType.Int);
                SqlParameter param3 = new SqlParameter("@Amount", SqlDbType.Int);
                SqlParameter param4 = new SqlParameter("@Request", SqlDbType.VarChar);
                SqlParameter param5 = new SqlParameter("@QualityColor", SqlDbType.VarChar);
                SqlParameter param6 = new SqlParameter("@Price", SqlDbType.Int);
                SqlParameter param7 = new SqlParameter("@Description", SqlDbType.VarChar);
                SqlParameter param8 = new SqlParameter("@TitleID", SqlDbType.Int);
                SqlParameter param9 = new SqlParameter("@ID", SqlDbType.Int);

                param1.Value = comic.Title;
                param2.Value = comic.ReleaseYear;
                param3.Value = comic.Amount;
                param4.Value = comic.Request;
                param5.Value = comic.QualityColor;
                param6.Value = comic.Price;
                param7.Value = comic.Description;
                param8.Value = comic.TitleID;
                param9.Value = comic.ID;

                updateComicToSql.Parameters.Add(param1);
                updateComicToSql.Parameters.Add(param2);
                updateComicToSql.Parameters.Add(param3);
                updateComicToSql.Parameters.Add(param4);
                updateComicToSql.Parameters.Add(param5);
                updateComicToSql.Parameters.Add(param6);
                updateComicToSql.Parameters.Add(param7);
                updateComicToSql.Parameters.Add(param8);
                updateComicToSql.Parameters.Add(param9);

                updateComicToSql.ExecuteNonQuery();
            }
        }

    }
}

