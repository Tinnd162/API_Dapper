using System.Data;
using System.Threading.Tasks;
using azicloud.wiki.bo.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace azicloud.wiki.bo.Category
{
    public class DapperService : IDapperService
    {
        private readonly string _conStr;
        public DapperService(string conStr)
        {
            _conStr = conStr;
        }

        public async Task<SqlMapper.GridReader> ExecuteSpGridReader(string sp, DynamicParameters parameters)
        {
            IDbConnection _connect= new SqlConnection(_conStr);
            try
            {
                if (_connect.State == ConnectionState.Closed)
                    _connect.Open();

                SqlMapper.GridReader grid = await _connect.QueryMultipleAsync(sp, parameters, commandType: CommandType.StoredProcedure);
                return grid;
            }
            catch
            {
                return null;
            }
        }
    }
}