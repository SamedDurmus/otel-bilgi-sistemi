using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelBilgiSistemi
{
    public static class Statik
    {
        public static SqlConnection bagla = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = OtelBilgiSistemiDB; Integrated Security = True");
        

    }
}
