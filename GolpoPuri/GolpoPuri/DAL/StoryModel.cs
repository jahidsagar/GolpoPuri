using GolpoPuri.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolpoPuri.DAL
{
    public class StoryModel : IStoryModel
    {
        private IUnitOfwork StoryUnitofWork;
        public StoryModel(IUnitOfwork StoryUnitofWork)
        {
            this.StoryUnitofWork = StoryUnitofWork;
        }

        public Story CreateStory(string Title , string Body , string ImageUrl)
        {
            var _Story = new Story();
            _Story.Id = Guid.NewGuid();
            _Story.Title = Title;
            _Story.Body = Body;
            if (string.IsNullOrEmpty(ImageUrl))
            {
                _Story.ImageUrl = "";
            }
            _Story.ImageUrl = ImageUrl;
            _Story.StoryTime = DateTime.Now;

            StoryUnitofWork.StoryRepository.insert(_Story);
            StoryUnitofWork.Save();

            return _Story;
        }

        public IEnumerable<Story> GetStories()
        {
            return StoryUnitofWork.StoryRepository.Get();
        }

        public Story GetStory(Guid id)
        {
            return StoryUnitofWork.StoryRepository.GetByID(id);
        }

        public void DeleteStory(Guid id)
        {
            StoryUnitofWork.StoryRepository.Delete(id);
            StoryUnitofWork.Save();
        }

        public void UpdateStory(Guid id, string title, string Body)
        {
            var story = StoryUnitofWork.StoryRepository.GetByID(id);
            story.Title = title;
            story.Body = Body;
            StoryUnitofWork.Save();
        }



    }
}