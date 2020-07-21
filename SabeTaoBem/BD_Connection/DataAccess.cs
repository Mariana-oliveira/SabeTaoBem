using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SabeTaoBemLibrary.Models.Users;

namespace SabeTaoBem.BD_Connection
{
    public class DataAccess
    {
        public List<Users> GetUsers(Nullable<int> status)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(CnnStringHelper.CnnVal("SabeTaoBemDB")))
            {
                return connection.Query<Users>($"select * from tbUsers where Status = '{status}'").ToList();              
            }
        }
    }
}
