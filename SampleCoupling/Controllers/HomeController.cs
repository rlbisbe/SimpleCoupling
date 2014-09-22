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
    private IBookRepository _bookRepository;

    public HomeController()
    {
        _bookRepository = new BookRepository();
    }

    public ActionResult Books()
    {
        return View(_bookRepository.GetAllBooks());
    }
}
}