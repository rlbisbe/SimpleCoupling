﻿using SampleCoupling.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCoupling.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
    }
}
