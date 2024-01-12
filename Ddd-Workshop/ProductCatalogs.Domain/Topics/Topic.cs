namespace ProductCatalogs.Domain.Topics
{
    public class Topic
    {
        public Topic(string title)
        {
            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
    }
}
