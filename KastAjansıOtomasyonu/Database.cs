using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace KastAjansıOtomasyonu
{
    class Database
    {
    public SqlConnection baglanti = new SqlConnection(@"Data Source=.\sqlexpress; Initial Catalog=CastAjansVeriTabani;Integrated Security=True");

    }
}
