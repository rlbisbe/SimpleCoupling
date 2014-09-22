using SampleCoupling.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleCoupling.Controllers
{
public class HomeController : Controller
{
    public ActionResult Books()
    {
        List<Book> books = new List<Book>();
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\v11.0;AttachDbFilename=|DataDirectory|\Books.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader;

        cmd.CommandText = "SELECT Title,Author FROM [Table]";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = connection;

        connection.Open();

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

        connection.Close();
        return View(books);
    }
}
}