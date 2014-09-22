using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SampleCoupling.Models
{
public interface IBookRepository
{
    List<Book> GetAllBooks();
}

public class BookRepository : IBookRepository
{
    private SqlConnection _connection;
    private string _connectionString = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True";
    public BookRepository()
    {
        _connection = new SqlConnection(_connectionString);
    }

    public List<Book> GetAllBooks()
    {
        List<Book> books = new List<Book>();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "SELECT Title,Author FROM [Table]";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = _connection;

        _connection.Open();

        reader = cmd.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                books.Add(new Book
                {
                    Title = reader.GetString(0),
                    Author = reader.GetString(1)
                });
            }
        }

        _connection.Close();
        return books;
    }
}
}