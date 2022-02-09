using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace BLBookAvenue
{
    
    public static class Starter
    {
   
        public static Book newBook()
        {
            return new Book();
        }

        public static Book getBookById(int Id)
        {
            return Book.getBookById(Id);
        }

        public static User newUser()
        {
            return new User();
        }

        public static bool getLogin(string username, string password)
        {
            return User.login(username, password);
        }

        public static User getUser(string username, string password)
        {
            return User.getUser(username, password);
        }

        public static bool getRegister(string username, string password)
        {
            if (User.checkUsername(username) == true)
            {
                return false;
            }
            else
            {
                return User.register(username, password);
            }
        }

        //alte Buchanzeige
        /*public static Books getBooks()
        {
            return Book.LoadAll();
        }*/
        
        internal static SqlConnection getConnection()
        {
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\yllos\source\repos\Bookavenue (1)\Bookavenue\DLBookavenue\Books.mdf; Integrated Security = True; Connect Timeout = 30;";
            SqlConnection conn = new SqlConnection(conString);
            conn.Open(); //try catch
            return conn;

        }

        public static bool uploadBook(string title, int year, string author, int pages, string type, bool availability, string contenttype, byte[] data)
        {
            return Book.uploadBook(title, year, author, pages, type, availability, contenttype, data);
        }

        public static SqlDataAdapter loadAllBooks()
        {
            return Book.loadAllBooks();
        }
    }
}
