using System.Threading.Tasks;
using Dapper;

namespace azicloud.wiki.bo.Interfaces
{
    public interface IDapperService
    {
        Task<SqlMapper.GridReader> ExecuteSpGridReader(string query, DynamicParameters parameters);
    }
}