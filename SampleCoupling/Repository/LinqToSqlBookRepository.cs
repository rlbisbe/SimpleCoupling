using SampleCoupling.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleCoupling.Repository
{
    public class LinqToSqlBookRepository : IBookRepository
    {
        private DataContext _db;
        private string _connectionString = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
        public LinqToSqlBookRepository()
        {
            _db = new DataContext(_connectionString);
        }

        public List<Book> GetAllBooks()
        {
            Table<Book> book = _db.GetTable<Book>();
            return book.ToList<Book>();
        }
    }
}