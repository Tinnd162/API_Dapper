using System.Data;
using System.Threading.Tasks;
using azicloud.wiki.bo.Interfaces;
using Dapper;

namespace azicloud.wiki.bo.Category
{
    public class wiki_category : Iwiki_category
    {
        private readonly IDapperService _dapper;
        public wiki_category(IDapperService dapper)
        {
            _dapper = dapper;
        }

        public async Task<SqlMapper.GridReader> wiki_category_Create1(int Id, long uId, long parent_id, long image_id, string name, string description)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Id", Id, DbType.Int64);
            parameters.Add("uId", uId, DbType.Int64);
            parameters.Add("parent_id", parent_id, DbType.Int64);
            parameters.Add("image_id", image_id, DbType.Int64);
            parameters.Add("name", name, DbType.String);
            parameters.Add("description", description, DbType.String);
            var res = await _dapper.ExecuteSpGridReader("dbo.wiki_category_Create1", parameters);
            return res;
        }

        public async Task<SqlMapper.GridReader> wiki_category_Delete1(long intId, long uId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("intId", intId, DbType.Int64);
            parameters.Add("uId", uId, DbType.Int64);

            var res = await _dapper.ExecuteSpGridReader("dbo.wiki_category_Delete1", parameters);
            return res;
        }

        public async Task<SqlMapper.GridReader> wiki_category_Filter_Rows1()
        {
            var res = await _dapper.ExecuteSpGridReader("dbo.wiki_category_Filter_Rows1", new DynamicParameters());
            return res;
        }
    }
}