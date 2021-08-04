using System.Threading.Tasks;
using Dapper;

namespace azicloud.wiki.bo.Interfaces
{
    public interface Iwiki_category
    {
        Task<SqlMapper.GridReader> wiki_category_Filter_Rows1();
        Task<SqlMapper.GridReader> wiki_category_Create1(int Id, long uId, long parent_id, long image_id, string name, string description);
        Task<SqlMapper.GridReader> wiki_category_Delete1(long intId, long uId);
    }
}