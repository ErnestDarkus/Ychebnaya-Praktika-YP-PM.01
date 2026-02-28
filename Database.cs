using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CompTech
{
    public static class Database
    {
        public static string ConnectionString =
             @"Data Source=localhost;
              Initial Catalog=CompTech;
              Integrated Security=True;
              TrustServerCertificate=True;";
    }
}
