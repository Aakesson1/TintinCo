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
            List<Comic> listOfDogs = new List<Comic>();

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
                    comic.ID= Convert.ToInt32(row["ID"]);
                    comic.Title = row["Title"].ToString();
                    comic.Amount = Convert.ToInt32(row["Amount"]);
                    comic.Request = row["Request"].ToString();
                    comic.ReleaseYear = Convert.ToInt32(row["ReleaseYear"]);
                    comic.QualityColor= row["QualityColor"].ToString();
                    comic.Price = Convert.ToInt32(row["Price"]);


                    listOfDogs.Add(comic);
                }
                return listOfDogs;
            }
        }
        
        public void AddComic(Comic comic)
        {

            using (SqlConnection conn = new SqlConnection("Server=10.56.8.36;Database=DB22;User Id = STUDENT22; Password=OPENDB_22;"))
            {
                SqlCommand AddComicToSQL = new SqlCommand("spaddComic", conn);
                conn.Open();
                AddComicToSQL.CommandType = CommandType.StoredProcedure;
                AddComicToSQL.Parameters.AddWithValue("@Title", comic.Title);
                AddComicToSQL.Parameters.AddWithValue("@ReleaseYear", comic.ReleaseYear);
                AddComicToSQL.Parameters.AddWithValue("@Amount", comic.Amount);
                AddComicToSQL.Parameters.AddWithValue("@Request", comic.Request);
                AddComicToSQL.Parameters.AddWithValue("@QualityColor", comic.QualityColor);
                AddComicToSQL.Parameters.AddWithValue("@Price", comic.Price);
                AddComicToSQL.Parameters.AddWithValue("@Description", comic.Description);
                AddComicToSQL.ExecuteNonQuery();
            }
        }
        /*
        public void DeleteDog(int id)
        {
            using (SqlConnection conn = new SqlConnection("Server=10.56.8.36;Database=DB22;User Id = STUDENT22; Password=OPENDB_22;"))
            {
                SqlCommand query = new SqlCommand("spDeleteDog", conn);
                conn.Open();
                query.CommandType = CommandType.StoredProcedure;
                SqlParameter DelDogFromSql = new SqlParameter("Id", SqlDbType.Int);
                DelDogFromSql.Value = id;
                query.Parameters.Add(DelDogFromSql);

                query.ExecuteNonQuery();
            }
        }
        */
    }
}

