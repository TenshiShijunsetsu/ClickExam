using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ClickExam.Models
{
    public class Clik
    {
        public int ID { get; set; }
        public int ClikCtr { get; set; }

    }

    public class ClikDBContext : DbContext
    {
        public ClikDBContext()
        {

        }
        public DbSet<Clik> Cliks { get; set; }
    }
}