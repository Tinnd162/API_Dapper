using System.Threading.Tasks;
using azicloud.wiki.DTOs;
using azicloud.wiki.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace azicloud.wiki.Controllers
{
    public class CategoriesController : BaseApiController
    {
        private readonly IWikiCategoryService _categoryService;
        public CategoriesController(IWikiCategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("list")]
        public async Task<IActionResult> Filter_Rows1()
        {
            return Ok(await _categoryService.Filter_Rows1());
        }

        [HttpPost("create-update")]
        public async Task<IActionResult> Create1(PostWikiCategoryDto req)
        {
            return Ok(await _categoryService.Create1(req));
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete1(long intId, long uId)
        {
            return Ok(await _categoryService.Delete1(intId, uId));
        }
    }
}