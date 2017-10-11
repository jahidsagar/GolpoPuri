using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolpoPuri.DAL
{
    public class CategoryModel : ICategoryModel
    {
        private IUnitOfwork CategoryUnitofWork;
        public CategoryModel(IUnitOfwork CategoryUnitofWork)
        {
            this.CategoryUnitofWork = CategoryUnitofWork;
        }

        public Categories CreateCategory(string category)
        {
            var _Category = new Categories();
            _Category.Id = Guid.NewGuid();
            if (string.IsNullOrEmpty(category))
            {

            }
            else
                _Category.Category = category;

            CategoryUnitofWork.CategoryRepository.insert(_Category);
            CategoryUnitofWork.Save();
            return _Category;
        }

        public IEnumerable<Categories> GetCategoriess()
        {
            return CategoryUnitofWork.CategoryRepository.Get();
        }

        public Categories GetStory(Guid id)
        {
            return CategoryUnitofWork.CategoryRepository.GetByID(id);
        }

        public void DeleteStory(Guid id)
        {
            CategoryUnitofWork.StoryRepository.Delete(id);
            CategoryUnitofWork.Save();
        }

        public void UpdateStory(Guid id, string Category)
        {
            var story = CategoryUnitofWork.CategoryRepository.GetByID(id);
            story.Category = Category;
            CategoryUnitofWork.Save();
        }
    }
}