namespace AllAboutWillWood.Models
{
    public class StoryViewModel
    {
        public StoryPost NewStory { get; set; } = new StoryPost();
        public List<StoryPost> Stories { get; set; } = new List<StoryPost>();
    }
}
