using System;
using System.Collections.Generic;
using GolpoPuri.Library;

namespace GolpoPuri.DAL
{
    public interface IStoryModel
    {
        Story CreateStory(string Title, string Body, string ImageUrl);
        void DeleteStory(Guid id);
        IEnumerable<Story> GetStories();
        Story GetStory(Guid id);
        void UpdateStory(Guid id, string title, string Body);
    }
}