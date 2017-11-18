using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZakupowyProjekt.Models
{
    public class DbModel
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cena { get; set; }
            public DateTime Data { get; set; }
            public DateTime? DateModified { get; set; }
    }
    }
