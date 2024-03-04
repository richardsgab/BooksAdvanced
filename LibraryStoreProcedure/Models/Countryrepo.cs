using Dapper;
using LibraryStoreProcedure.Connections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStoreProcedure.Models
{
    public class Countryrepo
    {
        public List<Country> GetCountries()
        {
            using (IDbConnection connection = new SqlConnection(Helper.ConStr("Books")))
            {
                var countries = connection.Query<Country>("GetAllCountries", 
                                commandType: CommandType.StoredProcedure).ToList();
                return countries;
            }
        }
        
    }
}
