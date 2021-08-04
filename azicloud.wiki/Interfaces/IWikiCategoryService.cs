using System.Collections.Generic;
using System.Threading.Tasks;
using azicloud.wiki.DTOs;

namespace azicloud.wiki.Interfaces
{
    public interface IWikiCategoryService
    {
        Task<List<GetWikiCategoryDto>> Filter_Rows1();
        Task<int> Create1(PostWikiCategoryDto req);
        Task<int> Delete1(long intId, long uId);
    }
}