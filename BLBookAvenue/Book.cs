using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Web;
using System.Drawing;

namespace BLBookAvenue
{
    public class Book
    {

        public int bookID { get; private set; }
        public string title { get; set; }
        public DateTime year { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        public string type { get; set; }
        public bool availability { get; set; }


        internal Book() { }

        //notwendig für die alte Buchanzeige
        /*private static Book fillBookFromSQLDataReader(SqlDataReader reader)
        {
            Book book = new Book();
            book.bookID = reader.GetInt32(0);
            book.title = reader.GetString(1);
            book.year = reader.GetDateTime(2);
            book.author = reader.GetString(3);
            book.pages = reader.GetInt32(4);
            book.type = reader.GetString(5);
            book.availability = reader.GetBoolean(6);
            return book;
        }*/

        //funktioniert das noch? 
        internal static Book getBookById(int Id)
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "select bookID, title, year, author, pages, type, availability from Books where bookID=@id";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", Id);

            SqlDataReader reader = cmd.ExecuteReader(); //try catch
            Book e = null;
            if (reader.Read())
            {
                e = new Book();
                e.bookID = reader.GetInt32(0);
                e.title = reader.GetString(1);
                e.year = reader.GetDateTime(2);
                e.author = reader.GetString(3);
                e.pages = reader.GetInt32(4);
                e.type = reader.GetString(5);
                e.availability = reader.GetBoolean(6);
            }

            conn.Close();
            return e;

        }

        //alte Buchanzeige
        /*internal static Books LoadAll()
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "select * from Books";
            cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            Books allBooks = new Books();
            while (reader.Read())
            {
                Book book = fillBookFromSQLDataReader(reader);
                allBooks.Add(book);
            }
            return allBooks;
        }*/

        //es wird ein neues Buch hinzugefügt, sowie ein True returniert, wenn es geklappt hat
        internal static bool uploadBook(string title, int year, string author, int pages, string type, bool availability, string contentType, byte[] data)
        {
            SqlConnection conn = Starter.getConnection();
            SqlCommand cmd;
            string sql;

            sql = "Insert into Books values(@title, @year, @author, @pages, @type, @availability, @contentType, @data)";
            cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("title", title);
            cmd.Parameters.AddWithValue("year", year);
            cmd.Parameters.AddWithValue("author", author);
            cmd.Parameters.AddWithValue("pages", pages);
            cmd.Parameters.AddWithValue("type", type);
            cmd.Parameters.AddWithValue("availability", availability);
            cmd.Parameters.AddWithValue("contentType", contentType);
            cmd.Parameters.AddWithValue("data", data);

            return (cmd.ExecuteNonQuery() > 0);
        }

        //es werden alle Bücher mithilfe des SqlDataAdapters geladen und returniert
        internal static SqlDataAdapter loadAllBooks()
        {
            SqlConnection conn = Starter.getConnection();
            SqlDataAdapter sda;
            string sql;

            sql = "Select * from Books";

            sda = new SqlDataAdapter(sql, conn);

            return sda;
        }
    }
}
