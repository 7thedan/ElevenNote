using ElevenNote.MDELS;
using ElevenNote.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace ElevenNote.WebAPI.Controllers
{
    [Authorize]
    public class CategoryController : ApiController
    {
        public IHttpActionResult Get()
        {
            var cService = CreateCategoryService();
            var categories = cService.GetCategories();
            return Ok(categories);
        }
        public IHttpActionResult Post(CategoryCreate category)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var cService = CreateCategoryService();

            if (!cService.CreateCategory(category))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            var cService = CreateCategoryService();
            var category = cService.GetCategoryById(id);
            return Ok(category);
        }

        public IHttpActionResult Delete(int id)
        {
            var cService = CreateCategoryService();

            if (!cService.DeleteCategory(id))
                return InternalServerError();

            return Ok();
        }
        private CategoryService CreateCategoryService()
        {
            var categoryService = new CategoryService();
            return categoryService;
        }
      

    }
}