using Dapper;
using LibraryStoreProcedure.Connections;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStoreProcedure.Models
{
    public class BookRepo
    {
        public void AddBook(Book book)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Title", book.Title);
            param.Add("@Author", book.Author);
            param.Add("@Price", book.Price);
            param.Add("@Description", book.Description);
            param.Add("@CountryId", book.CountryId);

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("AddBook", param, commandType: CommandType.StoredProcedure);
            }
        }
        public List<Book> GetBooks()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var books = connection.Query<Book>("GetAllBooks",
                                commandType: CommandType.StoredProcedure).ToList();
                return books;
            }
        }
        public void DeleteBook(Book book)
        {
            DynamicParameters param = new DynamicParameters();//to call store procedures
            param.Add("@Id", book.Id);
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("DeleteBook", param, commandType: CommandType.StoredProcedure);
            }

        }
        public void UpdateBook(Book book)
        {
            DynamicParameters param = new DynamicParameters();//to call store procedures
            param.Add("@Id", book.Id);
            param.Add("@Title", book.Title);
            param.Add("@Author", book.Author);
            param.Add("@Price", book.Price);
            param.Add("@Description", book.Description);
            param.Add("@CountryId", book.CountryId);

            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                connection.Execute("UpdateBook", param, commandType: CommandType.StoredProcedure);

            }
        }
        public List<Book> SearchBookByValue(Book book)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", book.Id);
            param.Add("@Title", book.Title);
            param.Add("@CountryId", book.CountryId);
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var books = connection.Query<Book>("SearchBookByValue",
                                commandType: CommandType.StoredProcedure);
                return books.ToList();
            }
        }
    } 
}
