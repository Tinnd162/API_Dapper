using System.Collections.Generic;
using System.Threading.Tasks;
using azicloud.wiki.DTOs;
using azicloud.wiki.Interfaces;
using azicloud.wiki.bo.Interfaces;
using System.Linq;

namespace azicloud.wiki.Repositories
{
    public class WikiCategoryService : IWikiCategoryService
    {
        private readonly Iwiki_category _wikiCategory;
        public WikiCategoryService(Iwiki_category wikiCategory)
        {
            _wikiCategory = wikiCategory;
        }

        public async Task<int> Create1(PostWikiCategoryDto req)
        {
            var res = await _wikiCategory.wiki_category_Create1(req.Id, req.uId, req.parent_id, req.image_id, req.name, req.description);
            var readres = res.Read<int>().FirstOrDefault();
            return readres;
        }

        public async Task<int> Delete1(long intId, long uId)
        {
            var res = await _wikiCategory.wiki_category_Delete1(intId, uId);
            var readres = res.Read<int>().FirstOrDefault();
            return readres;
        }

        public async Task<List<GetWikiCategoryDto>> Filter_Rows1()
        {
            var categories = new List<GetWikiCategoryDto>();
            var result = await _wikiCategory.wiki_category_Filter_Rows1();

            categories = result.Read<GetWikiCategoryDto>().ToList();
            return categories;
        }
    }
}