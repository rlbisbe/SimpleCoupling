using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Web;

namespace SampleCoupling.Models
{
[Table(Name = "Table")]
public class Book
{
    [Column(Name = "Title")]
    public string Title { get; set; }
        
    [Column(Name = "Author")]
    public string Author { get; set; }
}
}